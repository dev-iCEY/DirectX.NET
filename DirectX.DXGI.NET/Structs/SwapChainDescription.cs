#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SwapChainDescription
    {
        public ModeDescription BufferDesc { get; set; }
        public SampleDescription SampleDesc { get; set; }
        public Usage BufferUsage { get; set; }
        public uint BufferCount { get; set; }
        public IntPtr OutputWindow { get; set; }

        [field: MarshalAs(UnmanagedType.Bool)]
        public bool Windowed { get; set; }
        public SwapEffect SwapEffect { get; set; }
        public SwapChainFlag Flags { get; set; }
    }
}