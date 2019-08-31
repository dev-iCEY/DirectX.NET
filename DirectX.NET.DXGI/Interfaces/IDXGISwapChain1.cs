#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     Provides presentation capabilities that are enhanced from <see cref="IDXGISwapChain" />.
    ///     These presentation capabilities consist of specifying dirty rectangles and scroll rectangle to optimize the
    ///     presentation.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGISwapChain" />
    [Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGISwapChain1 : IDXGISwapChain
    {
        int GetDesc1(out DXGISwapChainDescription1 swapChainDescription1);

        int GetFullscreenDesc(out DXGISwapChainFullscreenDescription fullscreenDescription);

        int GetHwnd(out IntPtr hwnd);

        int GetCoreWindow(ref Guid riid, out IntPtr pUnknown);

        int Present1(uint syncInterval, DXGIPresentFlags flags, in DXGIPresentParameters presentParameters);

        bool IsTemporaryMonoSupported();

        int GetRestrictToOutput(out IDXGIOutput restrictToOutput);

        int SetBackgroundColor(in DXGIRgba color);

        int GetBackgroundColor(out DXGIRgba color);

        int SetRotation(DXGIModeRotation rotation);

        int GetRotation(out DXGIModeRotation rotation);
    }
}