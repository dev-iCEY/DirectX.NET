#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes the minimum DirectX support required for hardware rendering by a render target.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum FeatureLevel : uint
    {
        /// <summary>
        ///     The caller does not require a particular underlying D3D device level.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     The D3D device level is DX9 compatible.
        /// </summary>
        Level_9 = NET.FeatureLevel.Level_9_1,

        /// <summary>
        ///     The D3D device level is DX10 compatible.
        /// </summary>
        Level_10 = NET.FeatureLevel.Level_10_0
    }
}