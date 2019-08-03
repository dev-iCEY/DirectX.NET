#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
    public interface IDXGISwapChain : IDXGIDeviceSubObject
    {
        int Present(uint syncInterval, PresentFlags flags = 0);
        int GetBuffer(uint buffer, in Guid riid, out IUnknown surface);
        int SetFullscreenState(bool state, [Optional] IDXGIOutput target);
        int GetFullscreenState(out bool state, out IDXGIOutput target);
        int GetDesc(out DXGISwapChainDescription desc);
        int ResizeBuffers(uint bufferCount, uint width, uint height, DXGIFormat newFormat, DXGISwapChainFlag flags);
        int ResizeTarget(in DXGIModeDescription newTargetParameters);
        int GetContainingOutput(out IDXGIOutput output);
        int GetFrameStatistics(out DXGIFrameStatistics frameStatistics);
        int GetLastPresentCount(out uint lastPresentCount);
    }
}