#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_3.Interfaces
{
    [ComImport, Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChainMedia
    {
#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetFrameStatisticsMedia(out FrameStatisticsMedia statistics);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            SetPresentDuration(uint duration);

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            CheckPresentDurationSupport(uint desiredPresentDuration, out uint closestSmallerPresentDuration,
                out uint closestLargerPresentDuration);
    }
}