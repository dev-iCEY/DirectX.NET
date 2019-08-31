#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     An <see cref="IDXGIOutput1" /> interface represents an adapter output (such as a monitor).
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIOutput" />
    [Guid("00cddea8-939b-4b83-a340-a685226666cc"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIOutput1 : IDXGIOutput
    {
        /// <summary>
        ///     Gets the display modes that match the requested format and other input options.
        /// </summary>
        /// <param name="enumFormat">The color format (see <seealso cref="DXGIFormat" />).</param>
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
        ///     A pointer to a list of display modes (see <seealso cref="DXGIModeDescription1" />); set to
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
        /// <returns></returns>
        int GetDisplayModeList1
        (
            DXGIFormat enumFormat,
            DXGIEnumModes flags,
            ref uint numModes,
            [In, Out, Optional] DXGIModeDescription1[] modesDesc
        );

        /// <summary>
        ///     Finds the closest matching mode1.
        /// </summary>
        /// <param name="modeMatch">The mode match.</param>
        /// <param name="closestMatch">The closest match.</param>
        /// <param name="concernedDevice">The concerned device.</param>
        /// <returns></returns>
        int FindClosestMatchingMode1
        (
            in DXGIModeDescription1 modeMatch,
            out DXGIModeDescription1 closestMatch,
            IUnknown concernedDevice
        );

        /// <summary>
        ///     Copies the display surface (front buffer) to a user-provided resource.
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <returns></returns>
        int GetDisplaySurfaceData1(IDXGISurface destination);

        /// <summary>
        ///     Creates a desktop duplication interface from the <see cref="IDXGIOutput1" /> interface that represents an adapter
        ///     output.
        /// </summary>
        /// <param name="device">
        ///     A interface to the Direct3D device interface that you can use to process the desktop image. This
        ///     device must be created from the adapter to which the output is connected.
        /// </param>
        /// <param name="duplication">A out variable that receives the new <see cref="IDXGIOutputDuplication" /> interface.</param>
        /// <returns></returns>
        int DuplicateOutput
        (
            IUnknown device,
            out IDXGIOutputDuplication duplication
        );
    }
}