using System;
using System.Diagnostics.CodeAnalysis;
using DirectX.NET.DXGI.Interfaces;

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Options for swap-chain behavior.
    /// </summary>
    [Flags, SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGISwapChainFlag : uint
    {
        /// <summary>
        ///     Turn off automatic image rotation; that is, do not perform a rotation when transfering the contents of the front
        ///     buffer to the monitor. Use this flag to avoid a bandwidth penalty when an application expects to handle rotation.
        ///     This option is only valid during full-screen mode.
        /// </summary>
        NonPreRotated = 1,

        /// <summary>
        ///     Set this flag to enable an application to switch modes by calling <seealso cref="IDXGISwapChain.ResizeTarget" />.
        ///     When switching from
        ///     windowed to full-screen mode, the display mode (or monitor resolution) will be changed to match the dimensions of
        ///     the application window.
        /// </summary>
        AllowModeSwitch = 2,

        /// <summary>
        ///     Set this flag to enable an application to render using GDI on a swap chain or a surface. This will allow the
        ///     application to call GetDC on the 0th back buffer or a surface.
        /// </summary>
        GdiCompatible = 4,

        // FIXME: Add more docs
        /// <summary>
        /// </summary>
        RestrictedContent = 8,

        /// <summary>
        /// </summary>
        RestrictSharedResourceDriver = 16,

        /// <summary>
        /// </summary>
        DisplayOnly = 32,

        /// <summary>
        /// </summary>
        FrameLatencyWaitableObject = 64,

        /// <summary>
        /// </summary>
        ForegroundLayer = 128,

        /// <summary>
        /// </summary>
        FullscreenVideo = 256,

        /// <summary>
        /// </summary>
        YuvVideo = 512,

        /// <summary>
        /// </summary>
        HwProtected = 1024,

        /// <summary>
        /// </summary>
        AllowTearing = 2048,

        /// <summary>
        /// </summary>
        RestrictedToAllHolographicDisplays = 4096
    }
}