#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     Resource data formats which includes fully-typed and typeless formats. There is a list of format modifiers at the
    ///     bottom of the page, that more fully describes each format type.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DXGIFormat : uint
    {
        /// <summary>
        ///     The format is not known.
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     A four-component, 128-bit typeless format.
        /// </summary>
        R32G32B32A32Typeless = 1,

        /// <summary>
        ///     A four-component, 128-bit floating-point format.
        /// </summary>
        R32G32B32A32Float = 2,

        /// <summary>
        ///     A four-component, 128-bit unsigned-integer format.
        /// </summary>
        R32G32B32A32Uint = 3,

        /// <summary>
        ///     A four-component, 128-bit signed-integer format.
        /// </summary>
        R32G32B32A32SInt = 4,

        /// <summary>
        ///     A three-component, 96-bit typeless format.
        /// </summary>
        R32G32B32Typeless = 5,

        /// <summary>
        ///     A three-component, 96-bit floating-point format.
        /// </summary>
        R32G32B32Float = 6,

        /// <summary>
        ///     A three-component, 96-bit unsigned-integer format.
        /// </summary>
        R32G32B32Uint = 7,

        /// <summary>
        ///     A three-component, 96-bit signed-integer format.
        /// </summary>
        R32G32B32SInt = 8,

        /// <summary>
        ///     A four-component, 64-bit typeless format.
        /// </summary>
        R16G16B16A16Typeless = 9,

        /// <summary>
        ///     A four-component, 64-bit floating-point format.
        /// </summary>
        R16G16B16A16Float = 10,

        /// <summary>
        ///     A four-component, 64-bit unsigned-integer format.
        /// </summary>
        R16G16B16A16UNorm = 11,

        /// <summary>
        ///     A four-component, 64-bit unsigned-integer format.
        /// </summary>
        R16G16B16A16Uint = 12,

        /// <summary>
        ///     A four-component, 64-bit signed-integer format.
        /// </summary>
        R16G16B16A16SNorm = 13,

        /// <summary>
        ///     A four-component, 64-bit signed-integer format.
        /// </summary>
        R16G16B16A16SInt = 14,

        /// <summary>
        ///     A two-component, 64-bit typeless format.
        /// </summary>
        R32G32Typeless = 15,

        /// <summary>
        ///     A two-component, 64-bit floating-point format.
        /// </summary>
        R32G32Float = 16,

        /// <summary>
        ///     A two-component, 64-bit unsigned-integer format.
        /// </summary>
        R32G32Uint = 17,

        /// <summary>
        ///     A two-component, 64-bit signed-integer format.
        /// </summary>
        R32G32SInt = 18,

        /// <summary>
        ///     A two-component, 64-bit typeless format.
        /// </summary>
        R32G8X24Typeless = 19,

        /// <summary>
        ///     A 32-bit floating-point component, and two unsigned-integer components (with an additional 32 bits).
        /// </summary>
        D32FloatS8X24Uint = 20,

        /// <summary>
        ///     A 32-bit floating-point component, and two typeless components (with an additional 32 bits).
        /// </summary>
        R32FloatX8X24Typeless = 21,

        /// <summary>
        ///     A 32-bit typeless component, and two unsigned-integer components (with an additional 32 bits).
        /// </summary>
        X32TypelessG8X24Uint = 22,

        /// <summary>
        ///     A four-component, 32-bit typeless format.
        /// </summary>
        R10G10B10A2Typeless = 23,

        /// <summary>
        ///     A four-component, 32-bit unsigned-integer format.
        /// </summary>
        R10G10B10A2UNorm = 24,

        /// <summary>
        ///     A four-component, 32-bit unsigned-integer format.
        /// </summary>
        R10G10B10A2Uint = 25,

        /// <summary>
        ///     Three partial-precision floating-point numbers encodeded into a single 32-bit value (a variant of s10e5). There are
        ///     no sign bits, and there is a 5-bit biased (15) exponent for each channel, 6-bit mantissa for R and G, and a 5-bit
        ///     mantissa for B, as shown in the following illustration.
        /// </summary>
        R11G11B10Float = 26,

        /// <summary>
        ///     A three-component, 32-bit typeless format.
        /// </summary>
        R8G8B8A8Typeless = 27,

        /// <summary>
        ///     A four-component, 32-bit unsigned-integer format.
        /// </summary>
        R8G8B8A8UNorm = 28,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized integer sRGB format.
        /// </summary>
        R8G8B8A8UNormSRgb = 29,

        /// <summary>
        ///     A four-component, 32-bit unsigned-integer format.
        /// </summary>
        R8G8B8A8Uint = 30,

        /// <summary>
        ///     A three-component, 32-bit signed-integer format.
        /// </summary>
        R8G8B8A8SNorm = 31,

        /// <summary>
        ///     A three-component, 32-bit signed-integer format.
        /// </summary>
        R8G8B8A8SInt = 32,

        /// <summary>
        ///     A two-component, 32-bit typeless format.
        /// </summary>
        R16G16Typeless = 33,

        /// <summary>
        ///     A two-component, 32-bit floating-point format.
        /// </summary>
        R16G16Float = 34,

        /// <summary>
        ///     A two-component, 32-bit unsigned-integer format.
        /// </summary>
        R16G16UNorm = 35,

        /// <summary>
        ///     A two-component, 32-bit unsigned-integer format.
        /// </summary>
        R16G16Uint = 36,

        /// <summary>
        ///     A two-component, 32-bit signed-integer format.
        /// </summary>
        R16G16SNorm = 37,

        /// <summary>
        ///     A two-component, 32-bit signed-integer format.
        /// </summary>
        R16G16SInt = 38,

        /// <summary>
        ///     A single-component, 32-bit typeless format.
        /// </summary>
        R32Typeless = 39,

        /// <summary>
        ///     A single-component, 32-bit floating-point format.
        /// </summary>
        D32Float = 40,

        /// <summary>
        ///     A single-component, 32-bit floating-point format.
        /// </summary>
        R32Float = 41,

        /// <summary>
        ///     A single-component, 32-bit unsigned-integer format.
        /// </summary>
        R32Uint = 42,

        /// <summary>
        ///     A single-component, 32-bit signed-integer format.
        /// </summary>
        R32SInt = 43,

        /// <summary>
        ///     A two-component, 32-bit typeless format.
        /// </summary>
        R24G8Typeless = 44,

        /// <summary>
        ///     A 32-bit z-buffer format that uses 24 bits for the depth channel and 8 bits for the stencil channel.
        /// </summary>
        D24UNormS8Uint = 45,

        /// <summary>
        ///     A 32-bit format, that contains a 24 bit, single-component, unsigned-normalized integer, with an additional typeless
        ///     8 bits.
        /// </summary>
        R24UNormX8Typeless = 46,

        /// <summary>
        ///     A 32-bit format, that contains a 24 bit, single-component, typeless format, with an additional 8 bit unsigned
        ///     integer component.
        /// </summary>
        X24TypelessG8Uint = 47,

        /// <summary>
        ///     A two-component, 16-bit typeless format.
        /// </summary>
        R8G8Typeless = 48,

        /// <summary>
        ///     A two-component, 16-bit unsigned-integer format.
        /// </summary>
        R8G8UNorm = 49,

        /// <summary>
        ///     A two-component, 16-bit unsigned-integer format.
        /// </summary>
        R8G8Uint = 50,

        /// <summary>
        ///     A two-component, 16-bit signed-integer format.
        /// </summary>
        R8G8SNorm = 51,

        /// <summary>
        ///     A two-component, 16-bit signed-integer format.
        /// </summary>
        R8G8SInt = 52,

        /// <summary>
        ///     A single-component, 16-bit typeless format.
        /// </summary>
        R16Typeless = 53,

        /// <summary>
        ///     A single-component, 16-bit floating-point format.
        /// </summary>
        R16Float = 54,

        /// <summary>
        ///     A single-component, 16-bit unsigned-normalized integer format.
        /// </summary>
        D16UNorm = 55,

        /// <summary>
        ///     A single-component, 16-bit unsigned-integer format.
        /// </summary>
        R16UNorm = 56,

        /// <summary>
        ///     A single-component, 16-bit unsigned-integer format.
        /// </summary>
        R16Uint = 57,

        /// <summary>
        ///     A single-component, 16-bit signed-integer format.
        /// </summary>
        R16SNorm = 58,

        /// <summary>
        ///     A single-component, 16-bit signed-integer format.
        /// </summary>
        R16SInt = 59,

        /// <summary>
        ///     A single-component, 8-bit typeless format.
        /// </summary>
        R8Typeless = 60,

        /// <summary>
        ///     A single-component, 8-bit unsigned-integer format.
        /// </summary>
        R8UNorm = 61,

        /// <summary>
        ///     A single-component, 8-bit unsigned-integer format.
        /// </summary>
        R8Uint = 62,

        /// <summary>
        ///     A single-component, 8-bit signed-integer format.
        /// </summary>
        R8SNorm = 63,

        /// <summary>
        ///     A single-component, 8-bit signed-integer format.
        /// </summary>
        R8SInt = 64,

        /// <summary>
        ///     A single-component, 8-bit unsigned-integer format.
        /// </summary>
        A8UNorm = 65,

        /// <summary>
        ///     A single-component, 1-bit unsigned-normalized integer format.
        /// </summary>
        R1UNorm = 66,

        /// <summary>
        ///     Three partial-precision floating-point numbers encoded into a single 32-bit value all sharing the same 5-bit
        ///     exponent (variant of s10e5). There is no sign bit, and there is a shared 5-bit biased (15) exponent and a 9-bit
        ///     mantissa for each channel, as shown in the following illustration.
        /// </summary>
        R9G9B9E5SharedExp = 67,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized integer format.
        /// </summary>
        R8G8B8G8UNorm = 68,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized integer format.
        /// </summary>
        G8R8G8B8UNorm = 69,

        /// <summary>
        ///     Four-component typeless block-compression format.
        /// </summary>
        Bc1Typeless = 70,

        /// <summary>
        ///     Four-component block-compression format.
        /// </summary>
        Bc1UNorm = 71,

        /// <summary>
        ///     Four-component block-compression format for sRGB data.
        /// </summary>
        Bc1UNormSRgb = 72,

        /// <summary>
        ///     Four-component typeless block-compression format.
        /// </summary>
        Bc2Typeless = 73,

        /// <summary>
        ///     Four-component block-compression format.
        /// </summary>
        Bc2UNorm = 74,

        /// <summary>
        ///     Four-component block-compression format for sRGB data.
        /// </summary>
        Bc2UNormSRgb = 75,

        /// <summary>
        ///     Four-component typeless block-compression format.
        /// </summary>
        Bc3Typeless = 76,

        /// <summary>
        ///     Four-component block-compression format.
        /// </summary>
        Bc3UNorm = 77,

        /// <summary>
        ///     Four-component block-compression format for sRGB data.
        /// </summary>
        Bc3UNormSRgb = 78,

        /// <summary>
        ///     One-component typeless block-compression format.
        /// </summary>
        Bc4Typeless = 79,

        /// <summary>
        ///     One-component block-compression format.
        /// </summary>
        Bc4UNorm = 80,

        /// <summary>
        ///     One-component block-compression format.
        /// </summary>
        Bc4SNorm = 81,

        /// <summary>
        ///     Two-component typeless block-compression format.
        /// </summary>
        Bc5Typeless = 82,

        /// <summary>
        ///     Two-component block-compression format.
        /// </summary>
        Bc5UNorm = 83,

        /// <summary>
        ///     Two-component block-compression format.
        /// </summary>
        Bc5SNorm = 84,

        /// <summary>
        ///     A three-component, 16-bit unsigned-normalized integer format.
        /// </summary>
        B5G6R5UNorm = 85,

        /// <summary>
        ///     A four-component, 16-bit unsigned-normalized integer format that supports 1-bit alpha.
        /// </summary>
        B5G5R5A1UNorm = 86,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized integer format that supports 8-bit alpha.
        /// </summary>
        B8G8R8A8UNorm = 87,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized integer format.
        /// </summary>
        B8G8R8X8UNorm = 88,

        /// <summary>
        ///     A four-component, 32-bit format that supports 2-bit alpha.
        /// </summary>
        R10G10B10XrBiasA2UNorm = 89,

        /// <summary>
        ///     A four-component, 32-bit typeless format that supports 8-bit alpha.
        /// </summary>
        B8G8R8A8Typeless = 90,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized standard RGB format that supports 8-bit alpha.
        /// </summary>
        B8G8R8A8UNormSRgb = 91,

        /// <summary>
        ///     A four-component, 32-bit typeless format.
        /// </summary>
        B8G8R8X8Typeless = 92,

        /// <summary>
        ///     A four-component, 32-bit unsigned-normalized standard RGB format.
        /// </summary>
        B8G8R8X8UNormSRgb = 93,

        /// <summary>
        ///     A typeless block-compression format.
        /// </summary>
        Bc6HTypeless = 94,

        /// <summary>
        ///     A block-compression format.
        /// </summary>
        Bc6HUf16 = 95,

        /// <summary>
        ///     A block-compression format.
        /// </summary>
        Bc6HSf16 = 96,

        /// <summary>
        ///     A typeless block-compression format.
        /// </summary>
        Bc7Typeless = 97,

        /// <summary>
        ///     A block-compression format.
        /// </summary>
        Bc7UNorm = 98,

        /// <summary>
        ///     A block-compression format.
        /// </summary>
        Bc7UNormSRgb = 99,

        /// <summary>
        /// </summary>
        AYuv = 100,

        /// <summary>
        /// </summary>
        Y410 = 101,

        /// <summary>
        /// </summary>
        Y416 = 102,

        /// <summary>
        /// </summary>
        Nv12 = 103,

        /// <summary>
        /// </summary>
        P010 = 104,

        /// <summary>
        /// </summary>
        P016 = 105,

        // ReSharper disable once InconsistentNaming
        /// <summary>
        /// </summary>
        _420_OPAQUE = 106,

        /// <summary>
        /// </summary>
        Yuy2 = 107,

        /// <summary>
        /// </summary>
        Y210 = 108,

        /// <summary>
        /// </summary>
        Y216 = 109,

        /// <summary>
        /// </summary>
        Nv11 = 110,

        /// <summary>
        /// </summary>
        Ai44 = 111,

        /// <summary>
        /// </summary>
        Ia44 = 112,

        /// <summary>
        /// </summary>
        P8 = 113,

        /// <summary>
        /// </summary>
        A8P8 = 114,

        /// <summary>
        /// </summary>
        B4G4R4A4UNorm = 115,

        /// <summary>
        /// </summary>
        P208 = 130,

        /// <summary>
        /// </summary>
        V208 = 131,

        /// <summary>
        /// </summary>
        V408 = 132
    }
}