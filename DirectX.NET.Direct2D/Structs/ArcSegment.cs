#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes an arc that is defined as part of a path.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ArcSegment
    {
        public Point2F Point;
        public SizeF Size;
        public float AngleRotation;
        public SweepDirection SweepDirection;
        public ArcSize ArcSize;
    }
}