#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SizeU
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
    }
}