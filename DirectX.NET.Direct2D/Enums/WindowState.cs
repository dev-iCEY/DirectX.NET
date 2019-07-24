#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes whether a window is occluded.
    /// </summary>
    [Flags]
    public enum WindowState : uint
    {
        None = 0x0000000,
        Occluded = 0x0000001
    }
}