#region Usings

using System.Runtime.InteropServices;
using DirectX.DXGI.NET;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the position and color of a gradient stop.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GradientStop
    {
        public float Position { get; set; }
        public Rgba Color { get; set; }
    }
}