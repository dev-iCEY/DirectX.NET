#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     A bitmap brush allows a bitmap to be used to fill a geometry.
    /// </summary>
    [Guid("2cd906aa-12e2-11dc-9fed-001143a055f9")]
    public interface IBitmapBrush : IBrush
    {
        /// <summary>
        ///     Sets how the bitmap is to be treated outside of its natural extent on the X axis.
        /// </summary>
        void SetExtendModeX(ExtendMode extendModeX);

        /// <summary>
        ///     Sets how the bitmap is to be treated outside of its natural extent on the Y axis.
        /// </summary>
        void SetExtendModeY(ExtendMode extendModeY);

        /// <summary>
        ///     Sets the interpolation mode used when this brush is used.
        /// </summary>
        void SetInterpolationMode(BitmapInterpolationMode interpolationMode);

        /// <summary>
        ///     Sets the bitmap associated as the source of this brush.
        /// </summary>
        void SetBitmap(IBitmap bitmap);


        /// <summary>
        ///     Get how the bitmap is to be treated outside of its natural extent on the X axis.
        /// </summary>
        ExtendMode GetExtendModeX();

        /// <summary>
        ///     Get how the bitmap is to be treated outside of its natural extent on the Y axis.
        /// </summary>
        ExtendMode GetExtendModeY();

        /// <summary>
        ///     Get the interpolation mode used when this brush is used.
        /// </summary>
        BitmapInterpolationMode GetInterpolationMode();

        /// <summary>
        ///     Get the bitmap associated as the source of this brush.
        /// </summary>
        void GetBitmap(out IBitmap bitmap);
    }
}