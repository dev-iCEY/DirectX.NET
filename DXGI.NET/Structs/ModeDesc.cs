#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ModeDesc
    {
        public uint Width;
        public uint Height;
        public Rational RefreshRate;
        public Format Format;
        public ModeScanlineOrder ScanlineOrdering;
        public ModeScaling Scaling;

        public ModeDesc(uint width, uint height, Rational refreshRate, Format format,
            ModeScanlineOrder scanlineOrdering, ModeScaling scaling)
        {
            Width = width;
            Height = height;
            RefreshRate = refreshRate;
            Format = format;
            ScanlineOrdering = scanlineOrdering;
            Scaling = scaling;
        }
    }
}