namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies the granularity at which the graphics processing unit (GPU) can be preempted from performing its current
    ///     graphics rendering task.
    /// </summary>
    public enum DXGIGraphicsPreemptionGranularity : uint
    {
        /// <summary>
        ///     Indicates the preemption granularity as a DMA buffer.
        /// </summary>
        DmaBufferBoundary = 0,

        /// <summary>
        ///     Indicates the preemption granularity as a graphics primitive. A primitive is a section in a DMA buffer and can be a
        ///     group of triangles.
        /// </summary>
        PrimitiveBoundary = 1,

        /// <summary>
        ///     Indicates the preemption granularity as a triangle. A triangle is a part of a primitive.
        /// </summary>
        TriangleBoundary = 2,

        /// <summary>
        ///     Indicates the preemption granularity as a pixel. A pixel is a part of a triangle.
        /// </summary>
        PixelBoundary = 3,

        /// <summary>
        ///     Indicates the preemption granularity as a graphics instruction. A graphics instruction operates on a pixel.
        /// </summary>
        InstructionBoundary = 4
    }
}