#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.V1_2.Interfaces
{
    [ComImport, Guid("30961379-4609-4a41-998e-54fe567ee0c1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIResource1 : IDXGIResource
    {
        #region IDXGIResource methods

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
            GetSharedHandle
            (
                out IntPtr sharedHandle
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetUsage
            (
                out Usage usage
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetEvictionPriority
            (
                uint evictionPriority
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetEvictionPriority
            (
                out uint evictionPriority
            );

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateSubResourceSurface(uint index, out IDXGISurface surface);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateSharedHandle([In] ref SecurityAttributes attributes, uint access,
                [MarshalAs(UnmanagedType.LPWStr)] string name, out IntPtr handle);
    }
}