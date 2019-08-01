#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public ref struct AdapterDescription
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public readonly string Description;

        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;

        public UIntPtr DedicatedVideoMemory;
        public UIntPtr DedicatedSystemMemory;
        public UIntPtr SharedSystemMemory;

        public Luid AdapterLuid;
    }
}