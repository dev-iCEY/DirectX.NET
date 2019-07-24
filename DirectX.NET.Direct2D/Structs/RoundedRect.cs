#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the dimensions and corner radii of a rounded rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RoundedRect
    {
        public RectF Rect;
        public float RadiusX;
        public float RadiusY;
    }
}