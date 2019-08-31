#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="DXGIOutDuplMoveRect" /> structure describes the movement of a rectangle.
    /// </summary>
    /// <remarks>This structure is used by GetFrameMoveRects.</remarks>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIOutDuplMoveRect
    {
        /// <summary>
        ///     The starting position of a rectangle.
        /// </summary>
        /// <value>
        ///     The source point.
        /// </value>
        public Point SourcePoint { get; set; }

        /// <summary>
        ///     The target region to which to move a rectangle.
        /// </summary>
        /// <value>
        ///     The destination rect.
        /// </value>
        public Rect DestinationRect { get; set; }
    }
}