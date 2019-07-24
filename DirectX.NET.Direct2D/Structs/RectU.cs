#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RectU
    {
        public uint Left { get; set; }
        public uint Top { get; set; }
        public uint Right { get; set; }
        public uint Bottom { get; set; }
    }
}