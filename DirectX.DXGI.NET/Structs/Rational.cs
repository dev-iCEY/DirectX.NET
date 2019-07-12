#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rational
    {
        public uint Numerator{ get; set; }
        public uint Denominator{ get; set; }
    }
}
