#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3F
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}