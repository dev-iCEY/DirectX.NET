#region Usings

using System;

#endregion

namespace DXGI.NET.V1_3
{
    [Flags]
    public enum MultiPlaneOverlayYCbCrFlags : uint
    {
        NominalRange = 0x1,
        Bt709 = 0x2,
        XvYcc = 0x4
    }
}