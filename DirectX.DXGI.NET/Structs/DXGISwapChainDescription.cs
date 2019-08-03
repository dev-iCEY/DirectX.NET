#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes a swap chain.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public ref struct DXGISwapChainDescription
    {
        /// <summary>
        ///     A <seealso cref="DXGIModeDescription" /> structure describing the backbuffer display mode.
        /// </summary>
        public DXGIModeDescription BufferDesc { get; set; }

        /// <summary>
        ///     A <seealso cref="DXGISampleDescription" /> structure describing multi-sampling parameters.
        /// </summary>
        public DXGISampleDescription SampleDesc { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIUsage" /> enumerated type describing the surface usage and CPU access options for
        ///     the back buffer. The back buffer can be used for shader input or render-target output.
        /// </summary>
        public DXGIUsage BufferUsage { get; set; }

        /// <summary>
        ///     A value that describes the number of buffers in the swap chain, including the front buffer.
        /// </summary>
        public uint BufferCount { get; set; }

        /// <summary>
        ///     An HWND handle to the output window. This member must not be NULL.
        /// </summary>
        public IntPtr OutputWindow { get; set; }

        /// <summary>
        ///     True if the output is in windowed mode; otherwise, false. For more information, see
        ///     <seealso cref="IDXGIFactory.CreateSwapChain" />.
        /// </summary>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Windowed { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="SwapEffect" /> enumerated type that describes options for handling the contents of
        ///     the presentation buffer after presenting a surface.
        /// </summary>
        public DXGISwapEffect SwapEffect { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGISwapChainFlag" /> enumerated type that describes options for swap-chain behavior.
        /// </summary>
        public DXGISwapChainFlag Flags { get; set; }
    }
}