using System;

namespace DirectX.DXGI.NET
{
    [Flags]
    public enum CpuAccess : uint
    {
        None = 0,
        Dynamic = 1,
        ReadWrite = 2,
        Scratch = 3,
        Field = 15
    }
}