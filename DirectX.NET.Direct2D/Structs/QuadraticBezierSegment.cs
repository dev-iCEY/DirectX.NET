#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the control point and end point for a quadratic Bezier segment.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct QuadraticBezierSegment
    {
        public Point2F Point1;
        public Point2F Point2;
    }
}