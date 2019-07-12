#region Usings

using System;

#endregion

namespace DirectX.DXGI.NET
{
    [Flags]
    public enum Usage : uint
    {
        ShaderInput = (uint) 0x00000010UL,
        RenderTargetOutput = (uint) 0x00000020UL,
        BackBuffer = (uint) 0x00000040UL,
        Shared = (uint) 0x00000080UL,
        ReadOnly = (uint) 0x00000100UL,
        DiscardOnPresent = (uint) 0x00000200UL,
        UnorderedAccess = (uint) 0x00000400UL
    }
}