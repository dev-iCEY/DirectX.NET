#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <seealso cref="DXGIOutDuplDescription" /> structure describes the dimension of
    ///     the output and the surface that contains the desktop image.
    ///     The format of the desktop image is always <seealso cref="DXGIFormat.B8G8R8A8UNorm" />
    /// </summary>
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "InconsistentNaming"),
     SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public readonly struct DXGIOutDuplDescription
    {
        /// <summary>
        ///     A <seealso cref="DXGIModeDescription" /> structure that describes the display mode of the duplicated output.
        /// </summary>
        /// <value>
        ///     The mode description.
        /// </value>
        public DXGIModeDescription ModeDescription { get; }

        /// <summary>
        ///     A member of the <seealso cref="DXGIModeRotation" /> enumerated type that describes how the duplicated output
        ///     rotates an image.
        /// </summary>
        /// <value>
        ///     The rotation.
        /// </value>
        public DXGIModeRotation Rotation { get; }

        /// <summary>
        ///     Specifies whether the resource that contains the desktop image is already located in system memory.
        ///     <seealso langword="true" /> if the
        ///     resource is in system memory; otherwise, <seealso langword="false" />. If this value is <seealso langword="true" />
        ///     and the application requires CPU access, it
        ///     can use the <seealso cref="IDXGIOutputDuplication.MapDesktopSurface" /> and
        ///     <seealso cref="IDXGIOutputDuplication.UnMapDesktopSurface" /> methods to
        ///     avoid copying the data into a staging buffer.
        /// </summary>
        /// <value>
        ///     <c>true</c> if [desktop image in system memory]; otherwise, <c>false</c>.
        /// </value>
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool DesktopImageInSystemMemory { get; }
    }
}