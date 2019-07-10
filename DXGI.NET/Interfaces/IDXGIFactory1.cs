#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("770aae78-f26f-4dba-a829-253c83d1b387"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory1 : IDXGIFactory
    {
        #region IDXGIFactory methods

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
            EnumAdapters
            (
                uint adapterIndex,
                out IDXGIAdapter adapter
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            MakeWindowAssociation
            (
                IntPtr windowHandle,
                WindowAssociationFlags flags
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetWindowAssociation
            (
                out IntPtr windowHandle
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            CreateSwapChain
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                [In] ref SwapChainDescription desc,
                out IDXGISwapChain swapChain
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            CreateSoftwareAdapter
            (
                IntPtr moduleHandle,
                out IDXGIAdapter softwareAdapter
            );

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1);

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsCurrent();
    }
}