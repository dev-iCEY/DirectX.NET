namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     This defines the superset of interpolation mode supported by D2D APIs
    ///     and built-in effects
    /// </summary>
    public enum InterpolationModeDefinition : uint
    {
        NearestNeighbor = 0,
        Linear = 1,
        Cubic = 2,
        MultiSampleLinear = 3,
        Anisotropic = 4,
        HighQualityCubic = 5,
        Fant = 6,
        MipmapLinear = 7
    }
}