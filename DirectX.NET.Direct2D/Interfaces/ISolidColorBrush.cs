#region Usings

using System.Runtime.InteropServices;
using DirectX.DXGI.NET;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Paints an area with a solid color.
    /// </summary>
    [Guid("2cd906a9-12e2-11dc-9fed-001143a055f9")]
    public interface ISolidColorBrush : IBrush
    {
        /// <summary>
        ///     Specifies the color of this solid color brush.
        /// </summary>
        /// <param name="color">Specifies the color of this solid color brush.</param>
        void SetColor(in Rgba color);

        /// <summary>
        ///     Retrieves the color of the solid color brush.
        /// </summary>
        /// <param name="color">The color of this solid color brush.</param>
        void GetColor(out Rgba color);
    }
}