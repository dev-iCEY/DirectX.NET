#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes multi-sampling parameters for a resource.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGISampleDescription
    {
        /// <summary>
        ///     The number of multisamples per pixel.
        /// </summary>
        public uint Count { get; set; }

        /// <summary>
        ///     The image quality level. The higher the quality, the lower the performance.
        /// </summary>
        public uint Quality { get; set; }
    }
}