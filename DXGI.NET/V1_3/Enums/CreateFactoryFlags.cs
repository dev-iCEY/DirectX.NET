#region Usings

using System;

#endregion

namespace DXGI.NET.V1_3
{
    [Flags]
    public enum CreateFactoryFlags : uint
    {
        None = 0x0,
        Debug = 0x01
    }
}