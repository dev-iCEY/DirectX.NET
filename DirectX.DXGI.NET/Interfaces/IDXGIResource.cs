#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
    public interface IDXGIResource : IDXGIDeviceSubObject
    {
        int GetSharedHandle(out IntPtr sharedHandle);
        int GetUsage(out Usage usage);
        int SetEvictionPriority(uint evictionPriority);
        int GetEvictionPriority(out uint evictionPriority);
    }
}