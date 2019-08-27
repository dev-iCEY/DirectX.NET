#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     Inherited from objects that are tied to the device so that they can retrieve a pointer to it.
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIObject" />
    [Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIDeviceSubObject : IDXGIObject
    {
        /// <summary>
        ///     Retrieves the device.
        /// </summary>
        /// <param name="riid">The reference id for the device.</param>
        /// <param name="device">The object to the device.</param>
        /// <returns></returns>
        /// <remarks>
        ///     The type of interface that is returned can be any interface published by the device. For example, it could be an
        ///     IDXGIDevice * called pDevice, and therefore the REFIID would be obtained by calling __uuidof(pDevice).
        /// </remarks>
        int GetDevice(in Guid riid, out IUnknown device);
    }
}