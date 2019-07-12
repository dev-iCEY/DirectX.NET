#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Resource : DeviceSubObject, IResource
    {
        protected new const uint LastMethodId = DeviceSubObject.LastMethodId + 4u;
        protected new readonly int MethodsCount = typeof(IResource).GetMethods().Length;

        public Resource(IntPtr objectPtr) : base(objectPtr)
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

        [ComMethodId(DeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetSharedHandleDelegate(IntPtr thisPtr, out IntPtr sharedHandlePtr);

        [ComMethodId(DeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetUsageDelegate(IntPtr thisPtr, out Usage usage);

        [ComMethodId(DeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetEvictionPriorityDelegate(IntPtr thisPtr, uint priority);

        [ComMethodId(DeviceSubObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetEvictionPriorityDelegate(IntPtr thisPtr, out uint priority);
    }
}