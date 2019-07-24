namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes how one geometry object is spatially related to another geometry object.
    /// </summary>
    public enum GeometryRelation : uint
    {
        /// <summary>
        ///     The relation between the geometries couldn't be determined. This value is never
        ///     returned by any D2D method.
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     The two geometries do not intersect at all.
        /// </summary>
        Disjoint = 1,

        /// <summary>
        ///     The passed in geometry is entirely contained by the object.
        /// </summary>
        IsContained = 2,

        /// <summary>
        ///     The object entirely contains the passed in geometry.
        /// </summary>
        Contains = 3,

        /// <summary>
        ///     The two geometries overlap but neither completely contains the other.
        /// </summary>
        Overlap = 4
    }
}