#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the center point, x-radius, and y-radius of an ellipse.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Ellipse
    {
        public Point2F Point;
        public float RadiusX;
        public float RadiusY;
    }
}