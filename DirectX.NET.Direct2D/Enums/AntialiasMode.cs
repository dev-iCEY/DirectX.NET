namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Enum which describes the manner in which we render edges of non-text primitives.
    /// </summary>
    public enum AntialiasMode : uint
    {
        /// <summary>
        ///     The edges of each primitive are antialiased sequentially.
        /// </summary>
        PerPrimitive = 0,

        /// <summary>
        ///     Each pixel is rendered if its pixel center is contained by the geometry.
        /// </summary>
        Aliased = 1
    }
}