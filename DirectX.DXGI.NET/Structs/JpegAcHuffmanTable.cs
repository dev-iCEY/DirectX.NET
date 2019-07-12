#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JpegAcHuffmanTable
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public readonly byte[] CodeCounts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 162)]
        public readonly byte[] CodeValues;

        public JpegAcHuffmanTable(byte[] codeCounts, byte[] codeValues)
        {
            CodeCounts = codeCounts;
            CodeValues = codeValues;
        }
    }
}