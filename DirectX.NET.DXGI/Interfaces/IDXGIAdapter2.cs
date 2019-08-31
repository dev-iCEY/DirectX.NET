#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <see cref="IDXGIAdapter2" /> interface represents a display subsystem, which includes one or more GPUs, DACs,
    ///     and video memory.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIAdapter1" />
    [Guid("0AA1AE0A-FA0E-4B84-8644-E05FF8E5ACB5"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIAdapter2 : IDXGIAdapter1
    {
        /// <summary>
        ///     Gets a Microsoft DirectX Graphics Infrastructure (DXGI) 1.2 description of an adapter or video card.
        /// </summary>
        /// <param name="adapterDescription">The adapter description.</param>
        /// <returns></returns>
        int GetDesc2(out DXGIAdapterDescription2 adapterDescription);
    }
}