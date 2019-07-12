#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        public uint Length { get; set; }

        public IntPtr SecurityDescriptor { get; set; }

        [field: MarshalAs(UnmanagedType.Bool)]
        public bool InheritHandle { get; set; }
    }
}