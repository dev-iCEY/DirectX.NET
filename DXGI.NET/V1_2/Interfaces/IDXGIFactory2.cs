#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.V1_2.Interfaces
{
    [ComImport, Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory2 : IDXGIFactory1
    {
        #region IDXGIFactory1 methods

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
        new int
#else
        new void
#endif
            EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1);

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsCurrent();

        #endregion

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsWindowedStereoEnabled();

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateSwapChainForHwnd
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                IntPtr windowHandle,
                [In] ref SwapChainDescription1 desc1,
                [In] ref SwapChainFullscreenDescription fsDesc,
                IDXGIOutput restrictOutput,
                out IDXGISwapChain1 swapChain1
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateSwapChainForCoreWindow
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                [MarshalAs(UnmanagedType.IUnknown)] object window,
                [In] ref SwapChainDescription1 desc1,
                IDXGIOutput restrictToOutput,
                out IDXGISwapChain1 swapChain1
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetSharedResourceAdapterLuid
            (
                IntPtr resourceHandle, 
                out Luid luid
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            RegisterStereoStatusWindow
            (
                IntPtr windowHandle,
                uint windowMessage,
                out uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            RegisterStereoStatusEvent
            (
                IntPtr eventHandle,
                out uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            UnRegisterStereoStatus
            (
                uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif

            RegisterOcclusionStatusWindow
            (
                IntPtr windowHandle,
                uint windowMessage,
                out uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            RegisterOcclusionStatusEvent
            (
                IntPtr eventHandle,
                out uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            UnRegisterOcclusionStatus
            (
                uint cookie
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif

            CreateSwapChainForComposition
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                [In] ref SwapChainDescription1 desc1,
                IDXGIOutput restrictToOutput,
                out IDXGISwapChain1 swapChain1
            );
    }
}