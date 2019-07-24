#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Root bitmap resource, linearly scaled on a draw call.
    /// </summary>
    /// <remarks>Custom implementations are not supported </remarks>
    [Guid("a2296057-ea42-4099-983b-539fb6505426")]
    public interface IBitmap : IImage
    {
        /// <summary>
        ///     Returns the size, in device-independent pixels (DIPs), of the bitmap.
        /// </summary>
        /// <returns>
        ///     The size, in DIPs, of the bitmap.
        /// </returns>
        /// <remarks>
        ///     A DIP is 1/96 of an inch. To retrieve the size in device pixels, use the
        ///     <seealso cref="IBitmap.GetPixelSize" /> method.
        /// </remarks>
        SizeF GetSize();

        /// <summary>
        ///     Returns the size, in device-dependent units (pixels), of the bitmap.
        /// </summary>
        /// <returns>The size, in pixels, of the bitmap.</returns>
        SizeU GetPixelSize();

        /// <summary>
        ///     Retrieves the pixel format and alpha mode of the bitmap.
        /// </summary>
        /// <remarks>The pixel format and alpha mode of the bitmap.</remarks>
        PixelFormat GetPixelFormat();

        /// <summary>
        ///     Return the dots per inch (DPI) of the bitmap.
        /// </summary>
        /// <param name="dpiX">The horizontal DPI of the image.</param>
        /// <param name="dpiY">The vertical DPI of the image.</param>
        void GetDpi(out float dpiX, out float dpiY);

        /// <summary>
        ///     Copies the specified region from the specified bitmap into the current bitmap.
        /// </summary>
        /// <param name="destPoint">
        ///     In the current bitmap, the upper-left corner of the area to which the region specified by
        ///     srcRect is copied.
        /// </param>
        /// <param name="bitmap">The bitmap to copy from.</param>
        /// <param name="srcRect">The area of bitmap to copy.</param>
        /// <returns>If the method succeeds, it returns 0. Otherwise, it returns an HRESULT error code.</returns>
        /// <remarks>
        ///     This method does not update the size of the current bitmap. If the contents of the source bitmap do not fit in
        ///     the current bitmap, this method fails. Also, note that this method does not perform format conversion, and will
        ///     fail if the bitmap formats do not match.Calling this method may cause the current batch to flush if the bitmap is
        ///     active in the batch. If the batch that was flushed does not complete successfully, this method fails. However, this
        ///     method does not clear the error state of the render target on which the batch was flushed. The failing HRESULT and
        ///     tag state will be returned at the next call to EndDraw or Flush.
        /// </remarks>
        int CopyFromBitmap(in Point2U destPoint, IBitmap bitmap, in RectF srcRect);

        /// <summary>
        ///     Copies the specified region from the specified render target into the current bitmap.
        /// </summary>
        /// <param name="destPoint">
        ///     In the current bitmap, the upper-left corner of the area to which the region specified by
        ///     srcRect is copied.
        /// </param>
        /// <param name="renderTarget">The render target that contains the region to copy.</param>
        /// <param name="srcRect">The area of renderTarget to copy.</param>
        /// <returns>If the method succeeds, it returns 0. Otherwise, it returns an HRESULT error code.</returns>
        /// <remarks>
        ///     This method does not update the size of the current bitmap. If the contents of the source bitmap do not fit in the
        ///     current bitmap, this method fails. Also, note that this method does not perform format conversion, and will fail if
        ///     the bitmap formats do not match.
        ///     Calling this method may cause the current batch to flush if the bitmap is active in the batch. If the batch that
        ///     was flushed does not complete successfully, this method fails. However, this method does not clear the error state
        ///     of the render target on which the batch was flushed. The failing HRESULT and tag state will be returned at the next
        ///     call to EndDraw or Flush.
        ///     All clips and layers must be popped off of the render target before calling this method. The method returns
        ///     D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT if any clips or layers are currently applied to the render target.
        /// </remarks>
        int CopyFromRenderTarget(in Point2U destPoint, IUnknown renderTarget, in RectU srcRect);

        /// <summary>
        ///     Copies the specified region from memory into the current bitmap.
        /// </summary>
        /// <param name="dstRect">
        ///     In the current bitmap, the upper-left corner of the area to which the region specified by srcRect
        ///     is copied.
        /// </param>
        /// <param name="srcData">The data to copy.</param>
        /// <param name="pitch">
        ///     The stride, or pitch, of the source bitmap stored in srcData. The stride is the byte count of a
        ///     scanline (one row of pixels in memory). The stride can be computed from the following formula: pixel width * bytes
        ///     per pixel + memory padding.
        /// </param>
        /// <returns>If the method succeeds, it returns 0. Otherwise, it returns an HRESULT error code.</returns>
        /// <remarks>
        ///     This method does not update the size of the current bitmap. If the contents of the source bitmap do not fit in the
        ///     current bitmap, this method fails. Also, note that this method does not perform format conversion; the two bitmap
        ///     formats should match.
        ///     Passing this method invalid input, such as an invalid destination rectangle, can produce unpredictable results,
        ///     such as a distorted image or device failure.
        ///     Calling this method may cause the current batch to flush if the bitmap is active in the batch. If the batch that
        ///     was flushed does not complete successfully, this method fails. However, this method does not clear the error state
        ///     of the render target on which the batch was flushed. The failing HRESULT and tag state will be returned at the next
        ///     call to EndDraw or Flush.
        /// </remarks>
        int CopyFromMemory(in RectU dstRect, IntPtr srcData, uint pitch);
    }
}