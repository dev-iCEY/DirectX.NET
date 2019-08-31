namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Identifies the granularity at which the graphics processing unit (GPU) can be preempted from performing its current
    ///     compute task.
    /// </summary>
    /// <remarks>
    ///     You call the <see cref="IDXGIAdapter2.GetDesc2"/> method to retrieve the granularity level at which the GPU can be
    ///     preempted from performing its current compute task. The operating system specifies the compute granularity level in
    ///     the ComputePreemptionGranularity member of the DXGI_ADAPTER_DESC2 structure.
    /// </remarks>
    public enum DXGIComputePreemptionGranularity
    {
        /// <summary>
        ///     Indicates the preemption granularity as a compute packet.
        /// </summary>
        DmaBufferBoundary = 0,

        /// <summary>
        ///     Indicates the preemption granularity as a dispatch (for example, a call to the
        ///     <b>ID3D11DeviceContext.Dispatch method</b>). A dispatch is a part of a compute packet.
        /// </summary>
        DispatchBoundary = 1,

        /// <summary>
        ///     Indicates the preemption granularity as a thread group. A thread group is a part of a dispatch.
        /// </summary>
        ThreadGroupBoundary = 2,

        /// <summary>
        ///     Indicates the preemption granularity as a thread in a thread group. A thread is a part of a thread group.
        /// </summary>
        ThreadBoundary = 3,

        /// <summary>
        ///     Indicates the preemption granularity as a compute instruction in a thread.
        /// </summary>
        InstructionBoundary = 4
    }
}