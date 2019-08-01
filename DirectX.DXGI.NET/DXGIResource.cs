#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIResource : DXGIDeviceSubObject, IDXGIResource
    {
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 4u;
        protected new readonly int MethodsCount = typeof(IDXGIResource).GetMethods().Length;

        public DXGIResource(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetSharedHandle(out IntPtr sharedHandle)
        {
            return GetMethodDelegate<GetSharedHandleDelegate>().Invoke(this, out sharedHandle);
        }

        public int GetUsage(out Usage usage)
        {
            return GetMethodDelegate<GetUsageDelegate>().Invoke(this, out usage);
        }

        public int SetEvictionPriority(uint evictionPriority)
        {
            return GetMethodDelegate<SetEvictionPriorityDelegate>().Invoke(this, evictionPriority);
        }

        public int GetEvictionPriority(out uint evictionPriority)
        {
            return GetMethodDelegate<GetEvictionPriorityDelegate>().Invoke(this, out evictionPriority);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetSharedHandleDelegate(IntPtr thisPtr, out IntPtr sharedHandlePtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetUsageDelegate(IntPtr thisPtr, out Usage usage);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetEvictionPriorityDelegate(IntPtr thisPtr, uint priority);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetEvictionPriorityDelegate(IntPtr thisPtr, out uint priority);
    }
}