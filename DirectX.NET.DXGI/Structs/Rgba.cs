#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGIRgba
    {
        /// <summary>
        ///     Gets or sets the red.
        /// </summary>
        /// <value>
        ///     The red.
        /// </value>
        public float Red { get; set; }

        /// <summary>
        ///     Gets or sets the green.
        /// </summary>
        /// <value>
        ///     The green.
        /// </value>
        public float Green { get; set; }

        /// <summary>
        ///     Gets or sets the blue.
        /// </summary>
        /// <value>
        ///     The blue.
        /// </value>
        public float Blue { get; set; }

        /// <summary>
        ///     Gets or sets the alpha.
        /// </summary>
        /// <value>
        ///     The alpha.
        /// </value>
        public float Alpha { get; set; }
    }
}