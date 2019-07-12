#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Surface : DeviceSubObject, ISurface
    {
        protected new const uint LastMethodId = DeviceSubObject.LastMethodId + 3u;
        protected new readonly int MethodsCount = typeof(ISurface).GetMethods().Length;

        public Surface(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDesc(out SurfaceDescription surfaceDesc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out surfaceDesc);
        }

        public int Map(out MappedRect mappedRect, Map flags)
        {
            return GetMethodDelegate<MapDelegate>().Invoke(this, out mappedRect, flags);
        }

        public int UnMap()
        {
            return GetMethodDelegate<UnMapDelegate>().Invoke(this);
        }

        [ComMethodId(DeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out SurfaceDescription surfaceDescription);

        [ComMethodId(DeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int MapDelegate(IntPtr thisPtr, out MappedRect rect, Map flags);

        [ComMethodId(DeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int UnMapDelegate(IntPtr thisPtr);
    }
}