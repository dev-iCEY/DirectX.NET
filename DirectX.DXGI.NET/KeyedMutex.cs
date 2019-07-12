#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class KeyedMutex : DeviceSubObject, IKeyedMutex
    {
        protected new const uint LastMethodId = DeviceSubObject.LastMethodId + 2u;
        protected new readonly int MethodsCount = typeof(IKeyedMutex).GetMethods().Length;

        public KeyedMutex(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int AcquireSync(ulong key, uint milliseconds)
        {
            return GetMethodDelegate<AcquireSyncDelegate>().Invoke(this, key, milliseconds);
        }

        public int ReleaseSync(ulong key)
        {
            return GetMethodDelegate<ReleaseSyncDelegate>().Invoke(this, key);
        }

        [ComMethodId(DeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AcquireSyncDelegate(IntPtr thisPtr, ulong key, uint ms);

        [ComMethodId(DeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseSyncDelegate(IntPtr thisPtr, ulong key);
    }
}