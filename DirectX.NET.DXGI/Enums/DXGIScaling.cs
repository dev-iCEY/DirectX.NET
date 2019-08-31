#region Usings

using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies resize behavior when the back-buffer size does not match the size of the target output.
    /// </summary>
    public enum DXGIScaling : uint
    {
        /// <summary>
        ///     Directs DXGI to make the back-buffer contents scale to fit the presentation target size. This is the implicit
        ///     behavior of DXGI when you call the <seealso cref="IDXGIFactory.CreateSwapChain" /> method.
        /// </summary>
        Stretch = 0,

        /// <summary>
        ///     Directs DXGI to make the back-buffer contents appear without any scaling when the presentation target size is not
        ///     equal to the back-buffer size. The top edges of the back buffer and presentation target are aligned together. If
        ///     the WS_EX_LAYOUTRTL style is associated with the HWND handle to the target output window, the right edges of the
        ///     back buffer and presentation target are aligned together; otherwise, the left edges are aligned together. All
        ///     target area outside the back buffer is filled with window background color.
        ///     This value specifies that all target areas outside the back buffer of a swap chain are filled with the background
        ///     color that you specify in a call to <seealso cref="IDXGISwapChain1.SetBackgroundColor" />.
        /// </summary>
        None = 1,

        /// <summary>
        ///     Directs DXGI to make the back-buffer contents scale to fit the presentation target size, while preserving the
        ///     aspect ratio of the back-buffer. If the scaled back-buffer does not fill the presentation area, it will be centered
        ///     with black borders.
        ///     This constant is supported on Windows Phone 8 and Windows 10.
        ///     Note that with legacy Win32 window swapchains, this works the same as <see cref="DXGIScaling.Stretch"/>.
        /// </summary>
        AspectRatioStretch = 2
    }
}