#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    /// ???
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIDisplayColorSpace
    {
        /// <summary>
        ///     Gets or sets the primary coordinates.
        /// </summary>
        /// <value>
        ///     The primary coordinates.
        /// </value>
        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 16)]
        public float[][] PrimaryCoordinates { get; set; }

        /// <summary>
        ///     Gets or sets the white points.
        /// </summary>
        /// <value>
        ///     The white points.
        /// </value>
        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 32)]
        public float[][] WhitePoints { get; set; }
    }
}