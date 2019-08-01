#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     The <see cref="IDXGIAdapter" /> interface represents a display sub-system (including one or more GPU's, DACs and
    ///     video memory).
    /// </summary>
    /// <remarks>
    ///     A display sub-system is often referred to as a video card, however, on some machines the display sub-system is part
    ///     of the mother board.
    ///     To enumerate the display sub-systems, use <seealso cref="IDXGIFactory.EnumAdapters" />.
    ///     To get an interface to the adapter for a particular device, use <seealso cref="IDXGIDevice.GetAdapter" />.
    ///     To create a software adapter, use <seealso cref="IDXGIFactory.CreateSoftwareAdapter" />.
    /// </remarks>
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIAdapter : IDXGIObject
    {
        int EnumOutputs(uint outputIndex, out IDXGIOutput output);

        /// <summary>
        ///     Gets a DXGI 1.0 description of an adapter (or video card).
        /// </summary>
        /// <param name="desc">A pointer to a <seealso cref="AdapterDescription" /> structure that describes the adapter.</param>
        int GetDesc(out AdapterDescription desc);

        int CheckInterfaceSupport(in Guid interfaceName, out LargeInteger pUmdVersion);
    }
}