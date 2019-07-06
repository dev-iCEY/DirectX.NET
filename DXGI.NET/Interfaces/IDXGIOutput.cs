#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput : IDXGIObject
    {
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
        int
#else
        void
#endif
            GetDesc
            (
                out OutputDesc desc
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDisplayModeList
            (
                Format format,
                uint flags,
                [In, Out] uint numModes,
                [In, Out, Optional, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                ModeDesc[] modesDesc
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            FindClosestMatchingMode
            (
                [In] ref ModeDesc modeMatch,
                out ModeDesc closestMatch,
                [MarshalAs(UnmanagedType.IUnknown)] out object concernedDevice
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            WaitForVBlank();

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            TakeOwnership
            (
                object device,
                [MarshalAs(UnmanagedType.Bool)] bool isExclusive
            );

        void ReleaseOwnership();

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetGammaControlCapabilities
            (
                out GammaControlCapabilities gammaControlCapabilities
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetGammaControl
            (
                [In] ref GammaControl gammaControl
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetGammaControl
            (
                out GammaControl gammaControl
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetDisplaySurface
            (
                IDXGISurface surface
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDisplaySurfaceData
            (
                IDXGISurface surface
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
    }
}