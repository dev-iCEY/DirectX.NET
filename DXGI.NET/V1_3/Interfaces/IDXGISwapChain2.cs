#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;
using DXGI.NET.V1_2;
using DXGI.NET.V1_2.Interfaces;

#endregion

namespace DXGI.NET.V1_3.Interfaces
{
    [ComImport, Guid("a8be2ac4-199f-4946-b331-79599fb98de7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain2 : IDXGISwapChain1
    {
        #region IDXGISwapChain1 methods

        #region IDXGISwapChain methods

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
            Present
            (
                uint syncInterval,
                PresentFlags flags = 0
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetBuffer
            (
                uint buffer,
                [In] ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object surface
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetFullscreenState
            (
                [MarshalAs(UnmanagedType.Bool)] bool state,
                [Optional] IDXGIOutput target
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetFullscreenState
            (
                [MarshalAs(UnmanagedType.Bool)] out bool state,
                out IDXGIOutput target
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDesc
            (
                out SwapChainDescription desc
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
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
        new int
#else
        new void
#endif
            ResizeTarget
            (
                [In] ref ModeDescription newTargetParameters
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetContainingOutput
            (
                out IDXGIOutput output
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetFrameStatistics
            (
                out FrameStatistics frameStatistics
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetLastPresentCount
            (
                out uint lastPresentCount
            );

        #endregion

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDesc1(out SwapChainDescription1 description1);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetFullscreenDesc(out SwapChainFullscreenDescription fullscreenDescription);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetHwnd(out IntPtr windowHandle);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetCoreWindow(ref Guid refiid, [MarshalAs(UnmanagedType.IUnknown)] out object unknownObject);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            Present1(uint syncInterval, PresentFlags flags, [In] ref PresentParameters presentParameters);

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsTemporaryMonoSupported();

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetRestrictToOutput(out IDXGIOutput restrictToOutput);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetBackgroundColor([In] ref Rgba color);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetBackgroundColor(out Rgba color);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetRotation(ModeRotation rotation);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetRotation(out ModeRotation rotation);

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetSourceSize(uint width, uint height);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetSourceSize(out uint width, out uint height);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetMaximumFrameLatency(uint maxLatency);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetMaximumFrameLatency(out uint maxLatency);

        IntPtr GetFrameLatencyWaitableObject();

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetMatrixTransform([In] ref Matrix3X2F matrix);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetMatrixTransform(out Matrix3X2F matrix);
    }
}