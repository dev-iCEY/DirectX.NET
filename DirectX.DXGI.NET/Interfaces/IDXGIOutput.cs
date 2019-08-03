#region Usings

using System.Runtime.InteropServices;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
    public interface IDXGIOutput : IDXGIObject
    {
        int GetDesc(out DXGIOutputDescription desc);
        int GetDisplayModeList(DXGIFormat format, uint flags, ref uint numModes, [In, Out, Optional] DXGIModeDescription[] modesDesc);
        int FindClosestMatchingMode(in DXGIModeDescription modeMatch, out DXGIModeDescription closestMatch, IUnknown device);
        int WaitForVBlank();
        int TakeOwnership(IUnknown device, bool isExclusive);
        void ReleaseOwnership();
        int GetGammaControlCapabilities(out DXGIGammaControlCapabilities gammaControlCapabilities);
        int SetGammaControl(in DXGIGammaControl gammaControl);
        int GetGammaControl(out DXGIGammaControl gammaControl);
        int SetDisplaySurface(IDXGISurface surface);
        int GetDisplaySurfaceData(IDXGISurface surface);
        int GetFrameStatistics(out DXGIFrameStatistics frameStatistics);
    }
}