#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FrameStatistics
    {
        public uint PresentCount { get; set; }
        public uint PresentRefreshCount { get; set; }
        public uint SyncRefreshCount { get; set; }
        public LargeInteger SyncQpcTime { get; set; }
        public LargeInteger SyncGpuTime { get; set; }
    }
}