#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}