#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayColorSpace
    {
        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 16)]
        public float[][] PrimaryCoodrinates { get; }

        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.ByValArray, SizeConst = 32)]
        public float[][] WhitePoints { get; }
    }
}