namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specifies the algorithm that is used when images are scaled or rotated. Note
    ///     Starting in Windows 8, more interpolations modes are available. See
    ///     <see cref="InterpolationMode" /> for more info.
    /// </summary>
    public enum BitmapInterpolationMode : uint
    {
        /// <summary>
        ///     Nearest Neighbor filtering. Also known as nearest pixel or nearest point
        ///     sampling.
        /// </summary>
        NearestNeighbor = InterpolationModeDefinition.NearestNeighbor,

        /// <summary>
        ///     Linear filtering.
        /// </summary>
        Linear = InterpolationModeDefinition.Linear
    }
}