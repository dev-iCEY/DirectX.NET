#region Usings

using System;

#endregion

namespace DirectX.DXGI.NET
{
    [Flags]
    public enum AdapterFlag : uint
    {
        None = 0,
        Remote = 1,
        Software = 2
    }
}