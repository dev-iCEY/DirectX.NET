#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An <seealso cref="IDXGIObject" /> interface is a base interface for all DXGI objects;
    ///     <seealso cref="IDXGIObject" /> supports associating caller-defined (private data) with an object and retrieval of
    ///     an interface to the parent object.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIObject : Unknown, IDXGIObject
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = Unknown.LastMethodId + 4u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIObject).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIObject" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIObject(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

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
        public int SetPrivateData(in Guid name, uint dataSize, byte[] data)
        {
            return GetMethodDelegate<SetPrivateDataDelegate>()
                .Invoke(this, in name, dataSize, data);
        }

        /// <summary>
        ///     Set an interface in the object's private data.
        /// </summary>
        /// <param name="name">A <seealso cref="Guid" /> identifying the interface.</param>
        /// <param name="iUnknown">The interface to set.</param>
        /// <returns>Returns one of the following DXGI_ERROR.</returns>
        /// <remarks>
        ///     This API associates an interface pointer with the object.
        ///     When the interface is set its reference count is incremented. When the data are overwritten (by calling SPD or SPDI
        ///     with the same <seealso cref="Guid" />) or the object is destroyed,
        ///     <seealso cref="IUnknown.Release" /> is
        ///     called and the interface's reference count is
        ///     decremented.
        /// </remarks>
        public int SetPrivateDataInterface(in Guid name, IUnknown iUnknown = null)
        {
            return GetMethodDelegate<SetPrivateDataInterfaceDelegate>()
                .Invoke(this, in name, (Unknown) iUnknown ?? IntPtr.Zero);
        }

        /// <summary>
        ///     Get a pointer to the object's data.
        /// </summary>
        /// <param name="name">A <seealso cref="Guid" /> identifying the data.</param>
        /// <param name="dataSize">The size of the data.</param>
        /// <param name="data">Pointer to the data.</param>
        /// <returns>Returns one of the following DXGI_ERROR.</returns>
        public int GetPrivateData(in Guid name, ref uint dataSize, [In, Out] byte[] data = null)
        {
            return GetMethodDelegate<GetPrivateDataDelegate>()
                .Invoke(this, in name, ref dataSize, data);
        }

        /// <summary>
        ///     Gets the parent of the object.
        /// </summary>
        /// <param name="riid">The ID of the requested interface. See remarks.</param>
        /// <param name="parent">The address of a pointer to the parent object.</param>
        public int GetParent(in Guid riid, out IntPtr parent)
        {
            return GetMethodDelegate<GetParentDelegate>()
                .Invoke(this, in riid, out parent);
        }

        [ComMethodId(Unknown.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetPrivateDataDelegate(IntPtr thisPtr, in Guid name, uint dataSize,
            [MarshalAs(UnmanagedType.LPArray)] byte[] data);

        [ComMethodId(Unknown.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetPrivateDataInterfaceDelegate(IntPtr thisPtr, in Guid name, IntPtr iUnknown);

        [ComMethodId(Unknown.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetPrivateDataDelegate(IntPtr thisPtr, in Guid name, ref uint dataSize,
            [In, Out, MarshalAs(UnmanagedType.LPArray)]
            byte[] data = null);

        [ComMethodId(Unknown.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetParentDelegate(IntPtr thisPtr, in Guid riid, out IntPtr parent);
    }
}