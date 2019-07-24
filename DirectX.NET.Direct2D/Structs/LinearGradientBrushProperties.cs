#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the starting point and endpoint of the gradient axis for an <see cref="ILinearGradientBrush" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public ref struct LinearGradientBrushProperties
    {
        public Point2F StartPoint { get; set; }
        public Point2F EndPoint { get; set; }
    }
}