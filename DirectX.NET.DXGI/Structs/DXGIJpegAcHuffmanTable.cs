#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// ???
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIJpegAcHuffmanTable
    {
        /// <summary>
        ///     The code counts
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public readonly byte[] CodeCounts;

        /// <summary>
        ///     The code values/
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 162)]
        public readonly byte[] CodeValues;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIJpegAcHuffmanTable" /> struct.
        /// </summary>
        /// <param name="codeCounts">The code counts.</param>
        /// <param name="codeValues">The code values.</param>
        public DXGIJpegAcHuffmanTable(byte[] codeCounts, byte[] codeValues)
        {
            CodeCounts = codeCounts;
            CodeValues = codeValues;
        }
    }
}