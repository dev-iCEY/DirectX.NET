#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIJpegDcHuffmanTable
    {
        /// <summary>
        ///     The code counts
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public readonly byte[] CodeCounts;

        /// <summary>
        ///     The code values
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public readonly byte[] CodeValues;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIJpegDcHuffmanTable" /> struct.
        /// </summary>
        /// <param name="codeCounts">The code counts.</param>
        /// <param name="codeValues">The code values.</param>
        public DXGIJpegDcHuffmanTable(byte[] codeCounts, byte[] codeValues)
        {
            CodeCounts = codeCounts;
            CodeValues = codeValues;
        }
    }
}