#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct LargeInteger
    {
        /// <summary>
        ///     The quad part
        /// </summary>
        [FieldOffset(0)] public long QuadPart;

        /// <summary>
        ///     The low part
        /// </summary>
        [FieldOffset(0)] public uint LowPart;

        /// <summary>
        ///     The high part
        /// </summary>
        [FieldOffset(4)] public int HighPart;
    }
}