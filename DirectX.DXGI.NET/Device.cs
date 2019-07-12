#region Usings

using System;
using System.Linq;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Device : Object, IDevice
    {
        protected new readonly int MethodsCount = typeof(IDevice).GetMethods().Length;
        protected new const uint LastMethodId = Object.LastMethodId + 5u;

        public Device(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetAdapter(out IAdapter adapter)
        {
            int result = GetMethodDelegate<GetAdapterDelegate>().Invoke(this, out IntPtr adapterPtr);
            adapter = result == 0 ? new Adapter(adapterPtr) : null;
            return result;
        }

        public int CreateSurface(in SurfaceDescription surfaceDesc, uint numSurfaces, Usage usage,
            in SharedResource sharedResource,
            out ISurface surface)
        {
            int result = GetMethodDelegate<CreateSurfaceDelegate>().Invoke(this, in surfaceDesc, numSurfaces, usage,
                in sharedResource, out IntPtr surfacePtr);
            surface = result == 0 ? new Surface(surfacePtr) : null;
            return result;
        }

        public int QueryResourceResidency(IResource[] resources, out Residency residencyStatus, uint numResources)
        {
            IntPtr[] pointers = resources.Select<IResource, IntPtr>(resource => (Resource) resource).ToArray();
            return GetMethodDelegate<QueryResourceResidencyDelegate>()
                .Invoke(this, in pointers, out residencyStatus, numResources);
        }

        public int SetGpuThreadPriority(int priority)
        {
            return GetMethodDelegate<SetGpuThreadPriorityDelegate>().Invoke(this, priority);
        }

        public int GetGpuThreadPriority(out int priority)
        {
            return GetMethodDelegate<GetGpuThreadPriorityDelegate>().Invoke(this, out priority);
        }

        [ComMethodId(Object.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetAdapterDelegate(IntPtr thisPtr, out IntPtr adapterPtr);

        [ComMethodId(Object.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSurfaceDelegate(IntPtr thisPtr, in SurfaceDescription surfaceDesc, uint numSurfaces,
            Usage usage, in SharedResource sharedResource, out IntPtr surfacePtr);

        [ComMethodId(Object.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int QueryResourceResidencyDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPArray)] in IntPtr[] ppResources, out Residency residencyStatus, uint numResources);

        [ComMethodId(Object.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetGpuThreadPriorityDelegate(IntPtr thisPtr, int priority);

        [ComMethodId(Object.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGpuThreadPriorityDelegate(IntPtr thisPtr, out int priority);
    }
}