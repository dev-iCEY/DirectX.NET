#region Usings

using System;

#endregion

namespace DirectX.DXGI.NET
{
    [Flags]
    public enum Map : uint
    {
        Read = (uint) 1UL,
        Write = (uint) 2UL,
        Discard = (uint) 4UL
    }
}