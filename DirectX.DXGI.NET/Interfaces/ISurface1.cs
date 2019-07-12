#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("4AE63092-6327-4c1b-80AE-BFE12EA32B86")]
    public interface ISurface1 : ISurface
    {
        int GetDc(bool discard, out IntPtr dcHandle);
        int ReleaseDc(in Rect dirtyRect);
    }
}