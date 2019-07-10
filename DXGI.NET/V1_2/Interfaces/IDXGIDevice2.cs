﻿#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.V1_2.Interfaces
{
    [ComImport, Guid("05008617-fbfd-4051-a790-144884b4f6a9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice2 : IDXGIDevice1
    {
        #region IDXGIDevice1 methods

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
                [In] ref SurfaceDescription surfaceDesc,
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
        new int
#else
        new void
#endif
            SetMaximumFrameLatency(uint maxLatency);

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetMaximumFrameLatency(out uint maxLatency);

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            OfferResources(uint numResources, IDXGIResource[] resources, OfferResourcePriority priority);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ReclaimResources(uint numResources, IDXGIResource[] resources,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0, ArraySubType = UnmanagedType.Bool)]
                out bool[] discarded);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            EnqueueSetEvent(IntPtr eventHandle);
    }
}