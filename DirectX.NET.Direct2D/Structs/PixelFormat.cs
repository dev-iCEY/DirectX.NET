#region Usings

using DirectX.DXGI.NET;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormat
    {
        public Format Format { get; set; }
        public AlphaMode AlphaMode { get; set; }
    }
}