#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SampleDesc
    {
        public uint Count;
        public uint Quality;

        public SampleDesc(uint count, uint quality)
        {
            Count = count;
            Quality = quality;
        }
    }
}