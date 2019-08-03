#region Usings

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Flags for surface and resource creation options.
    /// </summary>
    [Flags]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIUsage : uint
    {
        /// <summary>
        ///     Use the surface or resource as an input to a shader.
        /// </summary>
        ShaderInput = (uint) 0x00000010UL,

        /// <summary>
        ///     Use the surface or resource as an output render target.
        /// </summary>
        RenderTargetOutput = (uint) 0x00000020UL,

        /// <summary>
        ///     Use the surface or resource as a back buffer.
        /// </summary>
        BackBuffer = (uint) 0x00000040UL,

        /// <summary>
        ///     Share the surface or resource.
        /// </summary>
        Shared = (uint) 0x00000080UL,

        /// <summary>
        ///     Use the surface or resource for reading only.Use the surface or resource for reading only.
        /// </summary>
        ReadOnly = (uint) 0x00000100UL,

        /// <summary>
        ///     This flag is for internal use only.
        /// </summary>
        DiscardOnPresent = (uint) 0x00000200UL,

        /// <summary>
        ///     Use the surface or resource for unordered access.
        /// </summary>
        UnorderedAccess = (uint) 0x00000400UL
    }
}