#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("4AE63092-6327-4c1b-80AE-BFE12EA32B86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISurface1 : IDXGISurface
    {
        #region IDXGISurface methods

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
        new int
#else
        new void
#endif
            GetDesc
            (
                out SurfaceDesc surfaceDesc
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            Map
            (
                out MappedRect mappedRect,
                Map flags
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            UnMap();

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDC
            (
                [MarshalAs(UnmanagedType.Bool)] bool discard,
                out IntPtr dcHandle
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ReleaseDC
            (
                [In, MarshalAs(UnmanagedType.LPStruct)]
                ref Rect dirtyRect
            );
    }
}