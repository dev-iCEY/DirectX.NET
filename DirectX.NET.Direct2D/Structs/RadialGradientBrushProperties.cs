#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the gradient origin offset and the size and position of the gradient ellipse for an
    ///     <see cref="IRadialGradientBrush" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RadialGradientBrushProperties
    {
        public Point2F Center { get; set; }
        public Point2F GradientOriginOffset { get; set; }
        public float RadiusX { get; set; }
        public float RadiusY { get; set; }
    }
}