#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JpegQuantizationTable
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public readonly byte[] Elements;

        public JpegQuantizationTable(byte[] elements)
        {
            Elements = elements;
        }
    }
}