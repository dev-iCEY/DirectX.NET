#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AdapterDesc1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public readonly ushort[] Description;

        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;

        public UIntPtr DedicatedVideoMemory;
        public UIntPtr DedicatedSystemMemory;
        public UIntPtr SharedSystemMemory;

        public Luid AdapterLuid;

        public AdapterFlag Flags;

        public string HumanDescription => new string(Description.ToCharArray());
    }
}