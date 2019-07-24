#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the HWND, pixel size, and presentation options for an IHwndRenderTarget.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HwndRenderTargetProperties
    {
        public IntPtr WindowHandle;
        public SizeU PixelSize;
        public PresentOptions PresentOptions;
    }
}