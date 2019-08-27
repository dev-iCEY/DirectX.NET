#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     ???
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        /// <summary>
        ///     Gets or sets the length.
        /// </summary>
        /// <value>
        ///     The length.
        /// </value>
        public uint Length { get; set; }

        /// <summary>
        ///     Gets or sets the security descriptor.
        /// </summary>
        /// <value>
        ///     The security descriptor.
        /// </value>
        public IntPtr SecurityDescriptor { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [inherit handle].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [inherit handle]; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool InheritHandle { get; set; }
    }
}