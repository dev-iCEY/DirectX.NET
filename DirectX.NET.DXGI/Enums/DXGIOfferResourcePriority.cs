using DirectX.NET.DXGI.Interfaces;

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies the importance of a resource’s content when you call the <see cref="IDXGIDevice2.OfferResources" />
    ///     method to offer the resource.
    /// </summary>
    /// <remarks>
    ///     Priority determines how likely the operating system is to discard an offered resource. Resources offered with
    ///     lower priority are discarded first.
    /// </remarks>
    public enum DXGIOfferResourcePriority : uint
    {
        /// <summary>
        ///     The resource is low priority. The operating system discards a low priority resource before other offered resources
        ///     with higher priority. It is a good programming practice to mark a resource as low priority if it has no useful
        ///     content.
        /// </summary>
        Low = 1,

        /// <summary>
        ///     The resource is normal priority. You mark a resource as normal priority if it has content that is easy to
        ///     regenerate.
        /// </summary>
        Normal = Low + 1u,

        /// <summary>
        ///     The resource is high priority. The operating system discards other offered resources with lower priority before it
        ///     discards a high priority resource. You mark a resource as high priority if it has useful content that is difficult
        ///     to regenerate.
        /// </summary>
        High = Normal + 1u
    }
}