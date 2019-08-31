#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Represents a keyed mutex, which allows exclusive access to a shared resource that is used by multiple devices.
    /// </summary>
    /// <seealso cref="DXGIDeviceSubObject" />
    /// <seealso cref="IDXGIKeyedMutex" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIKeyedMutex : DXGIDeviceSubObject, IDXGIKeyedMutex
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIKeyedMutex).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIKeyedMutex" /> class from unmanaged pointer to
        ///     <seealso cref="IDXGIKeyedMutex" /> object.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIKeyedMutex(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Using a key, acquires exclusive rendering access to a shared resource.
        /// </summary>
        /// <param name="key">
        ///     A value that indicates which device to give access to. This method will succeed when the device that currently owns
        ///     the surface calls the <seealso cref="IDXGIKeyedMutex.ReleaseSync" /> method using the same value. This value can be
        ///     any <seealso langword="ulong" /> value.
        /// </param>
        /// <param name="milliseconds">
        ///     The time-out interval, in milliseconds. This method will return if the interval elapses, and the keyed mutex has
        ///     not been released using the specified Key. If this value is set to zero, the AcquireSync method will test to see if
        ///     the keyed mutex has been released and returns immediately. If this value is set to INFINITE, the time-out interval
        ///     will never elapse.
        /// </param>
        /// <returns></returns>
        public int AcquireSync(ulong key, uint milliseconds)
        {
            return GetMethodDelegate<AcquireSyncDelegate>().Invoke(this, key, milliseconds);
        }

        /// <summary>
        ///     Using a key, releases exclusive rendering access to a shared resource.
        /// </summary>
        /// <param name="key">
        ///     A value that indicates which device to give access to. This method will succeed when the device that currently owns
        ///     the surface calls the <seealso cref="IDXGIKeyedMutex.ReleaseSync" /> method using the same value. This value can be
        ///     any <seealso langword="ulong" /> value.
        /// </param>
        /// <returns></returns>
        public int ReleaseSync(ulong key)
        {
            return GetMethodDelegate<ReleaseSyncDelegate>().Invoke(this, key);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AcquireSyncDelegate(IntPtr thisPtr, ulong key, uint ms);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseSyncDelegate(IntPtr thisPtr, ulong key);
    }
}