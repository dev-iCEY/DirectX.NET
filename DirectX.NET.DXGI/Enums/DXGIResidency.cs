#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Flags indicating the memory location of a resource.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIResidency : uint
    {
        /// <summary>
        ///     The resource is located in video memory.
        /// </summary>
        FullyResident = 1,

        /// <summary>
        ///     At least some of the resource is located in CPU memory.
        /// </summary>
        ResidentInSharedMemory = 2,

        /// <summary>
        ///     At least some of the resource has been paged out to the hard drive.
        /// </summary>
        EvictedToDisk = 3
    }
}