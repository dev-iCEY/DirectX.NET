#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes a display mode.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming"),
     SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public struct DXGIModeDescription
    {
        /// <summary>
        ///     A value describing the resolution width.
        /// </summary>
        public uint Width { get; set; }

        /// <summary>
        ///     A value describing the resolution height.
        /// </summary>
        public uint Height { get; set; }

        /// <summary>
        ///     A <seealso cref="DXGIRational" /> structure describing the refresh rate in hertz
        /// </summary>
        public DXGIRational RefreshRate { get; set; }

        /// <summary>
        ///     A <seealso cref="DXGIFormat" /> enum describing the display format.
        /// </summary>
        public DXGIFormat Format { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeScanlineOrder" /> enumerated type describing the scanline drawing mode.
        /// </summary>
        public DXGIModeScanlineOrder ScanlineOrdering { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeScaling" /> enumerated type describing the scaling mode.
        /// </summary>
        public DXGIModeScaling Scaling { get; set; }
    }
}