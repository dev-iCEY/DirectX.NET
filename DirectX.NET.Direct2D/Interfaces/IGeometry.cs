#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Represents a geometry resource and defines a set of helper methods for
    ///     manipulating and measuring geometric shapes. Interfaces that inherit from <see cref="IGeometry" /> define specific
    ///     shapes.
    /// </summary>
    [Guid("2cd906a1-12e2-11dc-9fed-001143a055f9")]
    public interface IGeometry : IResource
    {
        /// <summary>
        ///     Retrieve the bounds of the geometry, with an optional applied transform.
        /// </summary>
        int GetBounds(in Matrix3X2 worldTransform, out RectF bounds);

        int GetWidenedBounds();
    }
}