#region Usings

using System;
using System.Linq;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct OutputDescription
    {
        [field: MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName { get; set; }

        public Rect DesktopCoordinates { get; set; }

        [field: MarshalAs(UnmanagedType.Bool)]
        public bool AttachedToDesktop { get; set; }

        public ModeRotation Rotation { get; set; }

        public IntPtr Monitor { get; set; }
    }
}