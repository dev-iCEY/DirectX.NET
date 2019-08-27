#region Usings

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     CPU Access Level
    /// </summary>
    [Flags,
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGICpuAccess : uint
    {
        /// <summary>
        ///     The none
        /// </summary>
        None = 0,

        /// <summary>
        ///     The dynamic
        /// </summary>
        Dynamic = 1,

        /// <summary>
        ///     The read write
        /// </summary>
        ReadWrite = 2,

        /// <summary>
        ///     The scratch
        /// </summary>
        Scratch = 3,

        /// <summary>
        ///     The field
        /// </summary>
        Field = 15
    }
}