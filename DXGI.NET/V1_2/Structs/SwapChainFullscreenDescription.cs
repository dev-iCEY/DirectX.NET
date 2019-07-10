using System.Runtime.InteropServices;

namespace DXGI.NET.V1_2
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SwapChainFullscreenDescription
    {
        public Rational RefreshRate { get; set; }
        public ModeScanlineOrder ScanlineOrdering { get; set; }
        public ModeScaling Scaling { get; set; }
        [field:MarshalAs(UnmanagedType.Bool)]
        public bool Windowed { get; set; }
    }
}