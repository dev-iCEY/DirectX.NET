#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Contains the content bounds, mask information, opacity settings, and other options for a layer resource.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LayerParameters
    {
        /// <summary>
        ///     The rectangular clip that will be applied to the layer. The clip is affected by the world transform. Content
        ///     outside of the content bounds will not render.
        /// </summary>
        public RectF ContentBounds;

        /// <summary>
        ///     A general mask that can be optionally applied to the content. Content not inside the fill of the mask will not be
        ///     rendered.
        /// </summary>
        public IntPtr GeometricMask;

        /// <summary>
        ///     Specifies whether the mask should be aliased or antialiased.
        /// </summary>
        public AntialiasMode MaskAntialiasMode;

        /// <summary>
        ///     An additional transform that may be applied to the mask in addition to the current world transform.
        /// </summary>
        public Matrix3X2 MaskTransform;

        /// <summary>
        ///     The opacity with which all of the content in the layer will be blended back to
        ///     the target when the layer is popped.
        /// </summary>
        public float Opacity;

        /// <summary>
        ///     An additional brush that can be applied to the layer. Only the opacity channel
        ///     is sampled from this brush and multiplied both with the layer content and the
        ///     over-all layer opacity.
        /// </summary>
        public IntPtr OpacityBrush;

        /// <summary>
        ///     Specifies if ClearType will be rendered into the layer.
        /// </summary>
        public LayerOptions LayerOptions;
    }
}