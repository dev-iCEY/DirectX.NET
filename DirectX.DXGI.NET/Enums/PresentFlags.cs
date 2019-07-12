#region Usings

using System;

#endregion

namespace DirectX.DXGI.NET
{
    [Flags]
    public enum PresentFlags : uint
    {
        Test = (uint) 0x00000001UL,
        DoNotSequence = (uint) 0x00000002UL,
        Restart = (uint) 0x00000004UL,
        DoNotWait = (uint) 0x00000008UL,
        StereoPreferRight = (uint) 0x00000010UL,
        StereoTemporaryMono = (uint) 0x00000020UL,
        RestrictToOutput = (uint) 0x00000040UL,
        UseDuration = (uint) 0x00000100UL,
        AllowTearing = (uint) 0x00000200UL
    }
}