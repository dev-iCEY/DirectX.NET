#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JpegDcHuffmanTable
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public readonly byte[] CodeCounts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public readonly byte[] CodeValues;

        public JpegDcHuffmanTable(byte[] codeCounts, byte[] codeValues)
        {
            CodeCounts = codeCounts;
            CodeValues = codeValues;
        }
    }
}