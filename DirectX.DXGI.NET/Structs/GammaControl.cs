#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GammaControl
    {
        public Rgb Scale { get; set; }
        public Rgb Offset{ get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public Rgb[] GammaCurve{ get; set; }
    }
}