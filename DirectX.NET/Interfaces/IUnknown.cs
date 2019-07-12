#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Interfaces
{
    [Guid("00000000-0000-0000-C000-000000000046")]
    public interface IUnknown : IDisposable
    {
        int QueryInterface(in Guid riid, out IntPtr unknownObjectPtr);
        uint AddRef();
        uint Release();
    }
}