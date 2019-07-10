namespace DXGI.NET.V1_2
{
    public enum GraphicsPreemptionGranularity : uint
    {
        DmaBufferBoundary = 0,
        PrimitiveBoundary = 1,
        TriangleBoundary = 2,
        PixelBoundary = 3,
        InstructionBoundary = 4
    }
}