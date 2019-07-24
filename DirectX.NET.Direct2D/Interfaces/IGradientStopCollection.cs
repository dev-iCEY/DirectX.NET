#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Represents an collection of gradient stops that can then be the source resource for either a linear or radial
    ///     gradient brush.
    /// </summary>
    [Guid("2cd906a7-12e2-11dc-9fed-001143a055f9")]
    public interface IGradientStopCollection : IResource
    {
        /// <summary>
        ///     Returns the number of stops in the gradient.
        /// </summary>
        uint GetGradientStopCount();

        /// <summary>
        ///     Copies the gradient stops from the collection into the caller's interface.  The returned colors have straight
        ///     alpha.
        /// </summary>
        void GetGradientStops(out GradientStop[] gradientStops, uint gradientStopsCount);

        /// <summary>
        ///     Returns whether the interpolation occurs with 1.0 or 2.2 gamma.
        /// </summary>
        Gamma GetColorInterpolationGamma();

        ExtendMode GetExtendMode();
    }
}