#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct AdapterDescription1
    {
        [field: MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Description { get; set; }
        public uint VendorId { get; set; }
        public uint DeviceId { get; set; }
        public uint SubSysId { get; set; }
        public uint Revision { get; set; }
        public UIntPtr DedicatedVideoMemory { get; set; }
        public UIntPtr DedicatedSystemMemory { get; set; }
        public UIntPtr SharedSystemMemory { get; set; }
        public Luid AdapterLuid { get; set; }
        public AdapterFlag Flags { get; set; }
    }
}