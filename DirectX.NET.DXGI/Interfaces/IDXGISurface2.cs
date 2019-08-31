#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGISurface2" /> interface extends the <seealso cref="IDXGISurface1" /> interface by adding
    ///     support for sub resource surfaces and
    ///     getting a handle to a shared resource.
    /// </summary>
    [Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGISurface2 : IDXGISurface1
    {
        /// <summary>
        ///     Gets the parent resource and sub resource index that support a sub resource surface.
        /// </summary>
        /// <param name="riid">The globally unique identifier (GUID) of the requested interface type.</param>
        /// <param name="parentResourcePtr">
        ///     A pointer to a buffer that receives a pointer to the parent resource object for the sub
        ///     resource surface.
        /// </param>
        /// <param name="subResourceIndex">A variable that receives the index of the sub resource surface.</param>
        /// <returns></returns>
        int GetResource(ref Guid riid, out IntPtr parentResourcePtr, out uint subResourceIndex);
    }
}