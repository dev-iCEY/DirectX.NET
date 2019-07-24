namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes the antialiasing mode used for drawing text.
    /// </summary>
    public enum TextAntialiasMode : uint
    {
        /// <summary>
        ///     Render text using the current system setting.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     Render text using ClearType.
        /// </summary>
        ClearType = 1,

        /// <summary>
        ///     Render text using gray-scale.
        /// </summary>
        GrayScale = 2,

        /// <summary>
        ///     Render text aliased.
        /// </summary>
        Aliased = 3
    }
}