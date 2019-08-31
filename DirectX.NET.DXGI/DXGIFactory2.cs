using System;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIFactory1" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIFactory2" />
    public class DXGIFactory2 : DXGIFactory1, IDXGIFactory2
    {
        /// <summary>
        /// The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIFactory1.LastMethodId + 11u;

        /// <summary>
        /// The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIFactory2).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory1" /> class.
        /// </summary>
        public DXGIFactory2() : this(DXGINativeMethods.CreateFactory2())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory1" /> class.
        /// </summary>
        /// <param name="objectPtr"></param>
        public DXGIFactory2(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Determines whether to use stereo mode.
        /// </summary>
        /// <returns>
        ///     <c>true</c> if [is stereo enabled]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsWindowedStereoEnabled()
        {
            return GetMethodDelegate<DXGIIsWindowedStereoEnabledDelegate>()
                .Invoke(this);
        }

        /// <summary>
        ///     Creates a swap chain that is associated with an HWND handle to the output window for the swap chain.
        /// </summary>
        /// <param name="device">
        ///     For Direct3D 11, and earlier versions of Direct3D, this is a interface to the Direct3D device for
        ///     the swap chain. For Direct3D 12 this is a interface to a direct command queue (refer to ID3D12CommandQueue). This
        ///     parameter cannot be <see langword="null" />.
        /// </param>
        /// <param name="windowHandle">
        ///     The window handle that is associated with the swap chain that <b>CreateSwapChainForHwnd</b> creates.
        ///     This parameter cannot be <see cref="IntPtr.Zero" />.
        /// </param>
        /// <param name="swapChainDescription">
        ///     A <see cref="DXGISwapChainDescription1" /> structure for the swap-chain description.
        ///     This parameter cannot be null.
        /// </param>
        /// <param name="fullscreenDescription">
        ///     A <see cref="DXGISwapChainFullscreenDescription" /> structure for the description of a
        ///     full-screen swap chain. You can optionally set this parameter to create a full-screen swap chain. Set it to null to
        ///     create a windowed swap chain.
        /// </param>
        /// <param name="restrictToOutput">
        ///     A pointer to the <see cref="IDXGIOutput" /> interface for the output to restrict content to. You must also pass the
        ///     <see cref="DXGIPresentFlags.RestrictToOutput" /> flag in a <see cref="IDXGISwapChain1.Present1" /> call to force
        ///     the content to appear blacked out
        ///     on any other output. If you want to restrict the content to a different output, you must create a new swap chain.
        ///     However, you can conditionally restrict content based on the <see cref="DXGIPresentFlags.RestrictToOutput" /> flag.
        ///     Set this parameter to null if you don't want to restrict content to an output target.
        /// </param>
        /// <param name="swapChain">
        ///     A out variable that receives a interface to the <see cref="IDXGISwapChain1" /> interface for
        ///     the swap chain that <b>CreateSwapChainForHwnd</b> creates.
        /// </param>
        /// <returns></returns>
        public int CreateSwapChainForHwnd(IUnknown device, IntPtr windowHandle, in DXGISwapChainDescription1 swapChainDescription,
            in DXGISwapChainFullscreenDescription fullscreenDescription, IDXGIOutput restrictToOutput,
            out IDXGISwapChain1 swapChain)
        {
            int result = GetMethodDelegate<DXGICreateSwapChainForHwndDelegate>()
                .Invoke(this, (Unknown) device, windowHandle, swapChainDescription, fullscreenDescription,
                    (DXGIOutput) restrictToOutput, out IntPtr swapChainPtr);

            swapChain = result == 0 ? new DXGISwapChain1(swapChainPtr) : null;

            return result;
        }

        /// <summary>
        ///     Creates a swap chain that is associated with the
        ///     <a href="https://msdn.microsoft.com/sk-sk/windows/desktop/windows.ui.core.corewindow">CoreWindow</a> object for the
        ///     output window for the swap chain.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="window">The window.</param>
        /// <param name="swapChainDescription">The swap chain description.</param>
        /// <param name="restrictToOutput">The restrict to output.</param>
        /// <param name="swapChain">The swap chain.</param>
        /// <returns></returns>
        public int CreateSwapChainForCoreWindow(IUnknown device, IUnknown window, in DXGISwapChainDescription1 swapChainDescription,
            IDXGIOutput restrictToOutput, out IDXGISwapChain1 swapChain)
        {
            int result = GetMethodDelegate<DXGICreateSwapChainForCoreWindowDelegate>()
                .Invoke
                (
                    this,
                    (Unknown) device,
                    (Unknown) window,
                    swapChainDescription,
                    (DXGIOutput) restrictToOutput,
                    out IntPtr swapChainPtr
                );
            swapChain = result == 0 ? new DXGISwapChain1(swapChainPtr) : null;
            return result;
        }

        /// <summary>
        ///     Gets the shared resource adapter luid.
        /// </summary>
        /// <param name="handleResource">The handle resource.</param>
        /// <param name="luid">The luid.</param>
        /// <returns></returns>
        public int GetSharedResourceAdapterLuid(IntPtr handleResource, out Luid luid)
        {
            return GetMethodDelegate<DXGIGetSharedResourceAdapterLuidDelegate>()
                .Invoke(this, handleResource, out luid);
        }

        /// <summary>
        ///     Registers the stereo status window.
        /// </summary>
        /// <param name="windowHandle">The window handle.</param>
        /// <param name="windowMessage">The window message.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int RegisterStereoStatusWindow(IntPtr windowHandle, uint windowMessage, out uint cookie)
        {
            return GetMethodDelegate<DXGIRegisterStereoStatusWindowDelegate>()
                .Invoke(this, windowHandle, windowMessage, out cookie);
        }

        /// <summary>
        ///     Registers the stereo status event.
        /// </summary>
        /// <param name="handleEvent">The handle event.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int RegisterStereoStatusEvent(IntPtr handleEvent, out uint cookie)
        {
            return GetMethodDelegate<DXGIRegisterStereoStatusEventDelegate>()
                .Invoke(this, handleEvent, out cookie);
        }

        /// <summary>
        ///     Unregisters the stereo status.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int UnregisterStereoStatus(uint cookie)
        {
            return GetMethodDelegate<DXGIUnregisterStereoStatusDelegate>()
                .Invoke(this, cookie);
        }

        /// <summary>
        ///     Registers the occlusion status window.
        /// </summary>
        /// <param name="windowHandle">The window handle.</param>
        /// <param name="windowMessage">The window message.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int RegisterOcclusionStatusWindow(IntPtr windowHandle, uint windowMessage, out uint cookie)
        {
            return GetMethodDelegate<DXGIRegisterOcclusionStatusWindowDelegate>()
                .Invoke(this, windowHandle, windowMessage, out cookie);
        }

        /// <summary>
        ///     Registers the occlusion status event.
        /// </summary>
        /// <param name="eventHandle">The event handle.</param>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int RegisterOcclusionStatusEvent(IntPtr eventHandle, out uint cookie)
        {
            return GetMethodDelegate<DXGIRegisterOcclusionStatusEventDelegate>()
                .Invoke(this, eventHandle, out cookie);
        }

        /// <summary>
        ///     Unregisters the occlusion status.
        /// </summary>
        /// <param name="cookie">The cookie.</param>
        /// <returns></returns>
        public int UnregisterOcclusionStatus(uint cookie)
        {
            return GetMethodDelegate<DXGIUnregisterOcclusionStatusDelegate>()
                .Invoke(this, cookie);
        }

        /// <summary>
        ///     Creates the swap chain for composition.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="swapChainDescription">The swap chain description.</param>
        /// <param name="restrictToOutput">The restrict to output.</param>
        /// <param name="swapChain">The swap chain.</param>
        /// <returns></returns>
        public int CreateSwapChainForComposition(IUnknown device, in DXGISwapChainDescription1 swapChainDescription,
            IDXGIOutput restrictToOutput, out IDXGISwapChain1 swapChain)
        {
            int result = GetMethodDelegate<DXGICreateSwapChainForCompositionDelegate>()
                .Invoke
                (
                    this,
                    (Unknown) device,
                    swapChainDescription,
                    (DXGIOutput) restrictToOutput,
                    out IntPtr swapChainPtr
                );

            swapChain = result == 0 ? new DXGISwapChain1(swapChainPtr) : null;
            return result;
        }

        [ComMethodId(DXGIFactory1.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool DXGIIsWindowedStereoEnabledDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIFactory1.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGICreateSwapChainForHwndDelegate
        (
            IntPtr thisPtr,
            IntPtr device,
            IntPtr windowHandle,
            in DXGISwapChainDescription1 description1,
            in DXGISwapChainFullscreenDescription fullscreenDescription,
            IntPtr outputPtr,
            out IntPtr swapChainPtr
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGICreateSwapChainForCoreWindowDelegate
        (
            IntPtr thisPtr,
            IntPtr devicePtr,
            IntPtr windowPtr,
            in DXGISwapChainDescription1 description1,
            IntPtr outputPtr,
            out IntPtr swapChainPtr
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 4u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetSharedResourceAdapterLuidDelegate
        (
            IntPtr thisPtr,
            IntPtr handleResourcePtr,
            out Luid luid
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 5u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIRegisterStereoStatusWindowDelegate
        (
            IntPtr thisPtr,
            IntPtr windowHandlePtr,
            uint windowMessage,
            out uint cookie
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 6u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIRegisterStereoStatusEventDelegate
        (
            IntPtr thisPtr,
            IntPtr eventHandlePtr,
            out uint cookie
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 7u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIUnregisterStereoStatusDelegate(IntPtr thisPtr, uint cookie);

        [ComMethodId(DXGIFactory1.LastMethodId + 8u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIRegisterOcclusionStatusWindowDelegate
        (
            IntPtr thisPtr,
            IntPtr windowHandle,
            uint windowMessage,
            out uint cookie
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 9u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIRegisterOcclusionStatusEventDelegate
        (
            IntPtr thisPtr,
            IntPtr eventHandlePtr,
            out uint cookie
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 10u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIUnregisterOcclusionStatusDelegate
        (
            IntPtr thisPtr,
            uint cookie
        );

        [ComMethodId(DXGIFactory1.LastMethodId + 11u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGICreateSwapChainForCompositionDelegate
        (
            IntPtr thisPtr,
            IntPtr device,
            in DXGISwapChainDescription1 description,
            IntPtr outputPtr,
            out IntPtr swapChainPtr
        );
    }
}