#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("77db970f-6276-48ba-ba28-070143b4392c")]
    public interface IDevice1 : IDevice
    {
        int SetMaximumFrameLatency(uint maxLatency);
        int GetMaximumFrameLatency(out uint maxLatency);
    }
}