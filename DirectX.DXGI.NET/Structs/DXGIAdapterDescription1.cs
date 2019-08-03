#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes an adapter (or video card) using DXGI 1.1.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), SuppressMessage("ReSharper", "InconsistentNaming")]
    public ref struct DXGIAdapterDescription1
    {
        /// <summary>
        ///     A string that contains the adapter description.
        /// </summary>
        [field: MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Description { get; set; }

        /// <summary>
        ///     The PCI ID of the hardware vendor.
        /// </summary>
        public uint VendorId { get; set; }

        /// <summary>
        ///     The PCI ID of the hardware device.
        /// </summary>
        public uint DeviceId { get; set; }

        /// <summary>
        ///     The PCI ID of the sub system.
        /// </summary>
        public uint SubSysId { get; set; }

        /// <summary>
        ///     The PCI ID of the revision number of the adapter.
        /// </summary>
        public uint Revision { get; set; }

        /// <summary>
        ///     The number of bytes of dedicated video memory that are not shared with the CPU.
        /// </summary>
        public UIntPtr DedicatedVideoMemory { get; set; }

        /// <summary>
        ///     The number of bytes of dedicated system memory that are not shared with the GPU. This memory is allocated from
        ///     available system memory at boot time.
        /// </summary>
        public UIntPtr DedicatedSystemMemory { get; set; }

        /// <summary>
        ///     The number of bytes of shared system memory. This is the maximum value of system memory that may be consumed by the
        ///     adapter during operation. Any incidental memory consumed by the driver as it manages and uses video memory is
        ///     additional.
        /// </summary>
        public UIntPtr SharedSystemMemory { get; set; }

        /// <summary>
        ///     A unique value that identifies the adapter. See LUID for a definition of the structure. LUID is defined in dxgi.h.
        /// </summary>
        public Luid AdapterLuid { get; set; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIAdapterFlag" /> enumerated type that describes the adapter type. The
        ///     <seealso cref="DXGIAdapterFlag.Remote"/> flag specifies that the adapter is a remote adapter.
        /// </summary>
        public DXGIAdapterFlag Flags { get; set; }
    }
}