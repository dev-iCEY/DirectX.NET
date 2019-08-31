#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes full-screen mode for a swap chain.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public readonly ref struct DXGISwapChainFullscreenDescription
    {
        /// <summary>
        ///     A <see cref="DXGIRational" /> structure that describes the refresh rate in hertz.
        /// </summary>
        public readonly DXGIRational RefreshRate;

        /// <summary>
        ///     A member of the <see cref="DXGIModeScanlineOrder" /> enumerated type that describes the scan-line drawing mode.
        /// </summary>
        public readonly DXGIModeScanlineOrder ScanlineOrdering;

        /// <summary>
        ///     A member of the <see cref="DXGIScaling" /> enumerated type that describes the scaling mode.
        /// </summary>
        public readonly DXGIScaling Scaling;

        /// <summary>
        ///     A Boolean value that specifies whether the swap chain is in windowed mode. <see langword="true" /> if the swap
        ///     chain is in windowed mode; otherwise, <see langword="false" />.
        /// </summary>
        [field: MarshalAs(UnmanagedType.Bool)] public readonly bool Windowed;

        /// <summary>Инициализирует новый экземпляр структуры <see cref="T:DirectX.NET.DXGI.DXGISwapChainFullscreenDescription" />.</summary>
        public DXGISwapChainFullscreenDescription(DXGIRational refreshRate, DXGIModeScanlineOrder scanlineOrdering,
            DXGIScaling scaling, bool windowed)
        {
            RefreshRate = refreshRate;
            ScanlineOrdering = scanlineOrdering;
            Scaling = scaling;
            Windowed = windowed;
        }
    }
}