#region Usings

using System;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The requested access rights to the resource.
    /// </summary>
    [Flags]
    public enum DXGISharedResourceAccess : uint
    {
        /// <summary>
        ///     specifies read access to the resource.
        /// </summary>
        Read = 0x80000000u,

        /// <summary>
        ///     specifies write access to the resource.
        /// </summary>
        Write = 1
    }
}