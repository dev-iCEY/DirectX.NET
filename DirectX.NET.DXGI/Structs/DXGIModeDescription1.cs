#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes a display mode and whether the display mode supports stereo.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGIModeDescription1
    {
        /// <summary>
        /// A value that describes the resolution width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public uint Width { get; set; }

        /// <summary>
        /// A value that describes the resolution height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public uint Height { get; set; }

        /// <summary>
        /// A <see cref="DXGIRational"/> structure that describes the refresh rate in hertz.
        /// </summary>
        /// <value>
        /// The refresh rate.
        /// </value>
        public DXGIRational RefreshRate { get; set; }

        /// <summary>
        /// A <see cref="DXGIFormat"/>-typed value that describes the display format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public DXGIFormat Format { get; set; }

        /// <summary>
        /// A <see cref="DXGIModeScanlineOrder"/>-typed value that describes the scan-line drawing mode.
        /// </summary>
        /// <value>
        /// The scanline ordering.
        /// </value>
        public DXGIModeScanlineOrder ScanlineOrdering { get; set; }

        /// <summary>
        /// A <see cref="DXGIModeScaling"/>-typed value that describes the scaling mode.
        /// </summary>
        /// <value>
        /// The scaling.
        /// </value>
        public DXGIModeScaling Scaling { get; set; }

        /// <summary>
        /// Specifies whether the full-screen display mode is stereo. <see langword="true"/> if stereo; otherwise, <see langword="false"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stereo; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Stereo { get; set; }
    }
}