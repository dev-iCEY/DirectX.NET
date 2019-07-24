#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Paints an area with a radial gradient.
    /// </summary>
    [Guid("2cd906ac-12e2-11dc-9fed-001143a055f9")]
    public interface IRadialGradientBrush : IBrush
    {
        /// <summary>
        ///     Sets the center of the radial gradient. This will be in local coordinates and will not depend on the geometry being
        ///     filled.
        /// </summary>
        void SetCenter(Point2F center);

        /// <summary>
        ///     Sets offset of the origin relative to the radial gradient center.
        /// </summary>
        void SetGradientOriginOffset(Point2F gradientOriginOffset);

        void SetRadiusX(float radiusX);

        void SetRadiusY(float radiusY);

        Point2F GetCenter();

        Point2F GetGradientOriginOffset();

        float GetRadiusX();

        float GetRadiusY();

        void GetGradientStopCollection(out IGradientStopCollection gradientStopCollection);
    }
}