#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Flags indicating the method the raster uses to create an image on a surface.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIModeScanlineOrder : uint
    {
        /// <summary>
        ///     Scanline order is unspecified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        ///     The image is created from the first scanline to the last without skipping any.
        /// </summary>
        Progressive = 1,

        /// <summary>
        ///     The image is created beginning with the upper field.
        /// </summary>
        UpperFieldFirst = 2,

        /// <summary>
        ///     The image is created beginning with the lower field.
        /// </summary>
        LowerFieldFirst = 3
    }
}