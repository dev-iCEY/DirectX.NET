#region Usings

using System.Diagnostics;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes a display mode.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     DebuggerDisplay("{Width}x{Height} @ {RefreshRate}")]
    public readonly struct DXGIModeDescription
    {
        /// <summary>
        ///     A value describing the resolution width.
        /// </summary>
        public uint Width { get; }

        /// <summary>
        ///     A value describing the resolution height.
        /// </summary>
        public uint Height { get; }

        /// <summary>
        ///     A <seealso cref="DXGIRational" /> structure describing the refresh rate in hertz
        /// </summary>
        public DXGIRational RefreshRate { get; }

        /// <summary>
        ///     A <seealso cref="DXGIFormat" /> enum describing the display format.
        /// </summary>
        public DXGIFormat Format { get; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeScanlineOrder" /> enumerated type describing the scanline drawing mode.
        /// </summary>
        public DXGIModeScanlineOrder ScanlineOrdering { get; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeScaling" /> enumerated type describing the scaling mode.
        /// </summary>
        public DXGIModeScaling Scaling { get; }


        /// <summary>
        ///     Converts to string.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Width}x{Height} @ {RefreshRate}";
        }
    }
}