#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;
using DXGI.NET.V1_2;
using DXGI.NET.V1_2.Interfaces;

#endregion

namespace DXGI.NET.V1_3.Interfaces
{
    [ComImport, Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactoryMedia
    {
#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateSwapChainForCompositionSurfaceHandle
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                IntPtr surfaceHandle,
                [In] ref SwapChainDescription1 desc,
                IDXGIOutput restrictOutput,
                out IDXGISwapChain1 swapChain);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CreateDecodeSwapChainForCompositionSurfaceHandle
            (
                [MarshalAs(UnmanagedType.IUnknown)] object device,
                IntPtr surfaceHandle,
                [In] ref DecodeSwapChainDescription description,
                IDXGIResource yuvDecodeBuffers,
                IDXGIDecodeSwapChain swapChain
            );
    }
}