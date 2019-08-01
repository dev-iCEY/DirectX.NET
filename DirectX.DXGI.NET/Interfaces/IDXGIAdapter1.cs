#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("29038f61-3839-4626-91fd-086879011a05")]
    public interface IDXGIAdapter1 : IDXGIAdapter
    {
        int GetDesc1(out AdapterDescription1 adapterDesc1);
    }
}