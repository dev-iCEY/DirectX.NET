#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     <inheritdoc cref="IDXGIAdapter1" />
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.DXGIAdapter" />
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIAdapter1" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIAdapter1 : DXGIAdapter, IDXGIAdapter1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIAdapter.LastMethodId + 1u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIAdapter1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIAdapter1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIAdapter1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Gets a DXGI 1.1 description of a local or remote adapter (or video card).
        /// </summary>
        /// <param name="adapterDesc1">
        ///     A <seealso cref="DXGIAdapterDescription1" /> structure that describes the adapter. This
        ///     parameter must not be null.
        /// </param>
        /// <returns>
        ///     Returns 0 if successful; otherwise returns an error code. Returns DXGI_ERR_INVALID_CALL if the pDesc parameter
        ///     is NULL. For a list of error codes, see DXGI_ERROR.
        /// </returns>
        public int GetDesc1(out DXGIAdapterDescription1 adapterDesc1)
        {
            return GetMethodDelegate<GetDesc1Delegate>().Invoke(this, out adapterDesc1);
        }

        [ComMethodId(10u)]
        private delegate int GetDesc1Delegate(IntPtr thisPtr, out DXGIAdapterDescription1 adapterDescription1);
    }
}