#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GammaControl
    {
        public Rgb Scale;
        public Rgb Offset;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public Rgb[] GammaCurve;

        public GammaControl(Rgb scale, Rgb offset, Rgb[] gammaCurve)
        {
            Scale = scale;
            Offset = offset;
            GammaCurve = gammaCurve;
        }
    }
}