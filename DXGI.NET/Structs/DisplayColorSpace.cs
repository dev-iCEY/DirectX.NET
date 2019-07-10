#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayColorSpace
    {
        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 16)]
        public float[][] PrimaryCoordinates { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 32)]
        public float[][] WhitePoints { get; set; }
    }
}