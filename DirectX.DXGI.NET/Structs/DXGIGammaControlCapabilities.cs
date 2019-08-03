#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Controls the gamma capabilities of an adapter.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIGammaControlCapabilities
    {
        /// <summary>
        ///     True if scaling and offset operations are supported during gamma correction; otherwise, false.
        /// </summary>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool ScaleAndOffsetSupported { get; set; }

        /// <summary>
        ///     A value describing the maximum range of the control-point positions.
        /// </summary>
        public float MaxConvertedValue { get; set; }

        /// <summary>
        ///     A value describing the minimum range of the control-point positions.
        /// </summary>
        public float MinConvertedValue { get; set; }

        /// <summary>
        ///     A value describing the number of control points in the array.
        /// </summary>
        public uint NumGammaControlPoints { get; set; }

        /// <summary>
        ///     An array of values describing control points; the maximum length of control points is 1025.
        /// </summary>
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public float[] ControlPointPositions { get; set; }
    }
}