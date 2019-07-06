#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Luid
    {
        public uint LowPart;
        public int HighPart;

        public Luid(uint lowPart, int highPart)
        {
            LowPart = lowPart;
            HighPart = highPart;
        }
    }
}