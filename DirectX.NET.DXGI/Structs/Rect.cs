#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Rectangle
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        /// <summary>
        ///     Gets or sets the left.
        /// </summary>
        /// <value>
        ///     The left.
        /// </value>
        public int Left { get; set; }

        /// <summary>
        ///     Gets or sets the top.
        /// </summary>
        /// <value>
        ///     The top.
        /// </value>
        public int Top { get; set; }

        /// <summary>
        ///     Gets or sets the right.
        /// </summary>
        /// <value>
        ///     The right.
        /// </value>
        public int Right { get; set; }

        /// <summary>
        ///     Gets or sets the bottom.
        /// </summary>
        /// <value>
        ///     The bottom.
        /// </value>
        public int Bottom { get; set; }
    }
}