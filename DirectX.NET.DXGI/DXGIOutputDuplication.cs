#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="IDXGIOutputDuplication" /> interface accesses and manipulates the duplicated desktop image.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIObject" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIOutputDuplication" />
    public class DXGIOutputDuplication : DXGIObject, IDXGIOutputDuplication
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 8u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIOutputDuplication).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIObject" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIOutputDuplication(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Retrieves a description of a duplicated output. This description specifies the dimensions of the surface that
        ///     contains the desktop image.
        /// </summary>
        /// <param name="description">The description.</param>
        public void GetDesc(out DXGIOutDuplDescription description)
        {
            GetMethodDelegate<DXGIGetDescDelegate>().Invoke(this, out description);
        }

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
        ///     <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" /> returns in the variable at
        ///     <paramref name="desktopResource" />. If the caller
        ///     specifies a zero time-out interval in
        ///     the <paramref name="timeoutInMilliseconds" /> parameter, <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" />
        ///     verifies whether there
        ///     is a new desktop image available,
        ///     returns immediately, and indicates its outcome with the return value. If the caller specifies an INFINITE time-out
        ///     interval in the <paramref name="timeoutInMilliseconds" /> parameter, the time-out interval never elapses.
        ///     <b>
        ///         Note: You cannot cancel the wait that you specified in the <paramref name="timeoutInMilliseconds" /> parameter.
        ///         Therefore, if you
        ///         must periodically check for other conditions (for example, a terminate signal), you should specify a
        ///         non-INFINITE time-out interval. After the time-out interval elapses, you can check for these other conditions
        ///         and then call <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" /> again to wait for the next frame.
        ///     </b>
        ///     <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" /> acquires a new desktop frame when the operating system
        ///     either updates the
        ///     desktop bitmap image or
        ///     changes the shape or position of a hardware pointer. The new frame that
        ///     <seealso cref="IDXGIOutputDuplication.AcquireNextFrame" />
        ///     acquires might have only
        ///     the desktop image updated, only the pointer shape or position updated, or both.
        /// </remarks>
        public int AcquireNextFrame(uint timeoutInMilliseconds, out DXGIOutDuplFrameInfo frameInfo,
            out IDXGIResource desktopResource)
        {
            int result = GetMethodDelegate<DXGIAcquireNextFrameDelegate>()
                .Invoke(this, timeoutInMilliseconds, out frameInfo, out IntPtr resourcePtr);
            desktopResource = result == 0 ? new DXGIResource(resourcePtr) : null;
            return result;
        }

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
        ///     Pointer to a variable that receives the number of bytes that
        ///     <seealso cref="IDXGIOutputDuplication.GetFrameDirtyRects" /> needs to store
        ///     information about
        ///     dirty regions in the buffer at
        ///     <b>
        ///         <paramref name="dirtyRectsBuffer" />
        ///     </b>
        ///     .
        ///     For more information about returning the required buffer size, see Remarks.
        /// </param>
        public int GetFrameDirtyRects(uint dirtyRectsBufferSize, ref Rect[] dirtyRectsBuffer,
            out uint dirtyRectsBufferSizeRequired)
        {
            return GetMethodDelegate<DXGIGetFrameDirtyRectsDelegate>()
                .Invoke(this, dirtyRectsBufferSize, ref dirtyRectsBuffer, out dirtyRectsBufferSizeRequired);
        }

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
        ///     reference to a variable that receives the number of bytes that
        ///     <seealso cref="IDXGIOutputDuplication.GetFrameMoveRects" /> needs to store
        ///     information about
        ///     moved regions in the buffer at <b>moveRectBuffer</b>.
        ///     For more information about returning the required buffer size, see Remarks.
        /// </param>
        /// <param name="moveRectsBufferSizeRequired">The move rects buffer size required.</param>
        /// <returns></returns>
        public int GetFrameMoveRects(uint moveRectsBufferSize, ref DXGIOutDuplMoveRect[] moveRectBuffer,
            out uint moveRectsBufferSizeRequired)
        {
            return GetMethodDelegate<DXGIGetFrameMoveRectsDelegate>()
                .Invoke(this, moveRectsBufferSize, ref moveRectBuffer, out moveRectsBufferSizeRequired);
        }

        /// <summary>
        ///     Gets the frame pointer shape.
        /// </summary>
        /// <param name="pointerShapeBufferSize">
        ///     The size in bytes of the buffer that the caller passed to the pPointerShapeBuffer
        ///     parameter.
        /// </param>
        /// <param name="pPointerShapeBuffer">
        ///     A pointer to a buffer to which <seealso cref="IDXGIOutputDuplication.GetFramePointerShape" /> copies and
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
        public int GetFramePointerShape(uint pointerShapeBufferSize, IntPtr pPointerShapeBuffer,
            out uint pPointerShapeBufferSizeRequired, ref DXGIOutDuplPointerShapeInfo[] pPointerShapeInfo)
        {
            return GetMethodDelegate<DXGIGetFramePointerShapeDelegate>()
                .Invoke
                (this,
                    pointerShapeBufferSize,
                    pPointerShapeBuffer,
                    out pPointerShapeBufferSizeRequired,
                    ref pPointerShapeInfo
                );
        }

        /// <summary>
        ///     Provides the CPU with efficient access to a desktop image if that desktop image is already in system memory.
        /// </summary>
        /// <param name="lockedRect">
        ///     A reference to a <seealso cref="DXGIMappedRect" /> structure that receives the surface data that
        ///     the CPU needs to directly access the surface data.
        /// </param>
        /// <returns></returns>
        public int MapDesktopSurface(ref DXGIMappedRect lockedRect)
        {
            return GetMethodDelegate<DXGIMapDesktopSurfaceDelegate>()
                .Invoke(this, ref lockedRect);
        }

        /// <summary>
        ///     Invalidates the pointer to the desktop image that was retrieved by using
        ///     <seealso cref="IDXGIOutputDuplication.MapDesktopSurface" />.
        /// </summary>
        /// <returns></returns>
        public int UnMapDesktopSurface()
        {
            return GetMethodDelegate<DXGIUnMapDesktopSurfaceDelegate>()
                .Invoke(this);
        }

        /// <summary>
        ///     Indicates that the application finished processing the frame.
        /// </summary>
        /// <returns></returns>
        public int ReleaseFrame()
        {
            return GetMethodDelegate<DXGIReleaseFrameDelegate>()
                .Invoke(this);
        }

        [ComMethodId(DXGIObject.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void DXGIGetDescDelegate(IntPtr thisPtr, out DXGIOutDuplDescription description);

        [ComMethodId(DXGIObject.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIAcquireNextFrameDelegate
        (
            IntPtr thisPtr,
            uint timeoutInMilliseconds,
            out DXGIOutDuplFrameInfo frameInfo,
            out IntPtr desktopResource
        );

        [ComMethodId(DXGIObject.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetFrameDirtyRectsDelegate
        (
            IntPtr thisPtr,
            uint dirtyRectsBufferSize,
            [MarshalAs(UnmanagedType.LPArray)]
            ref Rect[] dirtyRectsBuffer,
            out uint dirtyRectsBufferSizeRequired
        );

        [ComMethodId(DXGIObject.LastMethodId + 4u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetFrameMoveRectsDelegate
        (
            IntPtr thisPtr,
            uint moveRectsBufferSize,
            [MarshalAs(UnmanagedType.LPArray)]
            ref DXGIOutDuplMoveRect[] moveRectBuffer,
            out uint moveRectsBufferSizeRequired
        );

        [ComMethodId(DXGIObject.LastMethodId + 5u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetFramePointerShapeDelegate
        (
            IntPtr thisPtr,
            uint pointerShapeBufferSize,
            IntPtr pPointerShapeBuffer,
            out uint pPointerShapeBufferSizeRequired,
            [MarshalAs(UnmanagedType.LPArray)]
            ref DXGIOutDuplPointerShapeInfo[] pPointerShapeInfo
        );

        [ComMethodId(DXGIObject.LastMethodId + 6u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIMapDesktopSurfaceDelegate(IntPtr thisPtr, ref DXGIMappedRect lockedRect);

        [ComMethodId(DXGIObject.LastMethodId + 7u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIUnMapDesktopSurfaceDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIObject.LastMethodId + 8u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIReleaseFrameDelegate(IntPtr thisPtr);
    }
}