#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rgb
    {
        public float Red;
        public float Green;
        public float Blue;

        public Rgb(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}