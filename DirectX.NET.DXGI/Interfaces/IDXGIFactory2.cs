#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <see cref="IDXGIFactory2" /> interface includes methods to create a newer version swap chain with more features
    ///     than
    ///     <see cref="IDXGISwapChain" /> and to monitor stereoscopic 3D capabilities.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIFactory1" />
    [Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIFactory2 : IDXGIFactory1
    {
        /// <summary>
        ///     Determines whether to use stereo mode.
        /// </summary>
        /// <returns>
        ///     <c>true</c> if [is stereo enabled]; otherwise, <c>false</c>.
        /// </returns>
        bool IsWindowedStereoEnabled();

        /// <summary>
        ///     Creates a swap chain that is associated with an HWND handle to the output window for the swap chain.
        /// </summary>
        /// <param name="device">
        ///     For Direct3D 11, and earlier versions of Direct3D, this is a interface to the Direct3D device for
        ///     the swap chain. For Direct3D 12 this is a interface to a direct command queue (refer to ID3D12CommandQueue). This
        ///     parameter cannot be <see langword="null" />.
        /// </param>
        /// <param name="windowHandle">
        ///     The window handle that is associated with the swap chain that <b>CreateSwapChainForHwnd</b> creates.
        ///     This parameter cannot be <see cref="IntPtr.Zero" />.
        /// </param>
        /// <param name="swapChainDescription">
        ///     A <see cref="DXGISwapChainDescription1" /> structure for the swap-chain description.
        ///     This parameter cannot be null.
        /// </param>
        /// <param name="fullscreenDescription">
        ///     A <see cref="DXGISwapChainFullscreenDescription" /> structure for the description of a
        ///     full-screen swap chain. You can optionally set this parameter to create a full-screen swap chain. Set it to null to
        ///     create a windowed swap chain.
        /// </param>
        /// <param name="restrictToOutput">
        ///     A pointer to the <see cref="IDXGIOutput" /> interface for the output to restrict content to. You must also pass the
        ///     <see cref="DXGIPresentFlags.RestrictToOutput" /> flag in a <see cref="IDXGISwapChain1.Present1" /> call to force
        ///     the content to appear blacked out
        ///     on any other output. If you want to restrict the content to a different output, you must create a new swap chain.
        ///     However, you can conditionally restrict content based on the <see cref="DXGIPresentFlags.RestrictToOutput" /> flag.
        ///     Set this parameter to null if you don't want to restrict content to an output target.
        /// </param>
        /// <param name="swapChain">
        ///     A out variable that receives a interface to the <see cref="IDXGISwapChain1" /> interface for
        ///     the swap chain that <b>CreateSwapChainForHwnd</b> creates.
        /// </param>
        /// <returns></returns>
        int CreateSwapChainForHwnd
        (
            IUnknown device,
            IntPtr windowHandle,
            in DXGISwapChainDescription1 swapChainDescription,
            in DXGISwapChainFullscreenDescription fullscreenDescription,
            IDXGIOutput restrictToOutput,
            out IDXGISwapChain1 swapChain
        );

        /// <summary>
        ///     Creates a swap chain that is associated with the
        ///     <a href="https://msdn.microsoft.com/sk-sk/windows/desktop/windows.ui.core.corewindow">CoreWindow</a> object for the
        ///     output window for the swap chain.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="window">The window.</param>
        /// <param name="swapChainDescription">The swap chain description.</param>
        /// <param name="restrictToOutput">The restrict to output.</param>
        /// <param name="swapChain">The swap chain.</param>
        /// <returns></returns>
        int CreateSwapChainForCoreWindow
        (
            IUnknown device,
            IUnknown window,
            in DXGISwapChainDescription1 swapChainDescription,
            IDXGIOutput restrictToOutput,
            out IDXGISwapChain1 swapChain
        );

        //FIXME: XXX Documentation XXX

        /// <summary>
        ///     Gets the shared resource adapter luid.
        /// </summary>
        /// <param name="handleResource">The handle resource.</param>
        /// <param name="luid">The luid.</param>
        /// <returns></returns>
        int GetSharedResourceAdapterLuid
        (
            IntPtr handleResource,
            out Luid luid
        );

        /// <summary>
        ///     Registers the stereo status window.
        /// </summary>
        /// <param name="windowHandle">The window handle.</param>
        /// <param name="windowMessage">The window message.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int RegisterStereoStatusWindow
        (
            IntPtr windowHandle,
            uint windowMessage,
            out uint cookie
        );

        /// <summary>
        ///     Registers the stereo status event.
        /// </summary>
        /// <param name="handleEvent">The handle event.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int RegisterStereoStatusEvent
        (
            IntPtr handleEvent,
            out uint cookie
        );

        /// <summary>
        ///     Unregisters the stereo status.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int UnregisterStereoStatus
        (
            uint cookie
        );

        /// <summary>
        ///     Registers the occlusion status window.
        /// </summary>
        /// <param name="windowHandle">The window handle.</param>
        /// <param name="windowMessage">The window message.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int RegisterOcclusionStatusWindow
        (
            IntPtr windowHandle,
            uint windowMessage,
            out uint cookie
        );

        /// <summary>
        ///     Registers the occlusion status event.
        /// </summary>
        /// <param name="eventHandle">The event handle.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int RegisterOcclusionStatusEvent
        (
            IntPtr eventHandle,
            out uint cookie
        );


        /// <summary>
        ///     Unregisters the occlusion status.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        int UnregisterOcclusionStatus(uint cookie);

        /// <summary>
        ///     Creates the swap chain for composition.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="swapChainDescription">The swap chain description.</param>
        /// <param name="restrictToOutput">The restrict to output.</param>
        /// <param name="swapChain">The swap chain.</param>
        /// <returns></returns>
        int CreateSwapChainForComposition
        (
            IUnknown device,
            in DXGISwapChainDescription1 swapChainDescription,
            IDXGIOutput restrictToOutput,
            out IDXGISwapChain1 swapChain
        );
    }
}