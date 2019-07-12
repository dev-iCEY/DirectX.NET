﻿#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
    public interface ISurface : IDeviceSubObject
    {
        int GetDesc(out SurfaceDescription surfaceDesc);
        int Map(out MappedRect mappedRect, Map flags);
        int UnMap();
    }
}