#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Describes how a render target is remoted and whether it should be GDI-compatible. This enumeration allows a bitwise
    ///     combination of its member values.
    /// </summary>
    [Flags]
    public enum RenderTargetUsage : uint
    {
        None = 0x00000000,

        /// <summary>
        ///     Rendering will occur locally, if a terminal-services session is established, the
        ///     bitmap updates will be sent to the terminal services client.
        /// </summary>
        ForceBitmapRemoting = 0x00000001,

        /// <summary>
        ///     The render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget
        ///     interface. Rendering will also occur locally.
        /// </summary>
        GdiCompatible = 0x00000002
    }
}