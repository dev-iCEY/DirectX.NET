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
    ///     <inheritdoc cref="IDXGISwapChain" />
    /// </summary>
    /// <seealso cref="DXGIDeviceSubObject" />
    /// <seealso cref="IDXGISwapChain" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGISwapChain : DXGIDeviceSubObject, IDXGISwapChain
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 10u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGISwapChain).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGISwapChain" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGISwapChain(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Present a rendered image to the user.
        /// </summary>
        /// <param name="syncInterval">
        ///     An integer that specifies the how to synchronize presentation of a frame with the vertical
        ///     blank. Values are:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>0 - </term>
        ///             <description>The presentation occurs immediately, there is no synchronization.</description>
        ///         </item>
        ///         <item>
        ///             <term>1,2,3,4 - </term><description>Synchronize presentation after the n'th vertical blank. </description>
        ///         </item>
        ///     </list>
        ///     If the update region straddles more than one output (each represented by <seealso cref="IDXGIOutput" />), the
        ///     synchronization will be
        ///     performed to the output that contains the largest subrectangle of the target window's client area.
        /// </param>
        /// <param name="flags">
        ///     An integer value that contains swap-chain presentation options (see
        ///     <seealso cref="DXGIPresentFlags" />).
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     For the best performance when flipping swap-chain buffers in full-screen application, see Full-Screen Application
        ///     Performance Hints.
        ///     Because calling Present may cause the render thread to wait on the message-pump thread care should be taken when
        ///     calling this method in an application that uses multiple threads. For more details, see Multithreading
        ///     Considerations.
        ///     <note>
        ///         Differences between Direct3D 9 and Direct3D 10:
        ///         Specifying DXGI_PRESENT_TEST in the Flags parameter is analogous to IDirect3DDevice9::TestCooperativeLevel in
        ///         D3D9.
        ///     </note>
        /// </remarks>
        public int Present(uint syncInterval, DXGIPresentFlags flags = 0)
        {
            return GetMethodDelegate<PresentDelegate>().Invoke(this, syncInterval, flags);
        }

        /// <summary>
        ///     Access one of the swap-chain back buffers.
        /// </summary>
        /// <param name="buffer">
        ///     A zero-based buffer index. If the swap effect is not <seealso cref="DXGISwapEffect.Sequential" />, this method only
        ///     has access to
        ///     the first buffer; for this case, set the index to zero.
        /// </param>
        /// <param name="riid">The type of interface used to manipulate the buffer. See remarks.</param>
        /// <param name="surface">A object to a back-buffer interface.</param>
        /// <returns></returns>
        /// <remarks>
        ///     Here is an example.
        ///     <example>
        ///         <code>
        /// ID3D10Texture2D pRT;
        /// ... // Get the surface from the swap chain
        /// pSwapChain.GetBuffer(0, typeof(ID3D10Texture2D).GUID, out pRT);
        /// </code>
        ///     </example>
        /// </remarks>
        public int GetBuffer(uint buffer, in Guid riid, out IUnknown surface)
        {
            int result = GetMethodDelegate<GetBufferDelegate>().Invoke(this, buffer, in riid, out IntPtr surfacePtr);
            surface = result == 0 ? new DXGISurface(surfacePtr) : null;
            return result;
        }

        /// <summary>
        ///     Set the display mode to windowed or full-screen.
        /// </summary>
        /// <param name="state">Use <seealso langword="true" /> for full-screen, <seealso langword="false" /> for windowed.</param>
        /// <param name="target">
        ///     If the current display mode is full-screen, this parameter must be the output target (see
        ///     <seealso cref="IDXGIOutput" />) that contains the swap chain; otherwise, this parameter is ignored.
        ///     If you set this parameter to <seealso langword="null" />,
        ///     DXGI will choose the output based on the swap-chain's device and the output window's placement.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     DXGI may change the display mode of a swap chain is response to user or system requests.
        /// </remarks>
        public int SetFullscreenState(bool state, IDXGIOutput target = null)
        {
            return GetMethodDelegate<SetFullscreenStateDelegate>()
                .Invoke(this, state, (DXGIOutput) target ?? IntPtr.Zero);
        }

        /// <summary>
        ///     Get the state associated with full-screen mode.
        /// </summary>
        /// <param name="state">
        ///     <list type="bullet">
        ///         <item>
        ///             <seealso langword="true" /> if the swap chain is in full-screen mode
        ///         </item>
        ///         <item>
        ///             <seealso langword="false" /> if the swap chain is in windowed mode
        ///         </item>
        ///     </list>
        /// </param>
        /// <param name="target">
        ///     A object to the output target (see <seealso cref="IDXGIOutput" />) when the mode is full screen;
        ///     otherwise <seealso langword="null" />.
        /// </param>
        /// <returns></returns>
        public int GetFullscreenState(out bool state, out IDXGIOutput target)
        {
            int result = GetMethodDelegate<GetFullscreenStateDelegate>().Invoke(this, out state, out IntPtr outputPtr);
            target = result == 0 && outputPtr != IntPtr.Zero ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        /// <summary>
        ///     Get a description of the swap chain.
        /// </summary>
        /// <param name="desc">A out parameter to the swap-chain description (see <seealso cref="DXGISwapChainDescription" />).</param>
        /// <returns></returns>
        public int GetDesc(out DXGISwapChainDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        /// <summary>
        ///     Change the swap chain's back buffer size, format, and number of buffers. This should be called when the application
        ///     window is resized.
        /// </summary>
        /// <param name="bufferCount">
        ///     The number of buffers in the swap chain (including all back and front buffers). This can be different from the
        ///     number of buffers the swap chain was created with.
        /// </param>
        /// <param name="width">
        ///     New width of the back buffer. If 0 is specified the width of the client area of the target window
        ///     will be used.
        /// </param>
        /// <param name="height">
        ///     New height of the back buffer. If 0 is specified the height of the client area of the target
        ///     window will be used.
        /// </param>
        /// <param name="newFormat">The new format of the back buffer. See <seealso cref="DXGIFormat" />.</param>
        /// <param name="flags">Flags that indicate how the swap chain will function. See <seealso cref="DXGISwapChainFlag" />.</param>
        /// <returns></returns>
        /// <remarks>
        ///     A swapchain cannot be resized unless all outstanding references to its back buffers have been released. The
        ///     application must release all of its direct and indirect references on the backbuffers in order for ResizeBuffers to
        ///     succeed.
        ///     Direct references are held by the application after calling AddRef on a resource.
        ///     Indirect references are held by views to a resource, binding a view of the resource to a device context, a command
        ///     list that used the resource, a command list that used a view to that resource, a command list that executed another
        ///     command list that used the resource, etc.
        ///     Before calling ResizeBuffers, ensure that the application releases all references (by calling the appropriate
        ///     number of Release invocations) on the resources, any views to the resource, any command lists that use either the
        ///     resources or views, and ensure that neither the resource, nor a view is still bound to a device context. ClearState
        ///     can be used to ensure this. If a view is bound to a deferred context, then the partially built command list must be
        ///     discarded as well (by calling ClearState, FinishCommandList, then Release on the command list). The application can
        ///     re-query interfaces after calling ResizeBuffers via <seealso cref="GetBuffer" />.
        ///     This method should be called whenever a client window is resized. It is recommended to call this API when an
        ///     application receives a WM_SIZE message
        /// </remarks>
        public int ResizeBuffers(uint bufferCount, uint width, uint height, DXGIFormat newFormat,
            DXGISwapChainFlag flags)
        {
            return GetMethodDelegate<ResizeBuffersDelegate>()
                .Invoke(this, bufferCount, width, height, newFormat, flags);
        }

        /// <summary>
        ///     Resize the output target.
        /// </summary>
        /// <param name="newTargetParameters">
        ///     A pointer to the mode description (see <seealso cref="DXGIModeDescription" />), which specifies the new width,
        ///     height, format and refresh rate of the target. If the format is <seealso cref="DXGIFormat.Unknown" />,
        ///     the existing format will be used. Using <seealso cref="DXGIFormat.Unknown" /> is only recommended when the swap
        ///     chain is in full-screen mode as this method is not thread safe.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     This function resizes the target window when the swap chain is in windowed mode, and changes the display mode on
        ///     the target output when the swap chain is in full-screen mode. Therefore, applications can call this method to
        ///     resize the target window (rather than a win32 API such as SetWindowPos) without knowledge of the swap chain display
        ///     mode.
        /// </remarks>
        public int ResizeTarget(in DXGIModeDescription newTargetParameters)
        {
            return GetMethodDelegate<ResizeTargetDelegate>().Invoke(this, in newTargetParameters);
        }

        /// <summary>
        ///     Get the output (the display monitor) that contains the majority of the client area of the target window.
        /// </summary>
        /// <param name="output">A reference to the output interface (see <seealso cref="IDXGIOutput" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     If the method succeeds, the output interface will be filled and its reference count incremented. When you are
        ///     finished with it, be sure to release the interface to avoid a memory leak.
        ///     The output is also owned by the adapter on which the swap chain's device was created.
        /// </remarks>
        public int GetContainingOutput(out IDXGIOutput output)
        {
            int result = GetMethodDelegate<GetContainingOutputDelegate>().Invoke(this, out IntPtr outputPtr);
            output = result == 0 ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        /// <summary>
        ///     Get performance statistics about the last render frame.
        /// </summary>
        /// <param name="frameStatistics">A out parameter to the frame statistics (see <seealso cref="DXGIFrameStatistics" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     This method is not supported when the swap chain is windowed.
        /// </remarks>
        public int GetFrameStatistics(out DXGIFrameStatistics frameStatistics)
        {
            return GetMethodDelegate<GetFrameStatisticsDelegate>().Invoke(this, out frameStatistics);
        }

        /// <summary>
        ///     Get the number of times <seealso cref="Present" /> has been called.
        /// </summary>
        /// <param name="lastPresentCount">A out parameter to the number of calls.</param>
        /// <returns></returns>
        public int GetLastPresentCount(out uint lastPresentCount)
        {
            return GetMethodDelegate<GetLastPresentCountDelegate>().Invoke(this, out lastPresentCount);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int PresentDelegate(IntPtr thisPtr, uint syncInterval, DXGIPresentFlags flags = 0);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetBufferDelegate(IntPtr thisPtr, uint buffer, in Guid riid, out IntPtr surfacePtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetFullscreenStateDelegate(IntPtr thisPtr,
            [MarshalAs(UnmanagedType.Bool)] bool fullscreenState, IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFullscreenStateDelegate(IntPtr thisPtr, out bool fullscreenState, out IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGISwapChainDescription desc);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ResizeBuffersDelegate(IntPtr thisPtr, uint bufferCount, uint width, uint height,
            DXGIFormat newFormat, DXGISwapChainFlag flags);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ResizeTargetDelegate(IntPtr thisPtr, in DXGIModeDescription newTargetParameters);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetContainingOutputDelegate(IntPtr thisPtr, out IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFrameStatisticsDelegate(IntPtr thisPtr, out DXGIFrameStatistics frameStatistics);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 10u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetLastPresentCountDelegate(IntPtr thisPtr, out uint countPresent);
    }
}