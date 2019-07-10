using System.Runtime.InteropServices;

namespace DXGI.NET.Duplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDuplicationPointerShapeInfo
    {
        public uint Type { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public uint Pitch { get; set; }
        public Point HotSpot { get; set; }
    }
}