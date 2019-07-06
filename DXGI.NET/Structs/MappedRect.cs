#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MappedRect
    {
        public int Pitch;
        public IntPtr Bits;

        public MappedRect(int pitch, IntPtr bits)
        {
            Pitch = pitch;
            Bits = bits;
        }
    }
}