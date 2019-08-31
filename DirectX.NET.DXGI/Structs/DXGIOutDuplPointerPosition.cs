#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="DXGIOutDuplPointerPosition" /> structure describes the position of the hardware cursor.
    /// </summary>
    /// <remarks>
    ///     The <seealso cref="Position" /> member is valid only if the <seealso cref="Visible" /> member’s value is set
    ///     to TRUE.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIOutDuplPointerPosition
    {
        /// <summary>
        ///     The position of the hardware cursor relative to the top-left of the adapter output.
        /// </summary>
        /// <value>
        ///     The position.
        /// </value>
        public Point Position { get; set; }

        /// <summary>
        ///     Specifies whether the hardware cursor is visible. <seealso langword="true" /> if visible;
        ///     otherwise, <seealso langword="false" />.
        ///     If the hardware cursor is not visible, the calling application does not display the cursor in the client.
        /// </summary>
        /// <value>
        ///     <c>true</c> if visible; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Visible { get; set; }
    }
}