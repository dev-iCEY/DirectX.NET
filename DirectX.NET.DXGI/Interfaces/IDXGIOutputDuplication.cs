#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGIOutputDuplication" /> interface accesses and manipulates the duplicated desktop image.
    /// </summary>
    /// <seealso cref="IDXGIObject" />
    [Guid("191cfac3-a341-470d-b26e-a864f428319c"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIOutputDuplication : IDXGIObject
    {
        /// <summary>
        ///     Retrieves a description of a duplicated output. This description specifies the dimensions of the surface that
        ///     contains the desktop image.
        /// </summary>
        /// <param name="description">The description.</param>
        void GetDesc(out DXGIOutDuplDescription description);

        /// <summary>
        ///     Indicates that the application is ready to process the next desktop image.
        /// </summary>
        /// <param name="timeoutInMilliseconds">
        ///     The time-out interval, in milliseconds. This interval specifies the amount of time that this method waits for a new
        ///     frame before it returns to the caller. This method returns if the interval elapses, and a new desktop image is not
        ///     available.
        ///     For more information about the time-out interval, see Remarks.
        /// </param>
        /// <param name="frameInfo">
        ///     A out variable that receives the <seealso cref="DXGIOutDuplFrameInfo" />
        ///     structure that describes timing and presentation statistics for a frame.
        /// </param>
        /// <param name="desktopResource">
        ///     A out variable that receives the <seealso cref="IDXGIResource" /> interface of
        ///     the surface that contains the desktop bitmap.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     When AcquireNextFrame returns successfully, the calling application can access the desktop image that
        ///     <seealso cref="AcquireNextFrame" /> returns in the variable at <paramref name="desktopResource" />. If the caller
        ///     specifies a zero time-out interval in
        ///     the <paramref name="timeoutInMilliseconds" /> parameter, <seealso cref="AcquireNextFrame" /> verifies whether there
        ///     is a new desktop image available,
        ///     returns immediately, and indicates its outcome with the return value. If the caller specifies an INFINITE time-out
        ///     interval in the <paramref name="timeoutInMilliseconds" /> parameter, the time-out interval never elapses.
        ///     <b>
        ///         Note: You cannot cancel the wait that you specified in the <paramref name="timeoutInMilliseconds" /> parameter.
        ///         Therefore, if you
        ///         must periodically check for other conditions (for example, a terminate signal), you should specify a
        ///         non-INFINITE time-out interval. After the time-out interval elapses, you can check for these other conditions
        ///         and then call <seealso cref="AcquireNextFrame" /> again to wait for the next frame.
        ///     </b>
        ///     <seealso cref="AcquireNextFrame" /> acquires a new desktop frame when the operating system either updates the
        ///     desktop bitmap image or
        ///     changes the shape or position of a hardware pointer. The new frame that <seealso cref="AcquireNextFrame" />
        ///     acquires might have only
        ///     the desktop image updated, only the pointer shape or position updated, or both.
        /// </remarks>
        int AcquireNextFrame
        (
            uint timeoutInMilliseconds,
            out DXGIOutDuplFrameInfo frameInfo,
            out IDXGIResource desktopResource
        );

        /// <summary>
        ///     Gets information about dirty rectangles for the current desktop frame.
        /// </summary>
        /// <param name="dirtyRectsBufferSize">
        ///     The size in bytes of the buffer that the caller passed to the dirtyRectsBuffer
        ///     parameter.
        /// </param>
        /// <param name="dirtyRectsBuffer">
        ///     A ref variable to an array of <seealso cref="Rect" /> structures that identifies the
        ///     dirty rectangle regions for the desktop frame.
        /// </param>
        /// <param name="dirtyRectsBufferSizeRequired">
        ///     Pointer to a variable that receives the number of bytes that <seealso cref="GetFrameDirtyRects" /> needs to store
        ///     information about
        ///     dirty regions in the buffer at
        ///     <b>
        ///         <paramref name="dirtyRectsBuffer" />
        ///     </b>
        ///     .
        ///     For more information about returning the required buffer size, see Remarks.
        /// </param>
        int GetFrameDirtyRects
        (
            uint dirtyRectsBufferSize,
            ref Rect[] dirtyRectsBuffer,
            out uint dirtyRectsBufferSizeRequired
        );

        /// <summary>
        ///     Gets information about the moved rectangles for the current desktop frame.
        /// </summary>
        /// <param name="moveRectsBufferSize">
        ///     The size in bytes of the buffer that the caller passed to the
        ///     <b>moveRectBuffer</b> parameter.
        /// </param>
        /// <param name="moveRectBuffer">
        ///     A reference to an array of <seealso cref="DXGIOutDuplMoveRect" /> structures that identifies the moved rectangle
        ///     regions for the
        ///     desktop frame.
        ///     <b>moveRectsBufferSizeRequired</b>
        ///     reference to a variable that receives the number of bytes that <seealso cref="GetFrameMoveRects" /> needs to store
        ///     information about
        ///     moved regions in the buffer at <b>moveRectBuffer</b>.
        ///     For more information about returning the required buffer size, see Remarks.
        /// </param>
        /// <param name="moveRectsBufferSizeRequired">The move rects buffer size required.</param>
        /// <returns></returns>
        int GetFrameMoveRects
        (
            uint moveRectsBufferSize,
            ref DXGIOutDuplMoveRect[] moveRectBuffer,
            out uint moveRectsBufferSizeRequired
        );

        /// <summary>
        ///     Gets the frame pointer shape.
        /// </summary>
        /// <param name="pointerShapeBufferSize">
        ///     The size in bytes of the buffer that the caller passed to the pPointerShapeBuffer
        ///     parameter.
        /// </param>
        /// <param name="pPointerShapeBuffer">
        ///     A pointer to a buffer to which <seealso cref="GetFramePointerShape" /> copies and
        ///     returns pixel data for the new pointer shape.
        /// </param>
        /// <param name="pPointerShapeBufferSizeRequired">
        ///     Pointer to a variable that receives the number of bytes that
        ///     GetFramePointerShape needs to store the new pointer shape pixel data in the buffer at pPointerShapeBuffer.
        /// </param>
        /// <param name="pPointerShapeInfo">
        ///     Pointer to a <seealso cref="DXGIOutDuplPointerShapeInfo" /> structure that receives the
        ///     pointer shape information.
        /// </param>
        /// <returns></returns>
        int GetFramePointerShape
        (
            uint pointerShapeBufferSize,
            IntPtr pPointerShapeBuffer,
            out uint pPointerShapeBufferSizeRequired,
            ref DXGIOutDuplPointerShapeInfo[] pPointerShapeInfo
        );

        /// <summary>
        ///     Provides the CPU with efficient access to a desktop image if that desktop image is already in system memory.
        /// </summary>
        /// <param name="lockedRect">
        ///     A reference to a <seealso cref="DXGIMappedRect" /> structure that receives the surface data that
        ///     the CPU needs to directly access the surface data.
        /// </param>
        /// <returns></returns>
        int MapDesktopSurface(ref DXGIMappedRect lockedRect);

        /// <summary>
        ///     Invalidates the pointer to the desktop image that was retrieved by using
        ///     <seealso cref="IDXGIOutputDuplication.MapDesktopSurface" />.
        /// </summary>
        /// <returns></returns>
        int UnMapDesktopSurface();

        /// <summary>
        ///     Indicates that the application finished processing the frame.
        /// </summary>
        /// <returns></returns>
        int ReleaseFrame();
    }
}