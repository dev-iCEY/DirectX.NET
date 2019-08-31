#region Usings

using System.Diagnostics.CodeAnalysis;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Options for handling pixels in a display surface after calling <seealso cref="IDXGISwapChain.Present" />.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGISwapEffect : uint
    {
        /// <summary>
        ///     Use this flag to indicate that the contents of the back buffer are discarded after calling
        ///     <seealso cref="IDXGISwapChain.Present" />.
        ///     This flag is valid for a swap chain with more than one back buffer, although, an application only has read and
        ///     write access to buffer 0. Use this flag to enable the display driver to select the most efficient presentation
        ///     technique for the swap chain.
        /// </summary>
        Discard = 0,

        /// <summary>
        ///     Use this flag to indicate that the contents of the back buffer are not discarded after calling
        ///     <seealso cref="IDXGISwapChain.Present" />. Use this option to present the contents of the swap chain in order, from
        ///     the first buffer
        ///     (buffer 0) to the last buffer. This flag cannot be used with multisampling.
        /// </summary>
        Sequential = 1,

        /// <summary>
        /// </summary>
        FlipSequential = 3,

        /// <summary>
        /// </summary>
        FlipDiscard = 4
    }
}