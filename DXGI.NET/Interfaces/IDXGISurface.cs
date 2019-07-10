#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISurface : IDXGIDeviceSubObject
    {
        #region IDXGIDeviceSubObject

        #region IDXGIObject methods

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetPrivateData
            (
                [In] ref Guid name,
                uint dataSize,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                byte[] data
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetPrivateDataInterface
            (
                [In] ref Guid name,
                [MarshalAs(UnmanagedType.IUnknown)] object iUnknown = null
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetPrivateData
            (
                [In] ref Guid name,
                ref uint dataSize,
                [In, Out, MarshalAs(UnmanagedType.LPArray)]
                byte[] data = null
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetParent
            (
                [In] ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object parent
            );

        #endregion

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDevice
            (
                ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object device
            );

        #endregion


#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDesc
            (
                out SurfaceDescription surfaceDesc
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            Map
            (
                out MappedRect mappedRect,
                Map flags
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            UnMap();
    }
}