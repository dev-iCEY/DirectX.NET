#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIJpegQuantizationTable
    {
        /// <summary>
        ///     The elements
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public readonly byte[] Elements;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIJpegQuantizationTable" /> struct.
        /// </summary>
        /// <param name="elements">The elements.</param>
        public DXGIJpegQuantizationTable(byte[] elements)
        {
            Elements = elements;
        }
    }
}