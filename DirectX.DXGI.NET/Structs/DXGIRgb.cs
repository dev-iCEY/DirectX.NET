#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Represents an RGB color.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIRgb
    {
        /// <summary>
        ///     A value representing the color of the red component. The range of this value is between 0 and 1.
        /// </summary>
        public float Red { get; set; }

        /// <summary>
        ///     A value representing the color of the green component. The range of this value is between 0 and 1.
        /// </summary>
        public float Green { get; set; }

        /// <summary>
        ///     A value representing the color of the blue component. The range of this value is between 0 and 1.
        /// </summary>
        public float Blue { get; set; }
    }
}