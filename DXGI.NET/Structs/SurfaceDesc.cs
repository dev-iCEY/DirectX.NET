#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SurfaceDesc
    {
        public uint Width;
        public uint Height;
        public Format Format;
        public SampleDesc SampleDesc;

        public SurfaceDesc(uint width, uint height, Format format, SampleDesc sampleDesc)
        {
            Width = width;
            Height = height;
            Format = format;
            SampleDesc = sampleDesc;
        }
    }
}