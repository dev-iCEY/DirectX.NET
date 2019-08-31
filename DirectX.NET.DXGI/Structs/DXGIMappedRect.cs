#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     A mapped rectangle used for accessing a surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIMappedRect
    {
        /// <summary>
        ///     A value describing the width of the surface.
        /// </summary>
        public int Pitch { get; set; }

        /// <summary>
        ///     A pointer to the image buffer of the surface.
        /// </summary>
        public IntPtr Bits { get; set; }
    }
}