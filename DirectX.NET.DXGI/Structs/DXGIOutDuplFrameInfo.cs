#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="DXGIOutDuplFrameInfo" /> structure describes the current desktop image.
    ///     <para>
    ///         For more info follow the
    ///         <seealso href="https://docs.microsoft.com/en-us/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_frame_info">link</seealso>
    ///         , and see <b>Remarks</b>
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     A non-zero <seealso cref="LastMouseUpdateTime" /> indicates an update to either a mouse pointer position or a mouse
    ///     pointer position
    ///     and shape. That is, the mouse pointer position is always valid for a non-zero
    ///     <seealso cref="LastMouseUpdateTime" />; however, the
    ///     application must check the value of the <seealso cref="PointerShapeBufferSize " /> member to determine whether the
    ///     shape was updated too.
    ///     If only the pointer was updated (that is, the desktop image was not updated), the
    ///     <seealso cref="AccumulatedFrames" />,
    ///     <seealso cref="TotalMetadataBufferSize" />, and <seealso cref="LastPresentTime" /> members are set to zero.
    ///     An <seealso cref="AccumulatedFrames" /> value of one indicates that the application completed processing the last
    ///     frame before a new
    ///     desktop image was presented. If the <seealso cref="AccumulatedFrames" /> value is greater than one, more desktop
    ///     image updates have
    ///     occurred while the application processed the last desktop update. In this situation, the operating system
    ///     accumulated the update regions. For more information about desktop updates, see Desktop Update Data.
    ///     A non-zero <seealso cref="TotalMetadataBufferSize" /> indicates the total size of the buffers that are required to
    ///     store all the
    ///     desktop update metadata. An application cannot determine the size of each type of metadata. The application must
    ///     call the <seealso cref="IDXGIOutputDuplication.GetFrameDirtyRects" />,
    ///     <seealso cref="IDXGIOutputDuplication.GetFrameMoveRects" />, or
    ///     <seealso cref="IDXGIOutputDuplication.GetFramePointerShape" /> method to obtain information about each type of
    ///     metadata.
    /// </remarks>
    [SuppressMessage("ReSharper", "InconsistentNaming"), SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public readonly struct DXGIOutDuplFrameInfo
    {
        /// <summary>
        ///     The time stamp of the last update of the desktop image. The operating system calls the
        ///     <seealso href="https://docs.microsoft.com/en-us/windows/win32/api/profileapi/nf-profileapi-queryperformancecounter">QueryPerformanceCounter</seealso>
        ///     function to obtain the value. A zero value indicates that the desktop image was not updated since an application
        ///     last called the <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" /> method to acquire the next frame of the
        ///     desktop image.
        /// </summary>
        /// <value>
        ///     The last present time.
        /// </value>
        public LargeInteger LastPresentTime { get; }

        /// <summary>
        ///     The time stamp of the last update to the mouse. The operating system calls the
        ///     <b>
        ///         <seealso
        ///             href="https://docs.microsoft.com/en-us/windows/win32/api/profileapi/nf-profileapi-queryperformancecounter">
        ///             QueryPerformanceCounter
        ///         </seealso>
        ///     </b>
        ///     function to
        ///     obtain the value. A zero value indicates that the position or shape of the mouse was not updated since an
        ///     application last called the <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" /> method to acquire the next
        ///     frame of the
        ///     desktop image. The mouse position is always supplied for a mouse update. A new pointer shape is indicated by a
        ///     non-zero value in the
        ///     <b>
        ///         <seealso cref="PointerShapeBufferSize" />
        ///     </b>
        ///     member.
        /// </summary>
        /// <value>
        ///     The last mouse update time.
        /// </value>
        public LargeInteger LastMouseUpdateTime { get; }

        /// <summary>
        ///     The number of frames that the operating system accumulated in the desktop image surface since the calling
        ///     application processed the last desktop image. For more information about this number, <b>see Remarks.</b>
        /// </summary>
        /// <value>
        ///     The accumulated frames.
        /// </value>
        public uint AccumulatedFrames { get; }

        /// <summary>
        ///     Specifies whether the operating system accumulated updates by coalescing dirty regions. Therefore, the dirty
        ///     regions might contain unmodified pixels. <seealso langword="true" />
        ///     if dirty regions were accumulated; otherwise, <seealso langword="false" />.
        /// </summary>
        /// <value>
        ///     <c>true</c> if [rects coalesced]; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool RectsCoalesced { get; }

        /// <summary>
        ///     Specifies whether the desktop image might contain protected content that was already blacked out in the desktop
        ///     image. <seealso langword="true" /> if protected content was already blacked; otherwise,
        ///     <seealso langword="false" />. The application can use this information to
        ///     notify the remote user that some of the desktop content might be protected and therefore not visible.
        /// </summary>
        /// <value>
        ///     <c>true</c> if [protected content masked out]; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool ProtectedContentMaskedOut { get; }

        /// <summary>
        ///     A <seealso cref="DXGIOutDuplPointerPosition" /> structure that describes the most recent mouse position if the
        ///     <seealso cref="LastMouseUpdateTime" /> member is a non-zero value; otherwise, this value is ignored. This value
        ///     provides the coordinates of the location
        ///     where the top-left-hand corner of the pointer shape is drawn; this value is not the desktop position of the hot
        ///     spot.
        /// </summary>
        /// <value>
        ///     The pointer position.
        /// </value>
        public DXGIOutDuplPointerPosition PointerPosition { get; }

        /// <summary>
        ///     Size in bytes of the buffers to store all the desktop update metadata for this frame. For more information about
        ///     this size, see Remarks.
        /// </summary>
        /// <value>
        ///     The total size of the metadata buffer.
        /// </value>
        public uint TotalMetadataBufferSize { get; }

        /// <summary>
        ///     Size in bytes of the buffer to hold the new pixel data for the mouse shape. For more information about this size,
        ///     see Remarks.
        /// </summary>
        /// <value>
        ///     The size of the pointer shape buffer.
        /// </value>
        public uint PointerShapeBufferSize { get; }
    }
}