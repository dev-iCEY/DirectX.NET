namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     This determines what gamma is used for interpolation/blending.
    /// </summary>
    public enum Gamma : uint
    {
        /// <summary>
        ///     Colors are manipulated in 2.2 gamma color space.
        /// </summary>
        Gamma22,

        /// <summary>
        ///     Colors are manipulated in 1.0 gamma color space.
        /// </summary>
        Gamma10
    }
}