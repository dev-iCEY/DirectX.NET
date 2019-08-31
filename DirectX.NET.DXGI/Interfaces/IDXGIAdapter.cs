#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI.Interfaces
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
        /// <summary>
        ///     Enumerate adapter (video card) outputs.
        /// </summary>
        /// <param name="outputIndex">The index of the output.</param>
        /// <param name="output">The object to an output (see <seealso cref="IDXGIOutput" />).</param>
        /// <returns></returns>
        int EnumOutputs(uint outputIndex, out IDXGIOutput output);

        /// <summary>
        ///     Gets a DXGI 1.0 description of an adapter (or video card).
        /// </summary>
        /// <param name="desc">A pointer to a <seealso cref="DXGIAdapterDescription" /> structure that describes the adapter.</param>
        int GetDesc(out DXGIAdapterDescription desc);

        /// <summary>
        /// Checks to see if a device interface for a graphics component is supported by the system. 
        /// </summary>
        /// <param name="interfaceName">The GUID of the interface of the device version for which support is being checked. For example,
        /// <example>
        /// <code>
        /// int c = Math.Add(4, 5);
        /// if (c &gt; 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example></param>
        /// <param name="pUmdVersion"></param>
        /// <returns></returns>
        int CheckInterfaceSupport(in Guid interfaceName, out LargeInteger pUmdVersion);
    }
}