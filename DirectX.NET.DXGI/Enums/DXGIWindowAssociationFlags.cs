#region Usings

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    [Flags,
     SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIWindowAssociationFlags : uint
    {
        /// <summary>
        ///     Prevent DXGI from monitoring an applications message queue; this makes DXGI unable to respond to mode changes.
        /// </summary>
        NoWindowChanges = 1,

        /// <summary>
        ///     The no alt enterPrevent DXGI from responding to an alt-enter sequence.
        /// </summary>
        NoAltEnter = 1 << 1,

        /// <summary>
        ///     The no print screen Prevent DXGI from responding to a print-screen key.
        /// </summary>
        NoPrintScreen = 1 << 2,

        /// <summary>
        ///     The valid
        /// </summary>
        Valid = 0x7
    }
}