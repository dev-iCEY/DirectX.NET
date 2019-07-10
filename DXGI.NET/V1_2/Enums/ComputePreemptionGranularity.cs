namespace DXGI.NET.V1_2
{
    public enum ComputePreemptionGranularity : uint
    {
        DmaBufferBoundary = 0,
        DispatchBoundary = 1,
        ThreadGroupBoundary = 2,
        ThreadBoundary = 3,
        InstructionBoundary = 4
    }
}