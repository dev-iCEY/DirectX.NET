namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Qualifies how alpha is to be treated in a bitmap or render target containing alpha.
    /// </summary>
    public enum AlphaMode : uint
    {
        //
        // Alpha mode should be determined implicitly. Some target surfaces do not supply
        // or imply this information in which case alpha must be specified.
        //
        Unknown = 0,

        //
        // Treat the alpha as premultipled.
        //
        PreMultiplied = 1,

        //
        // Opacity is in the 'A' component only.
        //
        Straight = 2,

        //
        // Ignore any alpha channel information.
        //
        Ignore = 3
    }
}