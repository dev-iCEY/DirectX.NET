#region Usings

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    /// </summary>
    public static class DxgiSwapChainFlagExtensions
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