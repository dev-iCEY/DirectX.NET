#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SurfaceDescription
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
        public Format Format { get; set; }
        public SampleDescription SampleDesc { get; set; }
    }
}