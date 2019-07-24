#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes a cubic bezier in a path.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BezierSegment
    {
        public Point2F Point1;
        public Point2F Point2;
        public Point2F Point3;
    }
}