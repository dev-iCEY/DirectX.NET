#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Represents a handle to a shared resource.
    /// </summary>
    /// <remarks>
    ///     To create a shared surface, pass a shared-resource handle into the <seealso cref="IDXGIDevice.CreateSurface" />
    ///     method.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming")]
    public struct DXGISharedResource

    {
        /// <summary>
        ///     A handle to a shared resource.
        /// </summary>
        public IntPtr Handle { get; set; }
    }
}