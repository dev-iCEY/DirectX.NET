#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes an output or physical connection between the adapter (video card) and a device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode),
     SuppressMessage("ReSharper", "InconsistentNaming"),
     SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public readonly ref struct DXGIOutputDescription
    {
        /// <summary>
        ///     A string that contains the name of the output device.
        /// </summary>
        [field: MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName { get; }

        /// <summary>
        ///     A <seealso cref="Rect" /> structure containing the bounds of the output in desktop coordinates.
        /// </summary>
        public Rect DesktopCoordinates { get; }

        /// <summary>
        ///     True if the output is attached to the desktop; otherwise, false.
        /// </summary>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool AttachedToDesktop { get; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeRotation" /> enumerated type describing on how an image is rotated by the
        ///     output.
        /// </summary>
        public DXGIModeRotation Rotation { get; }

        /// <summary>
        ///     An HMONITOR handle that represents the display monitor. For more information, see HMONITOR and the Device Context.
        /// </summary>
        public IntPtr Monitor { get; }
    }
}