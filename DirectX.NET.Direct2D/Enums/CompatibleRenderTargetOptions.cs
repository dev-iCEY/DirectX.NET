#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specifies additional features supportable by a compatible render target when it is created. This enumeration allows
    ///     a bitwise combination of its member values.
    /// </summary>
    [Flags]
    public enum CompatibleRenderTargetOptions : uint
    {
        None = 0x00000000,

        /// <summary>
        ///     The compatible render target will allow a call to GetDC on the
        ///     ID2D1GdiInteropRenderTarget interface. This can be specified even if the parent
        ///     render target is not GDI compatible.
        /// </summary>
        GdiCompatible = 0x00000001
    }
}