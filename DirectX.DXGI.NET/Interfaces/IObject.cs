#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
    public interface IObject : IUnknown
    {
        int SetPrivateData(in Guid name, uint dataSize, byte[] data);
        int SetPrivateDataInterface(in Guid name, IUnknown unknown = null);
        int GetPrivateData(in Guid name, ref uint dataSize, [In, Out] byte[] data = null);
        int GetParent(in Guid riid, out IntPtr parent);
    }
}