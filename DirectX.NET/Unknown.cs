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
        /// <summary>
        ///     The last method identifier.
        /// </summary>
        protected const uint LastMethodId = 2u;

        /// <summary>
        ///     The methods count of this class.
        /// </summary>
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

        /// <summary>
        ///     Gets or sets the pointer to unmanaged object.
        /// </summary>
        /// <value>
        ///     The pointer.
        /// </value>
        protected IntPtr Pointer { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; protected set; }

        /// <summary>
        ///     Returns true if <seealso cref="Pointer" /> is valid.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid => Pointer != IntPtr.Zero;

        /// <summary>
        ///     Gets the virtual table addresses.
        /// </summary>
        /// <value>
        ///     The virtual table addresses.
        /// </value>
        protected List<IntPtr> VirtualTableAddresses { get; private set; } = new List<IntPtr>();

        /// <summary>
        ///     Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых
        ///     ресурсов.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Queries the interface.
        /// </summary>
        /// <param name="riid">The riid.</param>
        /// <param name="unknownObjectPtr">The unknown object PTR.</param>
        /// <returns></returns>
        public int QueryInterface(in Guid riid, out IntPtr unknownObjectPtr)
        {
            return GetMethodDelegate<QueryInterfaceDelegate>().Invoke(this, in riid, out unknownObjectPtr);
        }

        /// <summary>
        ///     Adds the reference.
        /// </summary>
        /// <returns></returns>
        public uint AddRef()
        {
            return GetMethodDelegate<AddRefDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Releases this instance.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        ///     Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="isDisposed">
        ///     <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        ///     unmanaged resources.
        /// </param>
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

        /// <summary>
        ///     Finalizes an instance of the <see cref="Unknown" /> class.
        /// </summary>
        ~Unknown()
        {
            Dispose(false);
        }

        /// <summary>
        ///     Adds the methods to v table list.
        /// </summary>
        /// <param name="startMethodId">The start method identifier.</param>
        /// <param name="methodsCount">The methods count.</param>
        protected void AddMethodsToVTableList(int startMethodId, int methodsCount)
        {
            IntPtr virtualTablePtr = Marshal.ReadIntPtr(this);

            for (int i = startMethodId; i < methodsCount + startMethodId; i++)
            {
                VirtualTableAddresses.Add(Marshal.ReadIntPtr(virtualTablePtr, i * IntPtr.Size));
            }
        }

        /// <summary>
        ///     Gets the method delegate.
        /// </summary>
        /// <typeparam name="T">A type of delegate to get a delegate from v table list.</typeparam>
        /// <returns>A delegate from unmanaged function pointer.</returns>
        /// <exception cref="AttributeNotFoundException">
        ///     Type of delegate: {typeof(T)} does not contain attribute
        ///     `ComMethodIdAttribute`. Check this attribute is set.
        /// </exception>
        protected T GetMethodDelegate<T>() where T : Delegate
        {
            ComMethodIdAttribute attribute = typeof(T).GetCustomAttribute<ComMethodIdAttribute>();
            if (attribute == null)
            {
                throw new AttributeNotFoundException(
                    $"Type of delegate: {typeof(T)} does not contain attribute `ComMethodIdAttribute`. Check this attribute is set.");
            }

            return Marshal.GetDelegateForFunctionPointer<T>(VirtualTableAddresses[(int) attribute.Id]);
        }

        /// <summary>
        ///     Performs an implicit conversion from <see cref="Unknown" /> to <see cref="IntPtr" />.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
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