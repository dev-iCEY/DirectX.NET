#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="DXGIOutDuplPointerShapeInfo" /> structure describes information about the cursor shape.
    ///     <para>
    ///         For more info, please follow this
    ///         <seealso
    ///             href="https://docs.microsoft.com/en-us/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_pointer_shape_info">
    ///             link
    ///         </seealso>
    ///         , and read remarks.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     An application draws the cursor shape with the top-left-hand corner drawn at the position that the Position member
    ///     of the <seealso cref="DXGIOutDuplPointerPosition" /> structure specifies; the application does not use the hot spot
    ///     to draw the
    ///     cursor shape.
    ///     An application calls the <seealso cref="IDXGIOutputDuplication.GetFramePointerShape" /> method to retrieve cursor
    ///     shape information
    ///     in a <seealso cref="DXGIOutDuplPointerShapeInfo" /> structure.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGIOutDuplPointerShapeInfo
    {
        /// <summary>
        ///     A <seealso cref="DXGIOutDuplPointerShapeType" />-typed value that specifies the type of cursor shape.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        public DXGIOutDuplPointerShapeType Type { get; set; }

        /// <summary>
        ///     The width in pixels of the mouse cursor.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public uint Width { get; set; }

        /// <summary>
        ///     The height in scan lines of the mouse cursor.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public uint Height { get; set; }

        /// <summary>
        ///     The width in bytes of the mouse cursor.
        /// </summary>
        /// <value>
        ///     The pitch.
        /// </value>
        public uint Pitch { get; set; }

        /// <summary>
        ///     The position of the cursor's hot spot relative to its upper-left pixel. An application does not use the hot spot
        ///     when it determines where to draw the cursor shape.
        /// </summary>
        /// <value>
        ///     The hot spot.
        /// </value>
        public Point HotSpot { get; set; }
    }
}