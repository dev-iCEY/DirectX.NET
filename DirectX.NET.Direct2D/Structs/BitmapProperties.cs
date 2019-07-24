#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes the pixel format and dpi of a bitmap.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public ref struct BitmapProperties
    {
        public PixelFormat PixelFormat { get; set; }
        public float DpiX { get; set; }
        public float DpiY { get; set; }
    }
}