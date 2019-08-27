#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Describes timing and presentation statistics for a frame.
    /// </summary>
    [StructLayout(LayoutKind.Sequential),
     SuppressMessage("ReSharper", "InconsistentNaming"),
     SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public readonly ref struct DXGIFrameStatistics
    {
        /// <summary>
        ///     A value representing the running total count of times that an image has been presented to the monitor since the
        ///     computer booted. Note that the number of times that an image has been presented to the monitor is not necessarily
        ///     the same as the number of times that <seealso cref="IDXGISwapChain.Present" /> has been called.
        /// </summary>
        public uint PresentCount { get; }

        /// <summary>
        ///     A value representing the running total count of v-blanks that have happened since the computer booted.
        /// </summary>
        public uint PresentRefreshCount { get; }

        /// <summary>
        ///     A value representing the running total count of v-blanks that have happened since the computer booted.
        /// </summary>
        public uint SyncRefreshCount { get; }

        /// <summary>
        ///     A value representing the high-resolution performance counter timer. This value is the same as the value returned by
        ///     the QueryPerformanceCounter function.
        /// </summary>
        public LargeInteger SyncQpcTime { get; }

        /// <summary>
        ///     Reserved. Always returns 0.
        /// </summary>
        public LargeInteger SyncGpuTime { get; }
    }
}