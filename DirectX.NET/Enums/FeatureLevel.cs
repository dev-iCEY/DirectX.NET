﻿#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum FeatureLevel : uint
    {
        Level_9_1 = 0x9100,
        Level_9_2 = 0x9200,
        Level_9_3 = 0x9300,
        Level_10_0 = 0xa000,
        Level_10_1 = 0xa100,
        Level_11_0 = 0xb000,
        Level_11_1 = 0xb100
    }
}