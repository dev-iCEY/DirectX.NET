#region Usings

using System;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Specified options that can be applied when a layer resource is applied to create a layer.
    /// </summary>
    [Flags]
    public enum LayerOptions : uint
    {
        None = 0x00000000,

        /// <summary>
        ///     The layer will render correctly for ClearType text. If the render target was set
        ///     to ClearType previously, the layer will continue to render ClearType. If the
        ///     render target was set to ClearType and this option is not specified, the render
        ///     target will be set to render gray-scale until the layer is popped. The caller
        ///     can override this default by calling SetTextAntialiasMode while within the
        ///     layer. This flag is slightly slower than the default.
        /// </summary>
        InitializeForClearType = 0x00000001
    }
}