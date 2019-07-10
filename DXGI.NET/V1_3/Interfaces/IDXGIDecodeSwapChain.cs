#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_3.Interfaces
{
    [ComImport, Guid("2633066b-4514-4c7a-8fd8-12ea98059d18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDecodeSwapChain
    {
#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            PresentBuffer(uint bufferToPresent, uint syncInterval, PresentFlags flags);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetSourceRect([In] ref Rect rect);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetTargetRect([In] ref Rect rect);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetDestSize(uint width, uint height);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetSourceRect(out Rect rect);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetTargetRect(out Rect rect);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDestSize(out uint width, out uint height);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetColorSpace(MultiPlaneOverlayYCbCrFlags colorSpace);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetColorSpace(out MultiPlaneOverlayYCbCrFlags colorSpace);
    }
}