#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGIDisplayControl" /> interface exposes methods to indicate user preference for the operating
    ///     system's
    ///     stereoscopic 3D display behavior and to set stereoscopic 3D display status to enable or disable.
    /// </summary>
    /// <seealso cref="DirectX.NET.Interfaces.IUnknown" />
    /// <remarks>
    ///     We recommend that you not use <seealso cref="IDXGIDisplayControl" /> to query or set system-wide stereoscopic 3D
    ///     settings in your
    ///     stereoscopic 3D apps. Instead, for your windowed apps, call the
    ///     <seealso cref="IDXGIFactory2.IsWindowedStereoEnabled" /> method to
    ///     determine whether to render in stereo; for your full-screen apps, call the
    ///     <seealso cref="IDXGIOutput1.GetDisplayModeList1" /> method
    ///     and then determine whether any of the returned display modes support rendering in stereo.
    ///     Note: The <seealso cref="IDXGIDisplayControl" /> interface is only used by the Display app of the operating
    ///     system's Control
    ///     Panel or by control applets from third party graphics vendors. This interface is not meant for developers of
    ///     end-user apps.
    ///     <para>Note: The <seealso cref="IDXGIDisplayControl" /> interface does not exist for Windows Store apps.</para>
    ///     Call <seealso cref="IUnknown.QueryInterface" /> from a factory object (<seealso cref="IDXGIFactory" />,
    ///     <seealso cref="IDXGIFactory1" /> or <seealso cref="IDXGIFactory2" />) to retrieve the
    ///     <seealso cref="IDXGIDisplayControl" /> interface. The following code shows how.
    ///     <example>
    ///         <code>IDXGIDisplayControl displayControl;
    /// hr = dxgiFactory.QueryInterface(typeof(IDXGIDisplayControl).GUID, out displayControl);</code>
    ///     </example>
    ///     The operating system processes changes to stereo-enabled configuration asynchronously. Therefore, these changes
    ///     might not be immediately visible in every process that calls <seealso cref="IsStereoEnabled" /> to query for
    ///     stereo configuration. Control applets can use the <seealso cref="IDXGIFactory2.RegisterStereoStatusEvent" /> or
    ///     <seealso cref="IDXGIFactory2.RegisterStereoStatusWindow" /> method to register for notifications of all stereo
    ///     configuration changes.
    ///     Platform Update for Windows 7:  Stereoscopic 3D display behavior isn’t available with the Platform Update for
    ///     Windows 7. For more info about the Platform Update for Windows 7, see Platform Update for Windows 7.
    /// </remarks>
    [Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIDisplayControl : IUnknown
    {
        /// <summary>
        ///     Retrieves a Boolean value that indicates whether the operating system's stereoscopic 3D display behavior is
        ///     enabled.
        /// </summary>
        /// <returns>
        ///     <seealso cref="IsStereoEnabled" /> returns <seealso langword="true" /> when the operating system's stereoscopic 3D
        ///     display behavior is enabled and <seealso langword="false" /> when this behavior is disabled.
        /// </returns>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsStereoEnabled();

        /// <summary>
        ///     Set a Boolean value to either enable or disable the operating system's stereoscopic 3D display behavior.
        /// </summary>
        /// <param name="enabled">
        ///     A Boolean value that either enables or disables the operating system's stereoscopic 3D display
        ///     behavior. <seealso langword="true" /> enables the operating system's stereoscopic 3D display behavior and
        ///     <seealso langword="false" /> disables it.
        /// </param>
        /// <remarks>
        ///     Platform Update for Windows 7:  On Windows 7 or Windows Server 2008 R2 with the Platform Update for Windows 7
        ///     installed, SetStereoEnabled doesn't change stereoscopic 3D display behavior because stereoscopic 3D display
        ///     behavior isn’t available with the Platform Update for Windows 7. For more info about the Platform Update for
        ///     Windows 7, see Platform Update for Windows 7.
        /// </remarks>
        void SetStereoEnabled([MarshalAs(UnmanagedType.Bool)] bool enabled);
    }
}