namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specifies the threading model of the created factory and all of its derived resources.
    /// </summary>
    public enum FactoryType : uint
    {
        /// <summary>
        ///     The resulting factory and derived resources may only be invoked serially.
        ///     Reference counts on resources are interlocked, however, resource and render
        ///     target state is not protected from multi-threaded access.
        /// </summary>
        SingleThreaded = 0,

        /// <summary>
        ///     The resulting factory may be invoked from multiple threads. Returned resources
        ///     use interlocked reference counting and their state is protected.
        /// </summary>
        MultiThreaded = 1
    }
}