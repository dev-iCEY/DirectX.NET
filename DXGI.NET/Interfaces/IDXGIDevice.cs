#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice : IDXGIObject
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
            GetAdapter(out IDXGIAdapter adapter);

#if !DEXP
        [PreserveSig]
        int
#else
        void
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
        int
#else
        void
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
        int
#else
        void
#endif
        SetGPUThreadPriority(int priority);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetGPUThreadPriority(out int priority);
    }
}