#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("77db970f-6276-48ba-ba28-070143b4392c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice1 : IDXGIDevice
    {
        #region IDXGIDevice methods

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
            GetAdapter(out IDXGIAdapter adapter);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            CreateSurface
            (
                [In] ref SurfaceDesc surfaceDesc,
                uint numSurfaces,
                Usage usage,
                ref SharedResource sharedResource,
                out IDXGISurface surface
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            QueryResourceResidency
            (
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
                IDXGIResource[] resources,
                out Residency residencyStatus,
                uint numResources
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetGPUThreadPriority(int priority);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetGPUThreadPriority(out int priority);

        #endregion

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
    }
}