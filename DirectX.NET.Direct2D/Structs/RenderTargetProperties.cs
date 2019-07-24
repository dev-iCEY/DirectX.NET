#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains rendering options (hardware or software), pixel format, DPI information, remoting options, and Direct3D
    ///     support requirements for a render target.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderTargetProperties
    {
        public RenderTargetType Type;
        public PixelFormat PixelFormat;
        public float DpiX;
        public float DpiY;
        public RenderTargetUsage Usage;
        public FeatureLevel MinLevel;
    }
}