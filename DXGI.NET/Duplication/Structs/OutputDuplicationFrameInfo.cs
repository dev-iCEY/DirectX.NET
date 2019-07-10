using System.Runtime.InteropServices;

namespace DXGI.NET.Duplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OutputDuplicationFrameInfo
    {
        public LargeInteger LastPresentTime { get; set; }
        public LargeInteger LastMouseUpdateTime { get; set; }
        public uint AccumulatedFrames { get; set; }
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool RectsCoalesced { get; set; }
        [field: MarshalAs(UnmanagedType.Bool)]
        public bool ProtectedContentMaskedOut { get; set; }
        public OutputDuplicationPointerPosition PointerPosition { get; set; }
        public uint TotalMetadataBufferSize { get; set; }
        public uint PointerShapeBufferSize { get; set; }  
    }
}