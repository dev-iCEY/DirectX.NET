#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIFactory" /> interface implements methods
    ///     for generating DXGI objects (which handle fullscreen transitions).
    /// </summary>
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIFactory : IDXGIObject
    {
        /// <summary>
        ///     Enumerates the adapters (video cards).
        /// </summary>
        /// <param name="adapterIndex">The index of the adapter to enumerate.</param>
        /// <param name="adapter">
        ///     The address of a pointer to as <seealso cref="IDXGIAdapter" /> interface at the position specified by the Adapter
        ///     parameter. This parameter must not be NULL.
        /// </param>
        /// <returns>
        ///     Returns S_OK if successful; otherwise, returns DXGI_ERR_NOT_FOUND if the index is greater than or equal to the
        ///     number of adapters in the local system, or DXGI_ERR_INVALID_CALL if ppAdapter parameter is NULL.
        /// </returns>
        int EnumAdapters(uint adapterIndex, out IDXGIAdapter adapter);

        /// <summary>
        ///     Allows DXGI to monitor an application's message queue for the alt-enter key sequence (which causes the application
        ///     to switch from windowed to fullscreen or vice versa).
        /// </summary>
        /// <param name="windowHandle">
        ///     The handle of the window that is to be monitored. This parameter can be
        ///     <seealso cref="IntPtr.Zero" />; but only if the flags are also 0.
        /// </param>
        /// <param name="flags"></param>
        int MakeWindowAssociation(IntPtr windowHandle, DXGIWindowAssociationFlags flags);

        /// <summary>
        ///     Get the window through which the user controls the transition to and from fullscreen.
        /// </summary>
        /// <param name="windowHandle">A pointer to a window handle.</param>
        /// <returns>
        ///     Returns a code that indicates success or failure. S_OK indicates success, DXGI_ERR_INVALID_CALL indicates
        ///     pWindowHandle was passed in as NULL.
        /// </returns>
        int GetWindowAssociation(out IntPtr windowHandle);

        /// <summary>
        ///     Creates a swap chain.
        /// </summary>
        /// <param name="device">
        ///     <seealso cref="DirectX.NET.Interfaces.IUnknown" /> to the device that will write 2D images to the
        ///     swap chain.
        /// </param>
        /// <param name="desc">
        ///     Swap-chain description (see <seealso cref="DXGISwapChainDescription" />). This parameter cannot be
        ///     <see langword="null" />.
        /// </param>
        /// <param name="swapChain">A interface to the swap chain created (see <seealso cref="IDXGISwapChain" />).</param>
        /// <returns></returns>
        int CreateSwapChain(IUnknown device, in DXGISwapChainDescription desc, out IDXGISwapChain swapChain);

        /// <summary>
        ///     Create an adapter interface that represents a software adapter.
        /// </summary>
        /// <param name="moduleHandle">
        ///     Handle to the software adapter's dll. HMODULE can be obtained with GetModuleHandle or
        ///     LoadLibrary.
        /// </param>
        /// <param name="softwareAdapter">Interface to an adapter (see <seealso cref="IDXGIAdapter" />).</param>
        /// <returns></returns>
        int CreateSoftwareAdapter(IntPtr moduleHandle, out IDXGIAdapter softwareAdapter);
    }
}