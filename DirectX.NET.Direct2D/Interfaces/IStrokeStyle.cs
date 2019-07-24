#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Resource interface that holds pen style properties.
    /// </summary>
    [Guid("2cd9069d-12e2-11dc-9fed-001143a055f9")]
    public interface IStrokeStyle : IResource
    {
        CapStyle GetStartCap();
        CapStyle GetEndCap();
        CapStyle GetDashCap();
        float GetMiterLimit();
        LineJoin GetLineJoin();
        float GetDashOffset();
        DashStyle GetDashStyle();
        uint GetDashesCount();

        /// <summary>
        ///     Returns the dashes from the object into a user allocated array. The user must call GetDashesCount to retrieve the
        ///     required size.
        /// </summary>
        void GetDashes([In, Out] float[] dashed, uint countDashes);
    }
}