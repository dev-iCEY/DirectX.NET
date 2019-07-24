#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Direct2D.Interfaces;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     A bitmap brush allows a bitmap to be used to fill a geometry.
    /// </summary>
    public class BitmapBrush : Brush, IBitmapBrush
    {
        protected new const uint LastMethodId = Brush.LastMethodId + 8u;
        protected new readonly int MethodsCount = typeof(IBitmapBrush).GetMethods().Length;


        public BitmapBrush(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Sets how the bitmap is to be treated outside of its natural extent on the X axis.
        /// </summary>
        public void SetExtendModeX(ExtendMode extendModeX)
        {
            GetMethodDelegate<SetExtendModeXDelegate>().Invoke(this, extendModeX);
        }

        /// <summary>
        ///     Sets how the bitmap is to be treated outside of its natural extent on the Y axis.
        /// </summary>
        public void SetExtendModeY(ExtendMode extendModeY)
        {
            GetMethodDelegate<SetExtendModeYDelegate>().Invoke(this, extendModeY);
        }

        /// <summary>
        ///     Sets the interpolation mode used when this brush is used.
        /// </summary>
        public void SetInterpolationMode(BitmapInterpolationMode interpolationMode)
        {
            GetMethodDelegate<SetInterpolationModeDelegate>().Invoke(this, interpolationMode);
        }

        /// <summary>
        ///     Sets the bitmap associated as the source of this brush.
        /// </summary>
        public void SetBitmap(IBitmap bitmap)
        {
            GetMethodDelegate<SetBitmapDelegate>().Invoke(this, (Bitmap) bitmap);
        }

        /// <summary>
        ///     Get how the bitmap is to be treated outside of its natural extent on the X axis.
        /// </summary>
        public ExtendMode GetExtendModeX()
        {
            return GetMethodDelegate<GetExtendModeXDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Get how the bitmap is to be treated outside of its natural extent on the Y axis.
        /// </summary>
        public ExtendMode GetExtendModeY()
        {
            return GetMethodDelegate<GetExtendModeYDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Get the interpolation mode used when this brush is used.
        /// </summary>
        public BitmapInterpolationMode GetInterpolationMode()
        {
            return GetMethodDelegate<GetInterpolationModeDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Get the bitmap associated as the source of this brush.
        /// </summary>
        public void GetBitmap(out IBitmap bitmap)
        {
            GetMethodDelegate<GetBitmapDelegate>().Invoke(this, out IntPtr bitmapPtr);
            bitmap = new Bitmap(bitmapPtr);
        }

        [ComMethodId(Brush.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetExtendModeXDelegate(IntPtr thisPtr, ExtendMode extendModeX);

        [ComMethodId(Brush.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetExtendModeYDelegate(IntPtr thisPtr, ExtendMode extendModeY);

        [ComMethodId(Brush.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetInterpolationModeDelegate(IntPtr thisPtr,
            BitmapInterpolationMode bitmapInterpolationMode);

        [ComMethodId(Brush.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetBitmapDelegate(IntPtr thisPtr, IntPtr bitmapPtr);

        [ComMethodId(Brush.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate ExtendMode GetExtendModeXDelegate(IntPtr thisPtr);

        [ComMethodId(Brush.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate ExtendMode GetExtendModeYDelegate(IntPtr thisPtr);

        [ComMethodId(Brush.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate BitmapInterpolationMode GetInterpolationModeDelegate(IntPtr thisPtr);

        [ComMethodId(Brush.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void GetBitmapDelegate(IntPtr thisPtr, out IntPtr bitmapPtr);
    }
}