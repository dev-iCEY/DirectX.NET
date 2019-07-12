#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
    public interface IDeviceSubObject : IObject
    {
        int GetDevice(in Guid riid, out IUnknown device);
    }
}