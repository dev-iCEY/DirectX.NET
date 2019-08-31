#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Options for enumerating display modes.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIEnumModes : uint
    {
        /// <summary>
        ///     Include interlaced modes.
        /// </summary>
        Interlaced = 1u,

        /// <summary>
        ///     Include stretched-scaling modes.
        /// </summary>
        Scaling = 2u
    }
}