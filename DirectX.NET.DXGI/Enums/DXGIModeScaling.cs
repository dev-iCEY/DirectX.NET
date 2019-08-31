#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Flags indicating how an image is stretched to fit a given monitor's resolution.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIModeScaling : uint
    {
        /// <summary>
        ///     Unspecified scaling.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        ///     Specifies no scaling. The image is centered on the display. This flag is typically used for a fixed-dot-pitch
        ///     display (such as an LED display).
        /// </summary>
        Centered = 1,

        /// <summary>
        ///     Specifies stretched scaling.
        /// </summary>
        Stretched = 2
    }
}