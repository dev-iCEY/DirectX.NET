#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Flags that indicate how the back buffers should be rotated to fit the physical rotation of a monitor.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIModeRotation : uint
    {
        /// <summary>
        ///     Unspecified rotation.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        ///     Specifies no rotation.
        /// </summary>
        Identity = 1,

        /// <summary>
        ///     Specifies 90 degrees of rotation.
        /// </summary>
        Rotate90 = 2,

        /// <summary>
        ///     Specifies 180 degrees of rotation.
        /// </summary>
        Rotate180 = 3,

        /// <summary>
        ///     Specifies 270 degrees of rotation.
        /// </summary>
        Rotate270 = 4
    }
}