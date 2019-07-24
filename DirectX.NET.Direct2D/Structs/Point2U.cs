#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point2U
    {
        public uint X { get; set; }
        public uint Y { get; set; }
    }
}