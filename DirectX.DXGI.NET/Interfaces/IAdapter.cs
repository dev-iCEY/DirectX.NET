#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
    public interface IAdapter : IObject
    {
        int EnumOutputs(uint outputIndex, out IOutput output);
        int GetDesc(out AdapterDescription desc);
        int CheckInterfaceSupport(in Guid interfaceName, out LargeInteger pUmdVersion);
    }
}