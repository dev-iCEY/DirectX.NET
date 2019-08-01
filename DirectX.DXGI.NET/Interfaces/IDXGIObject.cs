#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIObject" /> interface is a base interface for all DXGI objects;
    ///     <seealso cref="IDXGIObject" /> supports associating caller-defined (private data) with an object and retrieval of
    ///     an interface to the parent object.
    /// </summary>
    [Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIObject : IUnknown
    {
        /// <summary>
        ///     Sets an <seealso cref="DirectX.NET.Interfaces.IUnknown" /> interface as private data; this associates
        ///     application-defined data with the object.
        /// </summary>
        /// <param name="name">
        ///     A <seealso cref="Guid" /> identifying the data. This <seealso cref="Guid" /> will also be used when
        ///     getting the data.
        /// </param>
        /// <param name="dataSize">The size of the object's data.</param>
        /// <param name="data">Pointer to the object's data.</param>
        /// <returns>Returns one of the following DXGI_ERROR.</returns>
        /// <remarks>This API makes a copy of the specified data and stores it with the object.</remarks>
        int SetPrivateData(in Guid name, uint dataSize, byte[] data);

        /// <summary>
        ///     Set an interface in the object's private data.
        /// </summary>
        /// <param name="name">A <seealso cref="Guid" /> identifying the interface.</param>
        /// <param name="unknown">The interface to set.</param>
        /// <returns>Returns one of the following DXGI_ERROR.</returns>
        /// <remarks>
        ///     This API associates an interface pointer with the object.
        ///     When the interface is set its reference count is incremented. When the data are overwritten (by calling SPD or SPDI
        ///     with the same <seealso cref="Guid" />) or the object is destroyed,
        ///     <seealso cref="DirectX.NET.Interfaces.IUnknown.Release" /> is
        ///     called and the interface's reference count is
        ///     decremented.
        /// </remarks>
        int SetPrivateDataInterface(in Guid name, IUnknown unknown = null);

        /// <summary>
        ///     Get a pointer to the object's data.
        /// </summary>
        /// <param name="name">A <seealso cref="Guid" /> identifying the data.</param>
        /// <param name="dataSize">The size of the data.</param>
        /// <param name="data">Pointer to the data.</param>
        /// <returns>Returns one of the following DXGI_ERROR.</returns>
        int GetPrivateData(in Guid name, ref uint dataSize, [In, Out] byte[] data = null);

        /// <summary>
        ///     Gets the parent of the object.
        /// </summary>
        /// <param name="riid">The ID of the requested interface. See remarks.</param>
        /// <param name="parent">The address of a pointer to the parent object.</param>
        int GetParent(in Guid riid, out IntPtr parent);
    }
}