namespace DXGI.NET
{
    public enum Residency : uint
    {
        FullyResident = 1,
        ResidentInSharedMemory = 2,
        EvictedToDisk = 3
    }
}