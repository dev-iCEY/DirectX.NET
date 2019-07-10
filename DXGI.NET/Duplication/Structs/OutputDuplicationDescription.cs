#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Duplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDuplicationDescription
    {
        public ModeDescription ModeDescription { get; set; }

        public ModeRotation Rotation { get; set; }

        [field: MarshalAs(UnmanagedType.Bool)] public bool DesktopImageInSystemMemory { get; set; }

        public OutputDuplicationDescription(ModeDescription modeDescription, ModeRotation rotation,
            bool desktopImageInSystemMemory)
        {
            ModeDescription = modeDescription;
            Rotation = rotation;
            DesktopImageInSystemMemory = desktopImageInSystemMemory;
        }
    }
}