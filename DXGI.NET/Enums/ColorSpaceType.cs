namespace DXGI.NET
{
    public enum ColorSpaceType : uint
    {
        RgbFullG22NoneP709 = 0,
        RgbFullG10NoneP709 = 1,
        RgbStudioG22NoneP709 = 2,
        RgbStudioG22NoneP2020 = 3,
        Reserved = 4,
        YcBcRFullG22NoneP709X601 = 5,
        YcBcRStudioG22LeftP601 = 6,
        YcBcRFullG22LeftP601 = 7,
        YcBcRStudioG22LeftP709 = 8,
        YcBcRFullG22LeftP709 = 9,
        YcBcRStudioG22LeftP2020 = 10,
        YcBcRFullG22LeftP2020 = 11,
        RgbFullG2084NoneP2020 = 12,
        YcBcRStudioG2084LeftP2020 = 13,
        RgbStudioG2084NoneP2020 = 14,
        YcBcRStudioG22TopLeftP2020 = 15,
        YcBcRStudioG2084TopLeftP2020 = 16,
        RgbFullG22NoneP2020 = 17,
        YcBcRStudioGhLgTopLeftP2020 = 18,
        YcBcRFullGhLgTopLeftP2020 = 19,
        RgbStudioG24NoneP709 = 20,
        RgbStudioG24NoneP2020 = 21,
        YcBcRStudioG24LeftP709 = 22,
        YcBcRStudioG24LeftP2020 = 23,
        YcBcRStudioG24TopLeftP2020 = 24,
        Custom = 0xFFFFFFFF
    }
}