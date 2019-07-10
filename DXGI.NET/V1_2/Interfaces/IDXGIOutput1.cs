#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Duplication.Interfaces;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.V1_2.Interfaces
{
    [ComImport, Guid("00cddea8-939b-4b83-a340-a685226666cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput1 : IDXGIOutput
    {
        #region IDXGIOutput methods

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
            GetDesc
            (
                out OutputDescription desc
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDisplayModeList
            (
                Format format,
                uint flags,
                [In, Out] uint numModes,
                [In, Out, Optional, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
                ModeDescription[] modesDesc
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            FindClosestMatchingMode
            (
                [In] ref ModeDescription modeMatch,
                out ModeDescription closestMatch,
                [MarshalAs(UnmanagedType.IUnknown)] out object concernedDevice
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            WaitForVBlank();

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            TakeOwnership
            (
                object device,
                [MarshalAs(UnmanagedType.Bool)] bool isExclusive
            );

        new void ReleaseOwnership();

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetGammaControlCapabilities
            (
                out GammaControlCapabilities gammaControlCapabilities
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetGammaControl
            (
                [In] ref GammaControl gammaControl
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new  void
#endif
            GetGammaControl
            (
                out GammaControl gammaControl
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetDisplaySurface
            (
                IDXGISurface surface
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDisplaySurfaceData
            (
                IDXGISurface surface
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

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDisplayModeList1
            (
                Format format,
                uint flags,
                [In, Out] uint numModes,
                [In, Out, Optional, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                ModeDescription1[] modesDesc
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            FindClosestMatchingMode1
            (
                [In] ref ModeDescription1 modeMatch,
                out ModeDescription1 closestMatch,
                [MarshalAs(UnmanagedType.IUnknown)] out object concernedDevice
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDisplaySurfaceData1
            (
                IDXGISurface destination
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            DuplicateOutput
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                out IDXGIOutputDuplication outputDuplication
            );
    }
}