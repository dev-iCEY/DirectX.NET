namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Specifies color space support for the swap chain.
    /// </summary>
    public enum DXGIColorSpaceType : uint
    {
        /// <summary>
        ///     The RGB full G22 none P709
        /// </summary>
        RgbFullG22NoneP709 = 0,

        /// <summary>
        ///     The RGB full G10 none P709
        /// </summary>
        RgbFullG10NoneP709 = 1,

        /// <summary>
        ///     The RGB studio G22 none P709
        /// </summary>
        RgbStudioG22NoneP709 = 2,

        /// <summary>
        ///     The RGB studio G22 none P2020
        /// </summary>
        RgbStudioG22NoneP2020 = 3,

        /// <summary>
        ///     The reserved
        /// </summary>
        Reserved = 4,

        /// <summary>
        ///     The yc bc r full G22 none P709 X601
        /// </summary>
        YcBcRFullG22NoneP709X601 = 5,

        /// <summary>
        ///     The yc bc r studio G22 left P601
        /// </summary>
        YcBcRStudioG22LeftP601 = 6,

        /// <summary>
        ///     The yc bc r full G22 left P601
        /// </summary>
        YcBcRFullG22LeftP601 = 7,

        /// <summary>
        ///     The yc bc r studio G22 left P709
        /// </summary>
        YcBcRStudioG22LeftP709 = 8,

        /// <summary>
        ///     The yc bc r full G22 left P709
        /// </summary>
        YcBcRFullG22LeftP709 = 9,

        /// <summary>
        ///     The yc bc r studio G22 left P2020
        /// </summary>
        YcBcRStudioG22LeftP2020 = 10,

        /// <summary>
        ///     The yc bc r full G22 left P2020
        /// </summary>
        YcBcRFullG22LeftP2020 = 11,

        /// <summary>
        ///     The RGB full G2084 none P2020
        /// </summary>
        RgbFullG2084NoneP2020 = 12,

        /// <summary>
        ///     The yc bc r studio G2084 left P2020
        /// </summary>
        YcBcRStudioG2084LeftP2020 = 13,

        /// <summary>
        ///     The RGB studio G2084 none P2020
        /// </summary>
        RgbStudioG2084NoneP2020 = 14,

        /// <summary>
        ///     The yc bc r studio G22 top left P2020
        /// </summary>
        YcBcRStudioG22TopLeftP2020 = 15,

        /// <summary>
        ///     The yc bc r studio G2084 top left P2020
        /// </summary>
        YcBcRStudioG2084TopLeftP2020 = 16,

        /// <summary>
        ///     The RGB full G22 none P2020
        /// </summary>
        RgbFullG22NoneP2020 = 17,

        /// <summary>
        ///     The yc bc r studio gh lg top left P2020
        /// </summary>
        YcBcRStudioGhLgTopLeftP2020 = 18,

        /// <summary>
        ///     The yc bc r full gh lg top left P2020
        /// </summary>
        YcBcRFullGhLgTopLeftP2020 = 19,

        /// <summary>
        ///     The RGB studio G24 none P709
        /// </summary>
        RgbStudioG24NoneP709 = 20,

        /// <summary>
        ///     The RGB studio G24 none P2020
        /// </summary>
        RgbStudioG24NoneP2020 = 21,

        /// <summary>
        ///     The yc bc r studio G24 left P709
        /// </summary>
        YcBcRStudioG24LeftP709 = 22,

        /// <summary>
        ///     The yc bc r studio G24 left P2020
        /// </summary>
        YcBcRStudioG24LeftP2020 = 23,

        /// <summary>
        ///     The yc bc r studio G24 top left P2020
        /// </summary>
        YcBcRStudioG24TopLeftP2020 = 24,

        /// <summary>
        ///     The custom
        /// </summary>
        Custom = 0xFFFFFFFF
    }
}