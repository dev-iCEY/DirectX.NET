#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FrameStatistics
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public LargeInteger SyncQPCTime;
        public LargeInteger SyncGPUTime;

        public FrameStatistics(uint presentCount, uint presentRefreshCount, uint syncRefreshCount,
            LargeInteger syncQpcTime, LargeInteger syncGpuTime)
        {
            PresentCount = presentCount;
            PresentRefreshCount = presentRefreshCount;
            SyncRefreshCount = syncRefreshCount;
            SyncQPCTime = syncQpcTime;
            SyncGPUTime = syncGpuTime;
        }
    }
}