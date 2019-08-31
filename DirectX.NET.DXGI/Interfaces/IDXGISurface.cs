#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGISurface" /> interface implements methods for image-data objects.
    /// </summary>
    /// <seealso cref="IDXGIDeviceSubObject" />
    /// <remarks>
    ///     An image-data object is a 2D section of memory, commonly called a surface. To create a surface, call
    ///     <seealso cref="IDXGIDevice.CreateSurface" />. To get the surface from an output, call
    ///     <seealso cref="IDXGIOutput.GetDisplaySurfaceData" />.
    /// </remarks>
    [Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGISurface : IDXGIDeviceSubObject
    {
        /// <summary>
        ///     Get a description of the surface.
        /// </summary>
        /// <param name="surfaceDesc">A out struct to the surface description (see <seealso cref="DXGISurfaceDescription" />).</param>
        /// <returns></returns>
        int GetDesc(out DXGISurfaceDescription surfaceDesc);

        /// <summary>
        ///     Get a struct to the data contained in the surface, and deny GPU access to the surface.
        /// </summary>
        /// <param name="mappedRect">A ref to the surface data (see <seealso cref="DXGIMappedRect" />).</param>
        /// <param name="flags">CPU read-write flags. These flags can be combined with a logical OR. </param>
        /// <returns></returns>
        /// <remarks>
        ///     Use <seealso cref="IDXGISurface.Map" /> to access a surface from the CPU. To release a mapped surface (and allow
        ///     GPU access) call <seealso cref="IDXGISurface.UnMap" />.
        /// </remarks>
        int Map(ref DXGIMappedRect mappedRect, DXGIMap flags);

        /// <summary>
        ///     Invalidate the ref to the surface retrieved by <seealso cref="IDXGISurface.Map" /> and re-enable GPU access to the
        ///     resource.
        /// </summary>
        /// <returns></returns>
        int UnMap();
    }
}