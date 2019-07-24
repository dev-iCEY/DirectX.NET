#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Direct2D.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.Direct2D
{
    public class Bitmap : Image, IBitmap
    {
        protected new const uint LastMethodId = Resource.LastMethodId + 7u;
        protected new int MethodsCount = typeof(IBitmap).GetMethods().Length;

        public Bitmap(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public SizeF GetSize()
        {
            return GetMethodDelegate<GetSizeDelegate>().Invoke(this);
        }

        public SizeU GetPixelSize()
        {
            return GetMethodDelegate<GetPixelSizeDelegate>().Invoke(this);
        }

        public PixelFormat GetPixelFormat()
        {
            return GetMethodDelegate<GetPixelFormatDelegate>().Invoke(this);
        }

        public void GetDpi(out float dpiX, out float dpiY)
        {
            GetMethodDelegate<GetDpiDelegate>().Invoke(this, out dpiX, out dpiY);
        }

        public int CopyFromBitmap(in Point2U destPoint, IBitmap bitmap, in RectF srcRect)
        {
            return GetMethodDelegate<CopyFromBitmapDelegate>().Invoke(this, in destPoint, (Bitmap) bitmap, in srcRect);
        }

        public int CopyFromRenderTarget(in Point2U destPoint, IUnknown renderTarget, in RectU srcRect)
        {
            return GetMethodDelegate<CopyFromRenderTargetDelegate>()
                .Invoke(this, in destPoint, (Unknown) renderTarget, in srcRect);
        }

        public int CopyFromMemory(in RectU dstRect, IntPtr srcData, uint pitch)
        {
            return GetMethodDelegate<CopyFromMemoryDelegate>().Invoke(this, in dstRect, srcData, pitch);
        }

        [ComMethodId(Resource.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate SizeF GetSizeDelegate(IntPtr thisPtr);

        [ComMethodId(Resource.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate SizeU GetPixelSizeDelegate(IntPtr thisPtr);

        [ComMethodId(Resource.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate PixelFormat GetPixelFormatDelegate(IntPtr thisPtr);

        [ComMethodId(Resource.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void GetDpiDelegate(IntPtr thisPtr, out float dpiX, out float dpiY);

        [ComMethodId(Resource.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CopyFromBitmapDelegate(IntPtr thisPtr, in Point2U destPoint, IntPtr bitmapPtr,
            in RectF srcRect);

        [ComMethodId(Resource.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CopyFromRenderTargetDelegate(IntPtr thisPtr, in Point2U destPoint, IntPtr renderTargetPtr,
            in RectU srcRect);

        [ComMethodId(Resource.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CopyFromMemoryDelegate(IntPtr thisPtr, in RectU destRect, IntPtr srcData, uint pitch);
    }
}