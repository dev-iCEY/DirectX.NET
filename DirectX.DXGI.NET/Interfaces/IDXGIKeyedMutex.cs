#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     Represents a keyed mutex, which allows exclusive access to a shared resource that is used by multiple devices.
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIDeviceSubObject" />
    [Guid("9d8e1289-d7b3-465f-8126-250e349af85d"),
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIKeyedMutex : IDXGIDeviceSubObject
    {
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
        int AcquireSync(ulong key, uint milliseconds);

        /// <summary>
        ///     Using a key, releases exclusive rendering access to a shared resource.
        /// </summary>
        /// <param name="key">
        ///     A value that indicates which device to give access to. This method will succeed when the device that currently owns
        ///     the surface calls the <seealso cref="IDXGIKeyedMutex.ReleaseSync" /> method using the same value. This value can be
        ///     any <seealso langword="ulong" /> value.
        /// </param>
        /// <returns></returns>
        int ReleaseSync(ulong key);
    }
}