#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIOutput" /> interface represents an adapter output (such as a monitor).
    /// </summary>
    /// <seealso cref="IDXGIObject" />
    /// <remarks>
    ///     To see the outputs available, use <seealso cref="IDXGIAdapter.EnumOutputs" />.
    ///     To see the specific output that the swap chain will update, use
    ///     <seealso cref="IDXGISwapChain.GetContainingOutput" />.
    /// </remarks>
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIOutput : IDXGIObject
    {
        /// <summary>
        ///     Get a description of the output.
        /// </summary>
        /// <param name="desc">
        ///     A out object the output description (see <seealso cref="DXGIOutputDescription" />)
        /// </param>
        int GetDesc(out DXGIOutputDescription desc);

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
        int GetDisplayModeList
        (
            DXGIFormat format,
            DXGIEnumModes flags,
            ref uint numModes,
            [In, Out, Optional] DXGIModeDescription[] modesDesc
        );

        /// <summary>
        ///     Finds the closest matching mode.
        /// </summary>
        /// <param name="modeMatch">The mode match.</param>
        /// <param name="closestMatch">The closest match.</param>
        /// <param name="device">The device.</param>
        /// <returns></returns>
        int FindClosestMatchingMode
        (
            in DXGIModeDescription modeMatch,
            out DXGIModeDescription closestMatch,
            IUnknown device
        );

        /// <summary>
        ///     Halt a thread until the next vertical blank occurs.
        /// </summary>
        /// <remarks>
        ///     A vertical blank occurs when the raster moves from the lower right corner to the upper left corner to begin
        ///     drawing the next frame.
        /// </remarks>
        int WaitForVBlank();

        /// <summary>
        ///     Take ownership of an output.
        /// </summary>
        /// <param name="device">Object to the <seealso cref="IUnknown" /> interface of a device (such as an ID3D10Device).</param>
        /// <param name="isExclusive">
        ///     Set to <seealso langword="true" /> to enable other threads or applications to take ownership
        ///     of the device; otherwise set to <seealso langword="false" />.
        /// </param>
        int TakeOwnership(IUnknown device, bool isExclusive);

        /// <summary>
        ///     Release ownership of the output.
        /// </summary>
        void ReleaseOwnership();

        /// <summary>
        ///     Get a description of the gamma-control capabilities.
        /// </summary>
        /// <param name="gammaControlCapabilities">
        ///     A description of the gamma-control capabilities (see
        ///     <seealso cref="DXGIGammaControlCapabilities" />).
        /// </param>
        /// <returns></returns>
        /// <remarks><note>NOTE</note> Calling this method is only supported while in full-screen mode.</remarks>
        int GetGammaControlCapabilities(out DXGIGammaControlCapabilities gammaControlCapabilities);

        /// <summary>
        ///     Set the gamma controls.
        /// </summary>
        /// <param name="gammaControl">A array of gamma controls (see <seealso cref="DXGIGammaControl" />).</param>
        /// <returns></returns>
        /// <remarks>Calling this method is only supported while in full-screen mode.</remarks>
        int SetGammaControl([MarshalAs(UnmanagedType.LPArray)] in DXGIGammaControl[] gammaControl);

        /// <summary>
        ///     Get the gamma control settings.
        /// </summary>
        /// <param name="gammaControl">An array of gamma control settings (see <seealso cref="DXGIGammaControl" />).</param>
        /// <returns></returns>
        /// <remarks>Calling this method is only supported while in full-screen mode.</remarks>
        int GetGammaControl(out DXGIGammaControl[] gammaControl);

        /// <summary>
        ///     Change the display mode.
        /// </summary>
        /// <param name="surface">
        ///     A object to a surface (see <seealso cref="IDXGISurface" />) used for rendering an image to the
        ///     screen. The surface must have been created with as a back buffer (<seealso cref="DXGIUsage.BackBuffer" />).
        /// </param>
        /// <returns></returns>
        int SetDisplaySurface(IDXGISurface surface);

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
        int GetDisplaySurfaceData(IDXGISurface surface);

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
        int GetFrameStatistics(out DXGIFrameStatistics frameStatistics);
    }
}