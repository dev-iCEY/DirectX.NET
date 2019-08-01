#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
    public interface IDXGIFactory1 : IDXGIFactory
    {
        int EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1);
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsCurrent();
    }
}