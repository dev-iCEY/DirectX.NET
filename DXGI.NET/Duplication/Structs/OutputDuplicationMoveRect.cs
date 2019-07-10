#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Duplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDuplicationMoveRect
    {
        public Point SourcePoint { get; set; }
        public Rect DestinationRect { get; set; }

        public OutputDuplicationMoveRect(Point sourcePoint, Rect destinationRect)
        {
            SourcePoint = sourcePoint;
            DestinationRect = destinationRect;
        }
    }
}