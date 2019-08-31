#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Luid
    {
        /// <summary>
        ///     The low part
        /// </summary>
        public uint LowPart;

        /// <summary>
        ///     The high part
        /// </summary>
        public int HighPart;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Luid" /> struct.
        /// </summary>
        /// <param name="lowPart">The low part.</param>
        /// <param name="highPart">The high part.</param>
        public Luid(uint lowPart, int highPart)
        {
            LowPart = lowPart;
            HighPart = highPart;
        }
    }
}