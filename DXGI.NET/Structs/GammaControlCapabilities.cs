#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GammaControlCapabilities
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool ScaleAndOffsetSupported;
        public float MaxConvertedValue;
        public float MinConvertedValue;
        public uint NumGammaControlPoints;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public readonly float[] ControlPointPositions;

        public GammaControlCapabilities(bool scaleAndOffsetSupported, float maxConvertedValue, float minConvertedValue,
            uint numGammaControlPoints, float[] controlPointPositions)
        {
            ScaleAndOffsetSupported = scaleAndOffsetSupported;
            MaxConvertedValue = maxConvertedValue;
            MinConvertedValue = minConvertedValue;
            NumGammaControlPoints = numGammaControlPoints;
            ControlPointPositions = controlPointPositions;
        }
    }
}