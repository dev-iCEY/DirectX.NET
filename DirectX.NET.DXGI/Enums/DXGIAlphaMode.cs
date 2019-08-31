namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies the alpha value, transparency behavior, of a surface.
    /// </summary>
    public enum DXGIAlphaMode : uint
    {
        /// <summary>
        ///     Indicates that the transparency behavior is not specified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        ///     Indicates that the transparency behavior is premultiplied. Each color is first scaled by the alpha value. The alpha
        ///     value itself is the same in both straight and premultiplied alpha. Typically, no color channel value is greater
        ///     than the alpha channel value. If a color channel value in a premultiplied format is greater than the alpha channel,
        ///     the standard source-over blending math results in an additive blend.
        /// </summary>
        PreMultiplied = 1,

        /// <summary>
        ///     Indicates that the transparency behavior is not premultiplied. The alpha channel indicates the transparency of the
        ///     color.
        /// </summary>
        Straight = 2,

        /// <summary>
        ///     Indicates to ignore the transparency behavior.
        /// </summary>
        Ignore = 3
    }
}