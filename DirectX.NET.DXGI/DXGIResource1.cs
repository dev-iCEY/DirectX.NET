#region Usings

using System;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An <seealso cref="IDXGIResource1" /> interface extends the <seealso cref="IDXGIResource" /> interface by adding
    ///     support for creating a subresource surface object and for creating a handle to a shared resource.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIResource" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIResource1" />
    public class DXGIResource1 : DXGIResource, IDXGIResource1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIResource.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIResource1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIResource" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIResource1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Creates a subresource surface object.
        /// </summary>
        /// <param name="index">The index of the subresource surface object to enumerate.</param>
        /// <param name="surface">
        ///     Variable to a <seealso cref="IDXGISurface2" /> interface that represents the created subresource
        ///     surface object at the position specified by the index parameter.
        /// </param>
        /// <returns></returns>
        public int CreateSubresourceSurface(uint index, out IDXGISurface2 surface)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Creates a handle to a shared resource. You can then use the returned handle with multiple Direct3D devices.
        /// </summary>
        /// <param name="securityAttributes">The security attributes.</param>
        /// <param name="sharedResourceAccess">The shared resource access.</param>
        /// <param name="name">
        ///     The name of the resource to share. The name is limited to MAX_PATH characters. Name comparison is
        ///     case sensitive.
        /// </param>
        /// <returns></returns>
        public int CreateSharedHandle(in SecurityAttributes securityAttributes,
            DXGISharedResourceAccess sharedResourceAccess,
            string name)
        {
            throw new NotImplementedException();
        }
    }
}