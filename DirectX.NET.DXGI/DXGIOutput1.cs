#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An <see cref="IDXGIOutput1" /> interface represents an adapter output (such as a monitor).
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIOutput" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIOutput1" />
    public class DXGIOutput1 : DXGIOutput, IDXGIOutput1
    {
        /// <summary>
        /// The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIOutput.LastMethodId + 4u;

        /// <summary>
        /// The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIOutput1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIOutput" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIOutput1(IntPtr objectPtr) :
            base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

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
        public int GetDisplayModeList1(DXGIFormat enumFormat, DXGIEnumModes flags, ref uint numModes,
            DXGIModeDescription1[] modesDesc = null)
        {
            return GetMethodDelegate<DXGIGetDisplayModeList1Delegate>()
                .Invoke(this, enumFormat, flags, ref numModes, modesDesc);
        }

        /// <summary>
        ///     Finds the closest matching mode1.
        /// </summary>
        /// <param name="modeMatch">The mode match.</param>
        /// <param name="closestMatch">The closest match.</param>
        /// <param name="concernedDevice">The concerned device.</param>
        /// <returns></returns>
        public int FindClosestMatchingMode1(in DXGIModeDescription1 modeMatch, out DXGIModeDescription1 closestMatch,
            IUnknown concernedDevice)
        {
            return GetMethodDelegate<DXGIFindClosestMatchingMode1Delegate>()
                .Invoke(this, modeMatch, out closestMatch, (Unknown) concernedDevice ?? IntPtr.Zero);
        }

        /// <summary>
        ///     Copies the display surface (front buffer) to a user-provided resource.
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <returns></returns>
        public int GetDisplaySurfaceData1(IDXGISurface destination)
        {
            return GetMethodDelegate<DXGIGetDisplaySurfaceData1Delegate>().Invoke(this, (DXGISurface) destination);
        }

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
        public int DuplicateOutput(IUnknown device, out IDXGIOutputDuplication duplication)
        {
            int result = GetMethodDelegate<DXGIDuplicateOutputDelegate>()
                .Invoke(this, (Unknown) device, out IntPtr duplicationPtr);

            duplication = result == 0 ? new DXGIOutputDuplication(duplicationPtr) : null;

            return result;
        }

        [ComMethodId(DXGIOutput.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetDisplayModeList1Delegate(IntPtr thisPtr, DXGIFormat enumFormat, DXGIEnumModes flags,
            ref uint modes, [MarshalAs(UnmanagedType.LPArray)] DXGIModeDescription1[] modesDesc);

        [ComMethodId(DXGIOutput.LastMethodId + 2u),
         UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
        private delegate int DXGIFindClosestMatchingMode1Delegate(IntPtr thisPtr, in DXGIModeDescription1 modeMatch,
            out DXGIModeDescription1 closestMatch, IntPtr concernedDevice);

        [ComMethodId(DXGIOutput.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetDisplaySurfaceData1Delegate(IntPtr thisPtr, IntPtr destinationPtr);

        [ComMethodId(DXGIOutput.LastMethodId + 4u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIDuplicateOutputDelegate(IntPtr thisPtr, IntPtr devicePtr, out IntPtr duplicationPtr);
    }
}