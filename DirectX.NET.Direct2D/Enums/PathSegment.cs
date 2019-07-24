#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Indicates whether the given segment should be stroked, or, if the join between this segment and the previous one
    ///     should be smooth.
    /// </summary>
    [Flags]
    public enum PathSegment : uint
    {
        None = 0x00000000,
        ForceUnStroked = 0x00000001,
        ForceRoundLineJoin = 0x00000002
    }
}