#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGIDevice2" /> interface implements a derived class for DXGI objects that produce image data.
    ///     The interface
    ///     exposes methods to block CPU processing until the GPU completes processing, and to offer resources to the operating
    ///     system.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIDevice1" />
    [Guid("05008617-fbfd-4051-a790-144884b4f6a9"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIDevice2 : IDXGIDevice1
    {
        /// <summary>
        ///     Allows the operating system to free the video memory of resources by discarding their content.
        /// </summary>
        /// <param name="numResources">The number of resources in the <b>resources</b> argument array.</param>
        /// <param name="resources">An array of <see cref="IDXGIResource" /> interfaces for the resources to offer.</param>
        /// <param name="priority">A <see cref="DXGIOfferResourcePriority" />-typed value that indicates how valuable data is.</param>
        /// <returns></returns>
        int OfferResources(uint numResources, in IDXGIResource[] resources, DXGIOfferResourcePriority priority);

        /// <summary>
        ///     Reclaims the resources.
        /// </summary>
        /// <param name="numResources">
        ///     The number of resources in the <b>resources</b> argument and <b>discarded</b> argument
        ///     arrays.
        /// </param>
        /// <param name="resources">The resources.</param>
        /// <param name="discarded">The discarded.</param>
        /// <returns></returns>
        int ReclaimResources(uint numResources, in IDXGIResource[] resources, ref bool[] discarded);

        /// <summary>
        ///     Flushes any outstanding rendering commands and sets the specified event object to the signaled state after all
        ///     previously submitted rendering commands complete.
        /// </summary>
        /// <param name="eventHandle">
        ///     A handle to the event object. The
        ///     <a href="https://docs.microsoft.com/windows/desktop/api/synchapi/nf-synchapi-createeventa">CreateEvent</a> or
        ///     <a href="https://docs.microsoft.com/windows/desktop/api/synchapi/nf-synchapi-openeventa">OpenEvent</a> function
        ///     returns this handle. All types of event objects
        ///     (manual-reset, auto-reset, and so on) are supported.
        ///     The handle must have the EVENT_MODIFY_STATE access right. For more information about access rights, see
        ///     <a href="https://docs.microsoft.com/windows/desktop/Sync/synchronization-object-security-and-access-rights">
        ///         Synchronization
        ///         Object Security and Access Rights
        ///     </a>
        ///     .
        /// </param>
        /// <returns></returns>
        int EnqueueSetEvent(IntPtr eventHandle);
    }
}