#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RectF
    {
        public float Left { get; set; }
        public float Top { get; set; }
        public float Right { get; set; }
        public float Bottom { get; set; }
    }
}