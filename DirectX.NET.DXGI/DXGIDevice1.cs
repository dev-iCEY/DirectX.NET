#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An IDXGIDevice1 interface implements a derived class for DXGI objects that produce image data.
    /// </summary>
    /// <seealso cref="DXGIDevice" />
    /// <seealso cref="IDXGIDevice1" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIDevice1 : DXGIDevice, IDXGIDevice1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDevice.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIDevice1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIDevice1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIDevice1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Sets the number of frames that the system is allowed to queue for rendering.
        /// </summary>
        /// <param name="maxLatency">
        ///     The maximum number of back buffer frames that a driver can queue. The value defaults to 3, but
        ///     can range from 1 to 16. A value of 0 will reset latency to the default. For multi-head devices, this value is
        ///     specified per-head.
        /// </param>
        /// <returns></returns>
        public int SetMaximumFrameLatency(uint maxLatency)
        {
            return GetMethodDelegate<SetMaximumFrameLatencyDelegate>().Invoke(this, maxLatency);
        }

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
        ///             <term>term</term><description>D3DERR enumerated type:</description>
        ///         </listheader>
        ///         <item>D3DERR_DEVICELOST</item><item>D3DERR_DEVICEREMOVED</item><item>D3DERR_DRIVERINTERNALERROR</item>
        ///         <item>D3DERR_INVALIDCALL</item><item>D3DERR_OUTOFVIDEOMEMORY</item>
        ///     </list>
        /// </returns>
        public int GetMaximumFrameLatency(out uint maxLatency)
        {
            return GetMethodDelegate<GetMaximumFrameLatencyDelegate>().Invoke(this, out maxLatency);
        }

        [ComMethodId(DXGIDevice.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetMaximumFrameLatencyDelegate(IntPtr thisPtr, uint maxLatency);

        [ComMethodId(DXGIDevice.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetMaximumFrameLatencyDelegate(IntPtr thisPtr, out uint maxLatency);
    }
}