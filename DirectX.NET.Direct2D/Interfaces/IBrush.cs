#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     The root brush interface. All brushes can be used to fill or pen a geometry.
    /// </summary>
    [Guid("2cd906a8-12e2-11dc-9fed-001143a055f9")]
    public interface IBrush : IResource
    {
        /// <summary>
        ///     Sets the opacity for when the brush is drawn over the entire fill of the brush.
        /// </summary>
        void SetOpacity(float opacity);

        /// <summary>
        ///     Sets the transform that applies to everything drawn by the brush.
        /// </summary>
        void SetTransform(in Matrix3X2 transform);

        /// <summary>
        ///     Get the opacity for when the brush is drawn over the entire fill of the brush.
        /// </summary>
        float GetOpacity();

        /// <summary>
        ///     Get the transform that applies to everything drawn by the brush.
        /// </summary>
        void GetTransform(out Matrix3X2 transform);
    }
}