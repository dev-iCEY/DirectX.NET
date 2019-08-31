#region Usings

using System.Diagnostics;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Represents a rational number.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     DebuggerDisplay("{Numerator != 0  && Denominator != 0 ? Numerator/Denominator : 0 }Hz")]
    public readonly struct DXGIRational
    {
        /// <summary>
        ///     An unsigned integer value representing the top of the rational number.
        /// </summary>
        public uint Numerator { get; }

        /// <summary>
        ///     An unsigned integer value representing the bottom of the rational number.
        /// </summary>
        public uint Denominator { get; }

        /// <summary>Инициализирует новый экземпляр класса <see cref="T:DirectX.NET.DXGI.DXGIRational" />.</summary>
        public DXGIRational(uint numerator, uint denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{(Numerator != 0 && Denominator != 0 ? Numerator / Denominator : 0)}Hz";
        }
    }
}