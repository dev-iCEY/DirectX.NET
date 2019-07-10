#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Duplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDuplicationPointerPosition
    {
        public Point Position { get; set; }

        [field: MarshalAs(UnmanagedType.Bool)] public bool Visible { get; set; }

        public OutputDuplicationPointerPosition(Point position, bool visible)
        {
            Position = position;
            Visible = visible;
        }
    }
}