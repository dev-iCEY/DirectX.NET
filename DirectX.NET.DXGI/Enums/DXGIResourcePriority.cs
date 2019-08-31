#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIResourcePriority : uint
    {
        /// <summary>
        ///     The resource is unused and can be evicted as soon as another resource requires the memory that the resource
        ///     occupies.
        /// </summary>
        Minimum = 0x28000000u,

        /// <summary>
        ///     The eviction priority of the resource is low. The placement of the resource is not critical, and minimal work is
        ///     performed to find a location for the resource. For example, if a GPU can render with a vertex buffer from either
        ///     local or non-local memory with little difference in performance, that vertex buffer is low priority. Other more
        ///     critical resources (for example, a render target or texture) can then occupy the faster memory.
        /// </summary>
        Low = 0x50000000u,

        /// <summary>
        ///     The eviction priority of the resource is normal. The placement of the resource is important, but not critical, for
        ///     performance. The resource is placed in its preferred location instead of a low-priority resource.
        /// </summary>
        Normal = 0x78000000u,

        /// <summary>
        ///     The eviction priority of the resource is high. The resource is placed in its preferred location instead of a
        ///     low-priority or normal-priority resource.
        /// </summary>
        High = 0xa0000000u,

        /// <summary>
        ///     The resource is evicted from memory only if there is no other way of resolving the memory requirement.
        /// </summary>
        Maximum = 0xc8000000u
    }
}