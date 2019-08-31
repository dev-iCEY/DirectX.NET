#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An DXGIFactory interface implements methods for generating DXGI objects (which handle fullscreen transitions).
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIFactory : DXGIObject, IDXGIFactory
    {
        /// <summary>
        ///     The last method identifier.
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 5u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIFactory).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory" /> class.
        /// </summary>
        public DXGIFactory() :
            this(NativeMethods.CreateFactory())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory" /> class.
        /// </summary>
        /// <param name="objectPtr">Unmanaged native pointer to <seealso cref="IDXGIFactory" /> interface</param>
        public DXGIFactory(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>Enumerates the adapters (video cards).</summary>
        /// <param name="adapterIndex">The index of the adapter to enumerate.</param>
        /// <param name="adapter">
        ///     The address of a pointer to as <seealso cref="IDXGIAdapter" /> interface at the position specified by the Adapter
        ///     parameter. This parameter must not be NULL.
        /// </param>
        /// <returns>
        ///     Returns S_OK if successful; otherwise, returns DXGI_ERR_NOT_FOUND if the index is greater than or equal to the
        ///     number of adapters in the local system, or DXGI_ERR_INVALID_CALL if ppAdapter parameter is NULL.
        /// </returns>
        public int EnumAdapters(uint adapterIndex, out IDXGIAdapter adapter)
        {
            int result = GetMethodDelegate<EnumAdaptersDelegate>().Invoke(this, adapterIndex, out IntPtr adapterPtr);

            adapter = result == 0 ? new DXGIAdapter(adapterPtr) : null;

            return result;
        }

        /// <summary>
        ///     Allows DXGI to monitor an application's message queue for the alt-enter key sequence (which causes the application
        ///     to switch from windowed to fullscreen or vice versa).
        /// </summary>
        /// <param name="windowHandle">
        ///     The handle of the window that is to be monitored. This parameter can be
        ///     <seealso cref="IntPtr.Zero" />; but only if the flags are also 0.
        /// </param>
        /// <param name="flags"></param>
        /// <returns></returns>
        public int MakeWindowAssociation(IntPtr windowHandle, DXGIWindowAssociationFlags flags)
        {
            return GetMethodDelegate<MakeWindowAssociationDelegate>().Invoke(this, windowHandle, flags);
        }

        /// <summary>Get the window through which the user controls the transition to and from fullscreen.</summary>
        /// <param name="windowHandle">A pointer to a window handle.</param>
        /// <returns>
        ///     Returns a code that indicates success or failure. S_OK indicates success, DXGI_ERR_INVALID_CALL indicates
        ///     pWindowHandle was passed in as NULL.
        /// </returns>
        public int GetWindowAssociation(out IntPtr windowHandle)
        {
            return GetMethodDelegate<GetWindowAssociationDelegate>().Invoke(this, out windowHandle);
        }

        /// <summary>Creates a swap chain.</summary>
        /// <param name="device">
        ///     <seealso cref="DirectX.NET.Interfaces.IUnknown" /> to the device that will write 2D images to the
        ///     swap chain.
        /// </param>
        /// <param name="desc">
        ///     Swap-chain description (see <seealso cref="DXGISwapChainDescription" />). This parameter cannot be
        ///     <span class="keyword">
        ///         <span class="languageSpecificText">
        ///             <span class="cs">null</span><span class="vb">Nothing</span><span class="cpp">nullptr</span>
        ///         </span>
        ///     </span>
        ///     <span class="nu">a null reference (<span class="keyword">Nothing</span> in Visual Basic)</span>.
        /// </param>
        /// <param name="swapChain">A interface to the swap chain created (see <seealso cref="IDXGISwapChain" />).</param>
        /// <returns></returns>
        public int CreateSwapChain(IUnknown device, in DXGISwapChainDescription desc, out IDXGISwapChain swapChain)
        {
            int result = GetMethodDelegate<CreateSwapChainDelegate>()
                .Invoke(this, (Unknown) device, out IntPtr swapChainPtr);
            swapChain = result == 0 ? new DXGISwapChain(swapChainPtr) : null;
            return result;
        }

        /// <summary>Create an adapter interface that represents a software adapter.</summary>
        /// <param name="moduleHandle">
        ///     Handle to the software adapter's dll. HMODULE can be obtained with GetModuleHandle or
        ///     LoadLibrary.
        /// </param>
        /// <param name="softwareAdapter">Interface to an adapter (see <seealso cref="IDXGIAdapter" />).</param>
        /// <returns></returns>
        public int CreateSoftwareAdapter(IntPtr moduleHandle, out IDXGIAdapter softwareAdapter)
        {
            int result = GetMethodDelegate<CreateSoftwareAdapterDelegate>()
                .Invoke(this, moduleHandle, out IntPtr softwareAdapterPtr);
            softwareAdapter = result == 0 ? new DXGIAdapter(softwareAdapterPtr) : null;
            return result;
        }

        [ComMethodId(DXGIObject.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumAdaptersDelegate(IntPtr thisPtr, uint adapterIndex, out IntPtr adapterPtr);

        [ComMethodId(DXGIObject.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int MakeWindowAssociationDelegate(IntPtr thisPtr, IntPtr windowHandle,
            DXGIWindowAssociationFlags flags);

        [ComMethodId(DXGIObject.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetWindowAssociationDelegate(IntPtr thisPtr, out IntPtr windowHandle);

        [ComMethodId(DXGIObject.LastMethodId + 4u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSwapChainDelegate(IntPtr thisPtr, IntPtr devicePtr, out IntPtr swapChainPtr);

        [ComMethodId(DXGIObject.LastMethodId + 5u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSoftwareAdapterDelegate(IntPtr thisPtr, IntPtr hModule, out IntPtr adapterPtr);
    }
}