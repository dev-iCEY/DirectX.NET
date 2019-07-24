namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specifies how a device context is initialized for GDI rendering when it is retrieved from the render target.
    /// </summary>
    public enum DcInitializeMode : uint
    {
        /// <summary>
        ///     The contents of the D2D render target will be copied to the DC.
        /// </summary>
        Copy = 0,

        /// <summary>
        ///     The contents of the DC will be cleared.
        /// </summary>
        Clear = 1
    }
}