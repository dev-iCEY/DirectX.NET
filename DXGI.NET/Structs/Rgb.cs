#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rgb
    {
        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }
    }
}
