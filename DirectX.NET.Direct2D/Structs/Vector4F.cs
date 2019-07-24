#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4F
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }
    }
}