#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIResource" /> interface allows resource sharing and identifies the memory that a resource
    ///     resides in.
    /// </summary>
    /// <seealso cref="IDXGIDeviceSubObject" />
    [Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIResource : IDXGIDeviceSubObject
    {
        /// <summary>
        ///     Get the handle to a shared resource. The returned handle can be used to open the resource using different Direct3D
        ///     devices.
        /// </summary>
        /// <param name="sharedHandle">A pointer to a handle.</param>
        /// <returns></returns>
        int GetSharedHandle(out IntPtr sharedHandle);

        /// <summary>
        ///     Get the expected resource usage.
        /// </summary>
        /// <param name="usage">
        ///     A out parameter to a usage flag (see <seealso cref="DXGIUsage" />). For Direct3D 10, a surface can
        ///     be used as a shader input or a render-target output.
        /// </param>
        /// <returns></returns>
        int GetUsage(out DXGIUsage usage);

        /// <summary>
        ///     Set the priority for evicting the resource from memory.
        /// </summary>
        /// <param name="evictionPriority">The eviction priority.</param>
        /// <returns></returns>
        /// <remarks>
        ///     The eviction priority is a memory-management variable that is used by DXGI for determining how to populate
        ///     overcommitted memory.
        ///     You can set priority levels other than the defined values when appropriate. For example, you can set a resource
        ///     with a priority level of 0x78000001 to indicate that the resource is slightly above normal.
        /// </remarks>
        int SetEvictionPriority(DXGIResourcePriority evictionPriority);

        /// <summary>
        ///     Get the eviction priority.
        /// </summary>
        /// <param name="evictionPriority">
        ///     A out parameter to the eviction priority, which determines when a resource can be
        ///     evicted from memory.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     The eviction priority is a memory-management variable that is used by DXGI to determine how to manage overcommitted
        ///     memory.
        ///     Priority levels other than the defined values are used when appropriate. For example, a resource with a priority
        ///     level of 0x78000001 indicates that the resource is slightly above normal.
        /// </remarks>
        int GetEvictionPriority(out DXGIResourcePriority evictionPriority);
    }
}