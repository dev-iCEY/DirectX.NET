namespace DirectX.NET.DXGI.Test
{
    public enum DriverType : byte
    {
        Unknown = 0,
        Hardware = Unknown + 1,
        Reference = Hardware + 1,
        Null = Reference + 1,
        Software = Null + 1,
        Warp = Software + 1
    }
}