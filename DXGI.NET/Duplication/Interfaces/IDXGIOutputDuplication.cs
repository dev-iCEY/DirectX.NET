#region Usings

using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.Duplication.Interfaces
{
    [ComImport, Guid("191cfac3-a341-470d-b26e-a864f428319c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutputDuplication
    {
        void GetDesc(out OutputDuplicationDescription duplicationDescription);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            AcquireNextFrame(uint timeoutInMilliseconds, out OutputDuplicationFrameInfo frameInfo,
                out IDXGIResource desktopResource);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFrameDirtyRects(uint dirtyRectsBufferSize,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0), In, Out]
                Rect[] dirtyRectsBuffer, out uint dirtyRectsBufferSizeRequired);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFrameMoveRects(uint moveRectsBufferSize,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0), In, Out]
                Rect[] moveRectBuffer, out uint moveRectsBufferSizeRequired);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFramePointerShape(uint pointerShapeBufferSize,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0), In, Out]
                OutputDuplicationPointerShapeInfo[] pointerShapeBuffer, out uint pointerShapeBufferSizeRequired,
                out OutputDuplicationPointerShapeInfo pointerShapeInfo);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            MapDesktopSurface(out OutputDuplicationMoveRect lockedRect);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            UnMapDesktopSurface();

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ReleaseFrame();
    }
}