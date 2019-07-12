#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET
{
    public class Unknown : IUnknown
    {
        public const uint LastMethodId = 2u;

        protected readonly int MethodsCount = typeof(IUnknown).GetMethods().Length;

        public Unknown(IntPtr objectPtr)
        {
            if (IntPtr.Zero == objectPtr)
            {
                throw new ArgumentException("IUnknown object pointer cannot be IntPtr.Zero or null.",
                    nameof(objectPtr));
            }

            Pointer = objectPtr;
            AddMethodsToVTableList(0, MethodsCount);
        }

        protected IntPtr Pointer { get; set; }

        public bool IsDisposed { get; protected set; }

        public bool IsValid => Pointer != IntPtr.Zero;

        protected List<IntPtr> VirtualTableAddresses { get; private set; } = new List<IntPtr>();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int QueryInterface(in Guid riid, out IntPtr unknownObjectPtr)
        {
            return GetMethodDelegate<QueryInterfaceDelegate>().Invoke(this, in riid, out unknownObjectPtr);
        }

        public uint AddRef()
        {
            return GetMethodDelegate<AddRefDelegate>().Invoke(this);
        }

        public uint Release()
        {
#if DEBUG
            uint result =
#else
            return
#endif
                GetMethodDelegate<ReleaseDelegate>().Invoke(this);

#if DEBUG
            Trace.WriteLine($"{typeof(Unknown).Namespace} — {this}.Release() return value: {result}", "DEBUG");
#endif

            return result;
        }

        protected virtual void Dispose(bool isDisposed)
        {
            if (IsDisposed || !IsValid)
            {
                IsDisposed = true;
                return;
            }

            Release();

            if (isDisposed)
            {
                Pointer = IntPtr.Zero;
                VirtualTableAddresses.Clear();
                VirtualTableAddresses = null;
            }

            IsDisposed = true;
        }

        ~Unknown()
        {
            Dispose(false);
        }

        protected void AddMethodsToVTableList(int startMethodId, int methodsCount)
        {
            IntPtr virtualTablePtr = Marshal.ReadIntPtr(this);

            for (int i = startMethodId; i < methodsCount + startMethodId; i++)
            {
                VirtualTableAddresses.Add(Marshal.ReadIntPtr(virtualTablePtr, i * IntPtr.Size));
            }
        }

        protected T GetMethodDelegate<T>() where T : Delegate
        {
            ComMethodIdAttribute attribute = typeof(T).GetCustomAttribute<ComMethodIdAttribute>();
            return Marshal.GetDelegateForFunctionPointer<T>(VirtualTableAddresses[(int) attribute.Id]);
        }

        public static implicit operator IntPtr(Unknown obj)
        {
            return obj.Pointer;
        }

        [ComMethodId(0u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int QueryInterfaceDelegate(IntPtr selfPtr, in Guid riid, out IntPtr unknownObjectPtr);

        [ComMethodId(1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate uint AddRefDelegate(IntPtr selfPtr);

        [ComMethodId(2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate uint ReleaseDelegate(IntPtr selfPtr);
    }
}