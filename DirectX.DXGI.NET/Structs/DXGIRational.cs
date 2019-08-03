#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Represents a rational number.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIRational
    {
        /// <summary>
        ///     An unsigned integer value representing the top of the rational number.
        /// </summary>
        public uint Numerator { get; set; }

        /// <summary>
        ///     An unsigned integer value representing the bottom of the rational number.
        /// </summary>
        public uint Denominator { get; set; }
    }
}