#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes an adapter (or video card) by using DXGI 1.0.
    /// </summary>
    /// <remarks>
    ///     The <seealso cref="DXGIAdapterDescription" /> structure provides a description of an adapter. This structure is
    ///     initialized by using the <seealso cref="T:IDXGIAdapter.GetDesc" /> method.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode),
     SuppressMessage("ReSharper", "InconsistentNaming"),
     SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public readonly ref struct DXGIAdapterDescription
    {
        /// <summary>
        ///     A string that contains the adapter description.
        /// </summary>
        [field: MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Description { get; }

        /// <summary>
        ///     The PCI ID of the hardware vendor.
        /// </summary>
        public uint VendorId { get; }

        /// <summary>
        ///     The PCI ID of the hardware device.
        /// </summary>
        public uint DeviceId { get; }

        /// <summary>
        ///     The PCI ID of the sub system.
        /// </summary>
        public uint SubSysId { get; }

        /// <summary>
        ///     The PCI ID of the revision number of the adapter.
        /// </summary>
        public uint Revision { get; }

        /// <summary>
        ///     The number of bytes of dedicated video memory that are not shared with the CPU.
        /// </summary>
        public UIntPtr DedicatedVideoMemory { get; }

        /// <summary>
        ///     The number of bytes of dedicated system memory that are not shared with the GPU. This memory is allocated from
        ///     available system memory at boot time.
        /// </summary>
        public UIntPtr DedicatedSystemMemory { get; }

        /// <summary>
        ///     The number of bytes of shared system memory. This is the maximum value of system memory that may be consumed by the
        ///     adapter during operation. Any incidental memory consumed by the driver as it manages and uses video memory is
        ///     additional.
        /// </summary>
        public UIntPtr SharedSystemMemory { get; }

        /// <summary>
        ///     A unique value that identifies the adapter. See LUID for a definition of the structure. LUID is defined in dxgi.h.
        /// </summary>
        public Luid AdapterLuid { get; }
    }
}