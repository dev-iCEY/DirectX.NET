#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIResource1" /> interface extends the <seealso cref="IDXGIResource" /> interface by adding
    ///     support for creating a subresource surface object and for creating a handle to a shared resource.
    /// </summary>
    [Guid("30961379-4609-4a41-998e-54fe567ee0c1"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIResource1 : IDXGIResource
    {
        /// <summary>
        ///     Creates a subresource surface object.
        /// </summary>
        /// <param name="index">The index of the subresource surface object to enumerate.</param>
        /// <param name="surface">
        ///     Variable to a <seealso cref="IDXGISurface2" /> interface that represents the created subresource
        ///     surface object at the position specified by the index parameter.
        /// </param>
        /// <returns></returns>
        int CreateSubresourceSurface(uint index, out IDXGISurface2 surface);

        /// <summary>
        ///     Creates a handle to a shared resource. You can then use the returned handle with multiple Direct3D devices.
        /// </summary>
        /// <param name="securityAttributes">The security attributes.</param>
        /// <param name="sharedResourceAccess">The shared resource access.</param>
        /// <param name="name">
        ///     The name of the resource to share. The name is limited to MAX_PATH characters. Name comparison is
        ///     case sensitive.
        /// </param>
        /// <returns></returns>
        int CreateSharedHandle(in SecurityAttributes securityAttributes, DXGISharedResourceAccess sharedResourceAccess,
            string name);
    }
}