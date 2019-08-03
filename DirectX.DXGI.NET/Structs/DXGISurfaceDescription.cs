#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes a surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGISurfaceDescription
    {
        /// <summary>
        ///     A value describing the surface width.
        /// </summary>
        public uint Width { get; set; }

        /// <summary>
        ///     A value describing the surface height.
        /// </summary>
        public uint Height { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="Format" /> enumerated type that describes the surface format.
        /// </summary>
        public DXGIFormat Format { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGISampleDescription" /> structure that describes multi-sampling parameters for the
        ///     surface.
        /// </summary>
        public DXGISampleDescription SampleDesc { get; set; }
    }
}