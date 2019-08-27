#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     An <seealso cref="IDXGIDevice1" /> interface implements a derived class for DXGI objects that produce image data.
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIDevice" />
    [Guid("77db970f-6276-48ba-ba28-070143b4392c"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIDevice1 : IDXGIDevice
    {
        /// <summary>
        ///     Sets the number of frames that the system is allowed to queue for rendering.
        /// </summary>
        /// <param name="maxLatency">
        ///     The maximum number of back buffer frames that a driver can queue. The value defaults to 3, but
        ///     can range from 1 to 16. A value of 0 will reset latency to the default. For multi-head devices, this value is
        ///     specified per-head.
        /// </param>
        /// <returns></returns>
        int SetMaximumFrameLatency(uint maxLatency);

        /// <summary>
        ///     Gets the number of frames that the system is allowed to queue for rendering.
        /// </summary>
        /// <param name="maxLatency">
        ///     This value is set to the number of frames that can be queued for render. This value defaults
        ///     to 3, but can range from 1 to 16.
        /// </param>
        /// <returns>
        ///     Returns S_OK if successful; otherwise, returns one of the following members of the D3DERR enumerated type:
        ///     <list type="bullet">
        ///         <listheader>
        ///             <term>term</term>
        ///             <description>D3DERR enumerated type:</description>
        ///         </listheader>
        ///         <item>D3DERR_DEVICELOST</item>
        ///         <item>D3DERR_DEVICEREMOVED</item>
        ///         <item>D3DERR_DRIVERINTERNALERROR</item>
        ///         <item>D3DERR_INVALIDCALL</item>
        ///         <item>D3DERR_OUTOFVIDEOMEMORY</item>
        ///     </list>
        /// </returns>
        int GetMaximumFrameLatency(out uint maxLatency);
    }
}