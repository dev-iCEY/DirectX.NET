#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("9d8e1289-d7b3-465f-8126-250e349af85d")]
    public interface IKeyedMutex : IDeviceSubObject
    {
        int AcquireSync(ulong key, uint milliseconds);
        int ReleaseSync(ulong key);
    }
}