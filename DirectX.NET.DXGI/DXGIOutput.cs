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
    /// </summary>
    /// <seealso cref="DXGIObject" />
    /// <seealso cref="IDXGIOutput" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIOutput : DXGIObject, IDXGIOutput
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 12u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIOutput).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIOutput" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIOutput(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount,ref MethodsCount);
        }

        /// <summary>
        ///     Get a description of the output.
        /// </summary>
        /// <param name="desc">A out object the output description (see <seealso cref="DXGIOutputDescription" />)</param>
        /// <returns></returns>
        public int GetDesc(out DXGIOutputDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        /// <summary>
        ///     Gets the display modes that match the requested format and other input options.
        /// </summary>
        /// <param name="format">The color format (see <seealso cref="DXGIFormat" />).</param>
        /// <param name="flags">
        ///     Options for modes to include (see <seealso cref="DXGIEnumModes" />). <seealso cref="DXGIEnumModes.Scaling" /> needs
        ///     to be specified
        ///     to expose the display modes that require scaling. Centered modes, requiring no scaling and corresponding directly
        ///     to the display output, are enumerated by default.
        /// </param>
        /// <param name="numModes">
        ///     Set <paramref name="modesDesc" /> to <seealso langword="null" /> so that <paramref name="numModes" />
        ///     returns the number of display modes that match the format and the options.
        ///     Otherwise, <paramref name="modesDesc" /> returns the number of display modes returned in
        ///     <paramref name="modesDesc" />.
        /// </param>
        /// <param name="modesDesc">
        ///     A pointer to a list of display modes (see <seealso cref="DXGIModeDescription" />); set to
        ///     <seealso langword="null" /> to get the number of display modes.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     In general, when switching from windowed to full-screen mode, a swap chain automatically chooses a display mode
        ///     that meets (or exceeds) the resolution, color depth and refresh rate of the swap chain. To exercise more control
        ///     over the display mode, use this API to poll the set of display modes that are validated against monitor
        ///     capabilities, or all modes that match the desktop (if the desktop settings are not validated against the monitor).
        ///     As shown, this API is designed to be called twice. First to get the number of modes available, and second to return
        ///     a description of the modes.
        /// </remarks>
        public int GetDisplayModeList
        (
            DXGIFormat format,
            DXGIEnumModes flags,
            ref uint numModes,
            [In, Out] DXGIModeDescription[] modesDesc = null
        )
        {
            return GetMethodDelegate<GetDisplayModeListDelegate>()
                .Invoke(this, format, flags, ref numModes, modesDesc);
        }

        /// <summary>
        ///     Finds the closest matching mode.
        /// </summary>
        /// <param name="modeMatch">The mode match.</param>
        /// <param name="closestMatch">The closest match.</param>
        /// <param name="device">The device.</param>
        /// <returns></returns>
        public int FindClosestMatchingMode(in DXGIModeDescription modeMatch, out DXGIModeDescription closestMatch,
            IUnknown device)
        {
            return GetMethodDelegate<FindClosestMatchingModeDelegate>()
                .Invoke(this, in modeMatch, out closestMatch, (Unknown) device);
        }

        /// <summary>
        ///     Halt a thread until the next vertical blank occurs.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     A vertical blank occurs when the raster moves from the lower right corner to the upper left corner to begin
        ///     drawing the next frame.
        /// </remarks>
        public int WaitForVBlank()
        {
            return GetMethodDelegate<WaitForVBlankDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Take ownership of an output.
        /// </summary>
        /// <param name="device">Object to the <seealso cref="IUnknown" /> interface of a device (such as an ID3D10Device).</param>
        /// <param name="isExclusive">
        ///     Set to <seealso langword="true" /> to enable other threads or applications to take ownership
        ///     of the device; otherwise set to <seealso langword="false" />.
        /// </param>
        /// <returns></returns>
        public int TakeOwnership(IUnknown device, bool isExclusive)
        {
            return GetMethodDelegate<TakeOwnershipDelegate>().Invoke(this, (Unknown) device, isExclusive);
        }

        /// <summary>
        ///     Release ownership of the output.
        /// </summary>
        public void ReleaseOwnership()
        {
            GetMethodDelegate<ReleaseOwnershipDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Get a description of the gamma-control capabilities.
        /// </summary>
        /// <param name="gammaControlCapabilities">
        ///     A description of the gamma-control capabilities (see
        ///     <seealso cref="DXGIGammaControlCapabilities" />).
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     <note>NOTE</note> Calling this method is only supported while in full-screen mode.
        /// </remarks>
        public int GetGammaControlCapabilities(out DXGIGammaControlCapabilities gammaControlCapabilities)
        {
            return GetMethodDelegate<GetGammaControlCapabilitiesDelegate>().Invoke(this, out gammaControlCapabilities);
        }

        /// <summary>
        ///     Set the gamma controls.
        /// </summary>
        /// <param name="gammaControl">A array of gamma controls (see <seealso cref="DXGIGammaControl" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     Calling this method is only supported while in full-screen mode.
        /// </remarks>
        public int SetGammaControl(in DXGIGammaControl[] gammaControl)
        {
            return GetMethodDelegate<SetGammaControlDelegate>().Invoke(this, in gammaControl);
        }

        /// <summary>
        ///     Get the gamma control settings.
        /// </summary>
        /// <param name="gammaControl">An array of gamma control settings (see <seealso cref="DXGIGammaControl" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     Calling this method is only supported while in full-screen mode.
        /// </remarks>
        public int GetGammaControl(out DXGIGammaControl[] gammaControl)
        {
            return GetMethodDelegate<GetGammaControlDelegate>().Invoke(this, out gammaControl);
        }

        /// <summary>
        ///     Change the display mode.
        /// </summary>
        /// <param name="surface">
        ///     A object to a surface (see <seealso cref="IDXGISurface" />) used for rendering an image to the
        ///     screen. The surface must have been created with as a back buffer (<seealso cref="DXGIUsage.BackBuffer" />).
        /// </param>
        /// <returns></returns>
        public int SetDisplaySurface(IDXGISurface surface)
        {
            return GetMethodDelegate<SetDisplaySurfaceDelegate>().Invoke(this, (DXGISurface) surface);
        }

        /// <summary>
        ///     Get a copy of the current display surface.
        /// </summary>
        /// <param name="surface">A object to a destination surface (see <seealso cref="IDXGISurface" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     <seealso cref="IDXGIOutput.GetDisplaySurfaceData" /> can only be called when an output is in full-screen mode.
        ///     If the method succeeds, the destination surface will be filled.
        ///     Use <seealso cref="IDXGISurface.GetDesc" /> to find out the size (width and height) when allocating space for the
        ///     destination
        ///     surface. This is true regardless of target monitor rotation. A destination surface created by a graphics component
        ///     (such as Direct3D 10) must be created with CPU-write permission (see D3D10_CPU_ACCESS_WRITE). Other surfaces should
        ///     be created with CPU read-write permission (see D3D10_CPU_ACCESS_READ_WRITE). This method will modify the surface
        ///     data to fit the destination surface (stretch, shrink, convert format, rotate). The stretch and shrink is performed
        ///     with point-sampling.
        /// </remarks>
        public int GetDisplaySurfaceData(IDXGISurface surface)
        {
            return GetMethodDelegate<GetDisplaySurfaceDataDelegate>().Invoke(this, (DXGISurface) surface);
        }

        /// <summary>
        ///     Get statistics about recently rendered frames.
        /// </summary>
        /// <param name="frameStatistics">A out struct to a frame statictics (see <seealso cref="DXGIFrameStatistics" />).</param>
        /// <returns></returns>
        /// <remarks>
        ///     This API is similar to <seealso cref="IDXGISwapChain.GetFrameStatistics" />.
        ///     <para>
        ///         Calling this method is only supported while in full-screen mode.
        ///     </para>
        /// </remarks>
        public int GetFrameStatistics(out DXGIFrameStatistics frameStatistics)
        {
            return GetMethodDelegate<GetFrameStatisticsDelegate>().Invoke(this, out frameStatistics);
        }

        [ComMethodId(DXGIObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGIOutputDescription description);

        [ComMethodId(DXGIObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplayModeListDelegate
        (
            IntPtr thisPtr,
            DXGIFormat format,
            DXGIEnumModes flags,
            ref uint numModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray)]
            DXGIModeDescription[] modesDesc = null
        );

        [ComMethodId(DXGIObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int FindClosestMatchingModeDelegate
        (
            IntPtr thisPtr,
            in DXGIModeDescription modeMatch,
            out DXGIModeDescription closestMatch,
            IntPtr concernedDevicePtr
        );

        [ComMethodId(DXGIObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int WaitForVBlankDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIObject.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TakeOwnershipDelegate(IntPtr thisPtr, IntPtr device,
            [MarshalAs(UnmanagedType.Bool)] bool isExclusive);

        [ComMethodId(DXGIObject.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseOwnershipDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIObject.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlCapabilitiesDelegate(IntPtr thisPtr,
            out DXGIGammaControlCapabilities gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetGammaControlDelegate(IntPtr thisPtr,
            [MarshalAs(UnmanagedType.LPArray)] in DXGIGammaControl[] gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlDelegate(IntPtr thisPtr, out DXGIGammaControl[] gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 10u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetDisplaySurfaceDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(DXGIObject.LastMethodId + 11u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplaySurfaceDataDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(DXGIObject.LastMethodId + 12u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFrameStatisticsDelegate(IntPtr thisPtr, out DXGIFrameStatistics frameStatistics);
    }
}