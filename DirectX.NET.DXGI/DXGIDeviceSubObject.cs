#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    /// <seealso cref="DXGIObject" />
    /// <seealso cref="IDXGIDeviceSubObject" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIDeviceSubObject : DXGIObject, IDXGIDeviceSubObject
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 1u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIDeviceSubObject).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIDeviceSubObject" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIDeviceSubObject(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Retrieves the device.
        /// </summary>
        /// <param name="riid">The reference id for the device.</param>
        /// <param name="device">The object to the device.</param>
        /// <returns></returns>
        /// <remarks>
        ///     The type of interface that is returned can be any interface published by the device. For example, it could be an
        ///     IDXGIDevice * called pDevice, and therefore the REFIID would be obtained by calling __uuidof(pDevice).
        /// </remarks>
        public int GetDevice(in Guid riid, out IUnknown device)
        {
            int result = GetMethodDelegate<GetDeviceDelegate>().Invoke(this, in riid, out IntPtr devicePtr);
            device = result == 0 ? new Unknown(devicePtr) : null;
            return result;
        }

        [ComMethodId(DXGIObject.LastMethodId + 1), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDeviceDelegate(IntPtr thisPtr, in Guid riid, out IntPtr devicePtr);
    }
}