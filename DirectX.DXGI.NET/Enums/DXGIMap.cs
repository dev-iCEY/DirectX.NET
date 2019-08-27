#region Usings

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     CPU read-write flags. These flags can be combined with a logical OR.
    /// </summary>
    [Flags,
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIMap : uint
    {
        /// <summary>
        ///     The readAllow CPU read access.
        /// </summary>
        Read = 1U,

        /// <summary>
        ///     Allow CPU write access.
        /// </summary>
        Write = 2U,

        /// <summary>
        ///     Discard the previous contents of a resource when it is mapped.
        /// </summary>
        Discard = 4U
    }
}