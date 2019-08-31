#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIDevice" /> interface implements a derived class for DXGI objects that produce image data.
    /// </summary>
    [Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIDevice : IDXGIObject
    {
        /// <summary>
        ///     Returns the adapter for the specified device.
        /// </summary>
        /// <param name="adapter">
        ///     The address of an <seealso cref="IDXGIAdapter" /> interface pointer to the adapter. This
        ///     parameter must not be <seealso langword="null" />.
        /// </param>
        int GetAdapter(out IDXGIAdapter adapter);

        /// <summary>
        ///     This method is used internally and should not be called directly by your application code.
        /// </summary>
        /// <param name="surfaceDesc">A <seealso cref="DXGISurfaceDescription" /> structure that describes the surface.</param>
        /// <param name="numSurfaces">The number of surfaces to create.</param>
        /// <param name="usage">A <seealso cref="DXGIUsage" /> flag that specifies how the surface is expected to be used.</param>
        /// <param name="sharedResource">
        ///     An optional pointer to a <seealso cref="DXGISharedResource" /> structure that represents
        ///     shared resource information for opening views of such resources.
        /// </param>
        /// <param name="surfaces">
        ///     The address of an <seealso cref="IDXGISurface" /> interface pointer to the first created
        ///     surface.
        /// </param>
        /// <returns></returns>
        int CreateSurface(in DXGISurfaceDescription surfaceDesc, uint numSurfaces, DXGIUsage usage,
            in DXGISharedResource sharedResource, out IDXGISurface[] surfaces);

        /// <summary>
        ///     Gets the residency status of an array of resources.
        /// </summary>
        /// <param name="resources">An array of <seealso cref="IDXGIResource" /> interfaces.</param>
        /// <param name="residencyStatus">
        ///     An array of <seealso cref="DXGIResidency" /> flags. Each element describes the residency
        ///     status for corresponding element in the ppResources argument array.
        /// </param>
        /// <param name="numResources">
        ///     The number of resources in the resources argument array and residencyStatus argument
        ///     array.
        /// </param>
        /// <returns>
        ///     Returns S_OK if successfull; otherwise, returns D3DERR_DEVICEREMOVED (see D3DERR for more information),
        ///     E_INVALIDARG, or E_POINTER (see WinError.h for more information).
        /// </returns>
        int QueryResourceResidency(IDXGIResource[] resources, out DXGIResidency[] residencyStatus, uint numResources);

        /// <summary>
        ///     Sets the GPU thread priority
        /// </summary>
        /// <param name="priority">
        ///     A value that specifies the required GPU thread priority. This value must be between -7 and 7,
        ///     inclusive, where 0 represents normal priority.
        /// </param>
        /// <returns>Return S_OK if successful; otherwise, returns E_INVALIDARG if the Priority parameter is invalid.</returns>
        int SetGpuThreadPriority(int priority);

        /// <summary>
        ///     Gets the GPU thread priority.
        /// </summary>
        /// <param name="priority">
        ///     A pointer to a variable that receives a value that indicates the current GPU thread priority.
        ///     The value will be between -7 and 7, inclusive, where 0 represents normal priority.
        /// </param>
        /// <returns></returns>
        int GetGpuThreadPriority(out int priority);
    }
}