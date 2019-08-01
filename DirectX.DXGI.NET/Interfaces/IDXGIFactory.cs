#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <inheritdoc />
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIFactory : IDXGIObject
    {
        int EnumAdapters(uint adapterIndex, out IDXGIAdapter adapter);
        int MakeWindowAssociation(IntPtr windowHandle, WindowAssociationFlags flags);
        int GetWindowAssociation(out IntPtr windowHandle);
        int CreateSwapChain(IUnknown device, in SwapChainDescription desc, out IDXGISwapChain swapChain);
        int CreateSoftwareAdapter(IntPtr moduleHandle, out IDXGIAdapter softwareAdapter);
    }
}