#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_3
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FrameStatisticsMedia
    {
        public uint PresentCount { get; set; }
        public uint PresentRefreshCount { get; set; }
        public uint SyncRefreshCount { get; set; }
        public LargeInteger SyncQpcTime { get; set; }
        public LargeInteger SyncGpuTime { get; set; }
        public FramePresentationMode CompositionMode { get; set; }
        public uint ApprovedPresentDuration { get; set; }
    }
}