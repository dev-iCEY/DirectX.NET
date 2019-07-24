#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     Represents the backing store required to render a layer.
    /// </summary>
    [Guid("2cd9069b-12e2-11dc-9fed-001143a055f9")]
    public interface ILayer : IResource
    {
        SizeF GetSize();
    }
}