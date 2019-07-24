using System.Runtime.InteropServices;

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SizeF
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }
}