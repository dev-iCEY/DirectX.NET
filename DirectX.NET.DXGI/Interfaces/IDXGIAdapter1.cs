#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGIAdapter1" /> interface represents a display sub-system (including one or more GPU's, DACs
    ///     and video memory).
    /// </summary>
    [Guid("29038f61-3839-4626-91fd-086879011a05"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIAdapter1 : IDXGIAdapter
    {
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
        int GetDesc1(out DXGIAdapterDescription1 adapterDesc1);
    }
}