using System.Runtime.InteropServices;

namespace DXGI.NET.V1_2
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SwapChainDescription1
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
        public Format Format { get; set; }
        [field:MarshalAs(UnmanagedType.Bool)]
        public bool Stereo { get; set; }
        public SampleDescription SampleDescription { get; set; }
        public Usage BufferUsage { get; set; }
        public uint BufferCount { get; set; }
        public Scaling Scaling { get; set; }
        public SwapEffect SwapEffect { get; set; }
        public AlphaMode AlphaMode { get; set; }
        public SwapChainFlag Flags { get; set; }
    }
}