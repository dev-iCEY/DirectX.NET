#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
    public interface IFactory : IObject
    {
        int EnumAdapters(uint adapterIndex, out IAdapter adapter);
        int MakeWindowAssociation(IntPtr windowHandle, WindowAssociationFlags flags);
        int GetWindowAssociation(out IntPtr windowHandle);
        int CreateSwapChain(IUnknown device, in SwapChainDescription desc, out ISwapChain swapChain);
        int CreateSoftwareAdapter(IntPtr moduleHandle, out IAdapter softwareAdapter);
    }
}