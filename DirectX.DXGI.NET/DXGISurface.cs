#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGISurface : DXGIDeviceSubObject, IDXGISurface
    {
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 3u;
        protected new readonly int MethodsCount = typeof(IDXGISurface).GetMethods().Length;

        public DXGISurface(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDesc(out DXGISurfaceDescription surfaceDesc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out surfaceDesc);
        }

        public int Map(out DXGIMappedRect mappedRect, Map flags)
        {
            return GetMethodDelegate<MapDelegate>().Invoke(this, out mappedRect, flags);
        }

        public int UnMap()
        {
            return GetMethodDelegate<UnMapDelegate>().Invoke(this);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGISurfaceDescription surfaceDescription);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int MapDelegate(IntPtr thisPtr, out DXGIMappedRect rect, Map flags);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int UnMapDelegate(IntPtr thisPtr);
    }
}