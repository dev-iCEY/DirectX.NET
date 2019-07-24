#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes the extend modes and the interpolation mode of an <see cref="IBitmapBrush" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BitmapBrushProperties
    {
        public ExtendMode ExtendModeX { get; set; }
        public ExtendMode ExtendModeY { get; set; }
        public BitmapInterpolationMode InterpolationMode { get; set; }
    }
}