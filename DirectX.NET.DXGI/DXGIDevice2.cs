#region Usings

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="IDXGIDevice2" /> interface implements a derived class for DXGI objects that produce image data.
    ///     The interface exposes methods to block CPU processing until the GPU completes processing, and to offer resources to
    ///     the operating system.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIDevice1" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIDevice2" />
    [SuppressUnmanagedCodeSecurity]
    public class DXGIDevice2 : DXGIDevice1, IDXGIDevice2
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDevice1.LastMethodId + 3u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIDevice2).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIDevice1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIDevice2(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Allows the operating system to free the video memory of resources by discarding their content.
        /// </summary>
        /// <param name="numResources">The number of resources in the <b>resources</b> argument array.</param>
        /// <param name="resources">An array of <see cref="IDXGIResource" /> interfaces for the resources to offer.</param>
        /// <param name="priority">A <see cref="DXGIOfferResourcePriority" />-typed value that indicates how valuable data is.</param>
        /// <returns></returns>
        public int OfferResources(uint numResources, in IDXGIResource[] resources, DXGIOfferResourcePriority priority)
        {
            IntPtr[] tmp = resources.Select(resource => (IntPtr) (DXGIResource) resource).ToArray();
            return GetMethodDelegate<DXGIOfferResourcesDelegate>().Invoke(this, (uint) tmp.Length, ref tmp, priority);
        }

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
        public int ReclaimResources(uint numResources, in IDXGIResource[] resources, ref bool[] discarded)
        {
            IntPtr[] tmp = resources.Select(resource => (IntPtr) (DXGIResource) resource).ToArray();
            return GetMethodDelegate<DXGIReclaimResourcesDelegate>().Invoke(this, numResources, ref tmp, ref discarded);
        }

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
        public int EnqueueSetEvent(IntPtr eventHandle)
        {
            return GetMethodDelegate<DXGIEnqueueSetEventDelegate>().Invoke(this, eventHandle);
        }

        [ComMethodId(DXGIDevice1.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIOfferResourcesDelegate
        (
            IntPtr thisPtr,
            uint numResources,
            [MarshalAs(UnmanagedType.LPArray)] ref IntPtr[] offerResources,
            DXGIOfferResourcePriority priority
        );

        [ComMethodId(DXGIDevice1.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIReclaimResourcesDelegate
        (
            IntPtr thisPtr,
            uint numResources,
            [MarshalAs(UnmanagedType.LPArray)] ref IntPtr[] offerResources,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Bool)]
            ref bool[] discarded
        );

        [ComMethodId(DXGIDevice1.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIEnqueueSetEventDelegate(IntPtr thisPtr, IntPtr eventHandle);
    }
}