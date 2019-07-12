#region Usings

using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
    public interface IOutput : IObject
    {
        int GetDesc(out OutputDescription desc);
        int GetDisplayModeList(Format format, uint flags, ref uint numModes, [In, Out, Optional] ModeDescription[] modesDesc);
        int FindClosestMatchingMode(in ModeDescription modeMatch, out ModeDescription closestMatch, IUnknown device);
        int WaitForVBlank();
        int TakeOwnership(IUnknown device, bool isExclusive);
        void ReleaseOwnership();
        int GetGammaControlCapabilities(out GammaControlCapabilities gammaControlCapabilities);
        int SetGammaControl(in GammaControl gammaControl);
        int GetGammaControl(out GammaControl gammaControl);
        int SetDisplaySurface(ISurface surface);
        int GetDisplaySurfaceData(ISurface surface);
        int GetFrameStatistics(out FrameStatistics frameStatistics);
    }
}