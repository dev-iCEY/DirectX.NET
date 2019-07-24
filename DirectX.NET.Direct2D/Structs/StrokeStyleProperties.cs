#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Properties, aside from the width, that allow geometric penning to be specified.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StrokeStyleProperties
    {
        public CapStyle StartCap;
        public CapStyle EndCap;
        public CapStyle DashCap;
        public LineJoin LineJoin;
        public float MiterLimit;
        public DashStyle DashStyle;
        public float DashOffset;
    }
}