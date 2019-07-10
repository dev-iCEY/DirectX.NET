#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_2
{
    public struct ModeDescription1
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
        public Rational RefreshRate { get; set; }
        public Format Format { get; set; }
        public ModeScanlineOrder ScanlineOrdering { get; set; }
        public ModeScaling Scaling { get; set; }
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Stereo { get; set; }
    }
}