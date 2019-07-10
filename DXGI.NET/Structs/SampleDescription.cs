#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SampleDescription
    {
        public uint Count { get; set; }
        public uint Quality { get; set; }
    }
}