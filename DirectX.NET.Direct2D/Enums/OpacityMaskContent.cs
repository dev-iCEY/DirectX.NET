namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specifies what the contents are of an opacity mask.
    /// </summary>
    public enum OpacityMaskContent : uint
    {
        /// <summary>
        ///     The mask contains geometries or bitmaps.
        /// </summary>
        Graphics = 0,

        /// <summary>
        ///     The mask contains text rendered using one of the natural text modes.
        /// </summary>
        TextNatural = 1,

        /// <summary>
        ///     The mask contains text rendered using one of the GDI compatible text modes.
        /// </summary>
        TextGdiCompatible = 2
    }
}