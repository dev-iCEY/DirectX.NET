#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class DXGISwapChainFlagExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static bool HasFlagFast(this DXGISwapChainFlag value, DXGISwapChainFlag flag)
        {
            return (value & flag) != 0;
        }
    }
}