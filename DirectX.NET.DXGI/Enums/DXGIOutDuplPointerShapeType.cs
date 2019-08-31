#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies the type of pointer shape.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIOutDuplPointerShapeType : uint // TODO: Maybe this is flags, need to check
    {
        /// <summary>
        ///     The pointer type is a monochrome mouse pointer, which is a monochrome bitmap. The bitmap's size is specified by
        ///     width and height in a 1 bits per pixel (bpp) device independent bitmap (DIB) format AND mask that is followed by
        ///     another 1 bpp DIB format XOR mask of the same size.
        /// </summary>
        Monochrome = 0x1,

        /// <summary>
        ///     The pointer type is a color mouse pointer, which is a color bitmap. The bitmap's size is specified by width and
        ///     height in a 32 bpp ARGB DIB format.
        /// </summary>
        Color = 0x2,

        /// <summary>
        ///     The pointer type is a masked color mouse pointer. A masked color mouse pointer is a 32 bpp ARGB format bitmap with
        ///     the mask value in the alpha bits. The only allowed mask values are 0 and 0xFF. When the mask value is 0, the RGB
        ///     value should replace the screen pixel. When the mask value is 0xFF, an XOR operation is performed on the RGB value
        ///     and the screen pixel; the result replaces the screen pixel.
        /// </summary>
        MaskedColor = 0x4
    }
}