#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Paints an area with a linear gradient.
    /// </summary>
    [Guid("2cd906ab-12e2-11dc-9fed-001143a055f9")]
    public interface ILinearGradientBrush : IBrush
    {
        /// <summary>
        ///     Sets the start point of the gradient in local coordinate space. This is not influenced by the geometry being
        ///     filled.
        /// </summary>
        void SetStartPoint(Point2F startPoint);

        /// <summary>
        ///     Sets the end point of the gradient in local coordinate space. This is not influenced by the geometry being filled.
        /// </summary>
        void SetEndPoint(Point2F endPoint);

        Point2F GetStartPoint();

        Point2F GetEndPoint();
    }
}