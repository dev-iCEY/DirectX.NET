#region Usings

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies if an adapter is local or remote.
    /// </summary>
    /// <remarks>
    ///     The <seealso cref="DXGIAdapterFlag" /> enumerated type is used by the Flags member of the
    ///     <seealso cref="DXGIAdapterDescription1" /> structure to identify the type of DXGI adapter.
    /// </remarks>
    [Flags]
    public enum DXGIAdapterFlag : uint
    {
        /// <summary>
        ///     Specifies no flags.
        /// </summary>
        None = 0,

        /// <summary>
        ///     Value always set to 0.
        /// </summary>
        Remote = 1,

        /// <summary>
        /// </summary>
        Software = 2
    }
}