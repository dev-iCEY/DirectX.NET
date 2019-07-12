#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
    public interface IDevice : IObject
    {
        int GetAdapter(out IAdapter adapter);
        int CreateSurface(in SurfaceDescription surfaceDesc, uint numSurfaces, Usage usage, in SharedResource sharedResource, out ISurface surface);
        int QueryResourceResidency(IResource[] resources, out Residency residencyStatus, uint numResources);
        int SetGpuThreadPriority(int priority);
        int GetGpuThreadPriority(out int priority);
    }
}