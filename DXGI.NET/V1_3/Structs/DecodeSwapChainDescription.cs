using System.Runtime.InteropServices;

namespace DXGI.NET.V1_3
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DecodeSwapChainDescription
    {
        public uint Flags { get; set; }
    }
}