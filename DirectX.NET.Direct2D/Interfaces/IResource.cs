#region Usings

using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     The root interface for all resources in D2D.
    /// </summary>
    [Guid("2cd90691-12e2-11dc-9fed-001143a055f9")]
    public interface IResource : IUnknown
    {
        /// <summary>
        ///     Retrieve the factory associated with this resource.
        /// </summary>
        void GetFactory(out IFactory factory);
    }
}