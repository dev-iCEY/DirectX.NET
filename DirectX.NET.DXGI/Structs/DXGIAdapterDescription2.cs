#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes an adapter (or video card) that uses Microsoft DirectX Graphics Infrastructure (DXGI) 1.2.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct DXGIAdapterDescription2
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

        /// <summary>
        ///     A member of the <seealso cref="DXGIAdapterFlag" /> enumerated type that describes the adapter type. The
        ///     <seealso cref="DXGIAdapterFlag.Remote" /> flag specifies that the adapter is a remote adapter.
        /// </summary>
        public DXGIAdapterFlag Flags { get; }

        /// <summary>
        ///     A value of the <see cref="DXGIGraphicsPreemptionGranularity" /> enumerated type that describes the granularity
        ///     level at which
        ///     the GPU can be preempted from performing its current graphics rendering task.
        /// </summary>
        /// <value>
        ///     The graphics preemption granularity.
        /// </value>
        public DXGIGraphicsPreemptionGranularity GraphicsPreemptionGranularity { get; }

        /// <summary>
        ///     A value of the <see cref="DXGIComputePreemptionGranularity" /> enumerated type that describes the granularity level
        ///     at which the GPU can be preempted from performing its current compute task.
        /// </summary>
        /// <value>
        ///     The compute preemption granularity.
        /// </value>
        public DXGIComputePreemptionGranularity ComputePreemptionGranularity { get; }
    }
}