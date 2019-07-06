#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SwapChainDesc
    {
        public ModeDesc BufferDesc;
        public SampleDesc SampleDesc;
        public Usage BufferUsage;
        public uint BufferCount;
        public IntPtr OutputWindow;
        [MarshalAs(UnmanagedType.Bool)] public bool Windowed;
        public SwapEffect SwapEffect;
        public SwapChainFlag Flags;

        public SwapChainDesc(ModeDesc bufferDesc, SampleDesc sampleDesc, Usage bufferUsage, uint bufferCount,
            IntPtr outputWindow, bool windowed, SwapEffect swapEffect, SwapChainFlag flags)
        {
            BufferDesc = bufferDesc;
            SampleDesc = sampleDesc;
            BufferUsage = bufferUsage;
            BufferCount = bufferCount;
            OutputWindow = outputWindow;
            Windowed = windowed;
            SwapEffect = swapEffect;
            Flags = flags;
        }
    }
}