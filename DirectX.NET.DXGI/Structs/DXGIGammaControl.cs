#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Controls the settings of a gamma curve.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIGammaControl
    {
        /// <summary>
        ///     A <seealso cref="DXGIRgb" /> structure with scalar values that are applied to rgb values before being sent to the
        ///     gamma look up table.
        /// </summary>
        public DXGIRgb Scale { get; set; }

        /// <summary>
        ///     A <seealso cref="DXGIRgb" /> structure with offset values that are applied to the rgb values before being sent to
        ///     the gamma look up table.
        /// </summary>
        public DXGIRgb Offset { get; set; }

        /// <summary>
        ///     An array of <seealso cref="DXGIRgb" /> structures that control the points of a gamma curve.
        /// </summary>
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public DXGIRgb[] GammaCurve { get; set; }
    }
}