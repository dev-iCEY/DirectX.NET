#region Usings

using System;
using System.Linq;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDesc
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public readonly ushort[] DeviceName;

        public Rect DesktopCoordinates;
        [MarshalAs(UnmanagedType.Bool)] public bool AttachedToDesktop;
        public ModeRotation Rotation;
        public IntPtr Monitor;

        public OutputDesc(ushort[] deviceName, Rect desktopCoordinates, bool attachedToDesktop, ModeRotation rotation,
            IntPtr monitor)
        {
            DeviceName = deviceName;
            DesktopCoordinates = desktopCoordinates;
            AttachedToDesktop = attachedToDesktop;
            Rotation = rotation;
            Monitor = monitor;
        }

        public string HumanDeviceName => new string(DeviceName.ToCharArray());
    }
}