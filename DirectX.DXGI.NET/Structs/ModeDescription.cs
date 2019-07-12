#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ModeDescription
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
        public Rational RefreshRate { get; set; }
        public Format Format { get; set; }
        public ModeScanlineOrder ScanlineOrdering { get; set; }
        public ModeScaling Scaling { get; set; }
    }
}