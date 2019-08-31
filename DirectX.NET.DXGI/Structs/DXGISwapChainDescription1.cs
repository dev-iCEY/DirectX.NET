#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes a swap chain.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGISwapChainDescription1
    {
        /// <summary>
        ///     A value that describes the resolution width. If you specify the width as zero when you call the
        ///     <see cref="IDXGIFactory2.CreateSwapChainForHwnd" /> method to create a swap chain, the runtime obtains the width
        ///     from the output
        ///     window and assigns this width value to the swap-chain description. You can subsequently call the
        ///     <see cref="IDXGISwapChain1.GetDesc1" /> method to retrieve the assigned width value. You cannot specify the width
        ///     as zero when
        ///     you call the <see cref="IDXGIFactory2.CreateSwapChainForComposition" /> method.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public uint Width { get; set; }

        /// <summary>
        ///     A value that describes the resolution height. If you specify the height as zero when you call the
        ///     <see cref="IDXGIFactory2.CreateSwapChainForHwnd" /> method to create a swap chain, the runtime obtains the height
        ///     from the output
        ///     window and assigns this height value to the swap-chain description. You can subsequently call the
        ///     <see cref="IDXGISwapChain1.GetDesc1" /> method to retrieve the assigned height value. You cannot specify the height
        ///     as zero when
        ///     you call the <see cref="IDXGIFactory2.CreateSwapChainForComposition" /> method.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public uint Height { get; set; }

        /// <summary>
        ///     A <see cref="DXGIFormat" /> structure that describes the display format.
        /// </summary>
        /// <value>
        ///     The format.
        /// </value>
        public DXGIFormat Format { get; set; }

        /// <summary>
        ///     Specifies whether the full-screen display mode or the swap-chain back buffer is stereo. <see langword="true" /> if
        ///     stereo; otherwise, <see langword="false" />.
        ///     If you specify stereo, you must also specify a flip-model swap chain (that is, a swap chain that has the
        ///     <see cref="DXGISwapEffect.Sequential" /> value set in the <b>SwapEffect</b> member).
        /// </summary>
        /// <value>
        ///     <c>true</c> if stereo; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Stereo { get; set; }

        /// <summary>
        ///     A <see cref="DXGISampleDescription" /> structure that describes multi-sampling parameters.
        ///     This member is valid only with bit-block transfer (bitblt) model swap chains.
        /// </summary>
        /// <value>
        ///     The sample description.
        /// </value>
        public DXGISampleDescription SampleDescription { get; set; }

        /// <summary>
        ///     A <see cref="DXGIUsage" />-typed value that describes the surface usage and CPU access options for the back buffer.
        ///     The back
        ///     buffer can be used for shader input or render-target output.
        /// </summary>
        /// <value>
        ///     The buffer usage.
        /// </value>
        public DXGIUsage BufferUsage { get; set; }

        /// <summary>
        ///     A value that describes the number of buffers in the swap chain. When you create a full-screen swap chain, you
        ///     typically include the front buffer in this value.
        /// </summary>
        /// <value>
        ///     The buffer count.
        /// </value>
        public uint BufferCount { get; set; }

        /// <summary>
        ///     A <see cref="DXGIScaling" />-typed value that identifies resize behavior if the size of the back buffer is not
        ///     equal to the target output.
        /// </summary>
        /// <value>
        ///     The scaling.
        /// </value>
        public DXGIScaling Scaling { get; set; }

        /// <summary>
        ///     A <see cref="DXGISwapEffect" />-typed value that describes the presentation model that is used by the swap chain
        ///     and options for
        ///     handling the contents of the presentation buffer after presenting a surface. You must specify the
        ///     <see cref="DXGISwapEffect.Sequential" /> value when you call the
        ///     <see cref="IDXGIFactory2.CreateSwapChainForComposition" /> method
        ///     because this method supports only flip presentation model.
        /// </summary>
        /// <value>
        ///     The swap effect.
        /// </value>
        public DXGISwapEffect SwapEffect { get; set; }

        /// <summary>
        ///     A <see cref="DXGIAlphaMode" />-typed value that identifies the transparency behavior of the swap-chain back buffer.
        /// </summary>
        /// <value>
        ///     The alpha mode.
        /// </value>
        public DXGIAlphaMode AlphaMode { get; set; }

        /// <summary>
        ///     A combination of <see cref="DXGISwapChainFlag" />-typed values that are combined by using a bitwise <see langword="|"/> operation.
        ///     The resulting value specifies options for swap-chain behavior.
        /// </summary>
        /// <value>
        ///     The flags.
        /// </value>
        public DXGISwapChainFlag Flags { get; set; }
    }
}