#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.Direct2D.Interfaces
{
    /// <summary>
    ///     The root factory interface for all of D2D's objects.
    /// </summary>
    [Guid("06152247-6f50-465a-9245-118bfd3b6007")]
    public interface IFactory : IUnknown
    {
        /// <summary>
        ///     Cause the factory to refresh any system metrics that it might have been snapped on factory creation.
        /// </summary>
        int ReloadSystemMetrics();

        /// <summary>
        ///     Retrieves the current desktop DPI. To refresh this, call ReloadSystemMetrics.
        /// </summary>
        [Obsolete("Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps.", false)]
        void GetDesktopDpi(out float dpiX, out float dpiY);

        // FIXME: !!! Continue HERE !!!
    }
}