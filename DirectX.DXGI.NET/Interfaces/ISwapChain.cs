﻿#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
    public interface ISwapChain : IDeviceSubObject
    {
        int Present(uint syncInterval, PresentFlags flags = 0);
        int GetBuffer(uint buffer, in Guid riid, out IUnknown surface);
        int SetFullscreenState(bool state, [Optional] IOutput target);
        int GetFullscreenState(out bool state, out IOutput target);
        int GetDesc(out SwapChainDescription desc);
        int ResizeBuffers(uint bufferCount, uint width, uint height, Format newFormat, SwapChainFlag flags);
        int ResizeTarget(in ModeDescription newTargetParameters);
        int GetContainingOutput(out IOutput output);
        int GetFrameStatistics(out FrameStatistics frameStatistics);
        int GetLastPresentCount(out uint lastPresentCount);
    }
}