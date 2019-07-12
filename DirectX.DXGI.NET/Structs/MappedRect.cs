#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MappedRect
    {
        public int Pitch { get; set; }
        public IntPtr Bits { get; set; }
    }
}