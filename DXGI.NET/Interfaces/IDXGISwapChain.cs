#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain : IDXGIDeviceSubObject
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
            Present
            (
                uint syncInterval,
                PresentFlags flags = 0
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetBuffer
            (
                uint buffer,
                [In] ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object surface
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetFullscreenState
            (
                [MarshalAs(UnmanagedType.Bool)] bool state,
                [Optional] IDXGIOutput target
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFullscreenState
            (
                [MarshalAs(UnmanagedType.Bool)] out bool state,
                out IDXGIOutput target
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDesc
            (
                out SwapChainDesc desc
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ResizeBuffers
            (
                uint bufferCount,
                uint width,
                uint height,
                Format newFormat,
                SwapChainFlag flags
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ResizeTarget
            (
                [In] ref ModeDesc newTargetParameters
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetContainingOutput
            (
                out IDXGIOutput output
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFrameStatistics
            (
                out FrameStatistics frameStatistics
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetLastPresentCount
            (
                out uint lastPresentCount
            );
    }
}