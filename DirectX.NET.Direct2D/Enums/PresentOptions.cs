#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes how present should behave.
    /// </summary>
    [Flags]
    public enum PresentOptions : uint
    {
        None = 0x00000000,

        /// <summary>
        ///     Keep the target contents intact through present.
        /// </summary>
        RetainContents = 0x00000001,

        /// <summary>
        ///     Do not wait for display refresh to commit changes to display.
        /// </summary>
        Immediately = 0x00000002
    }
}