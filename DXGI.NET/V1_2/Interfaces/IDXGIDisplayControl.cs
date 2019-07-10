#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_2.Interfaces
{
    [ComImport, Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c")]
    public interface IDXGIDisplayControl
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsStereoEnabled();

        void SetStereoEnabled([MarshalAs(UnmanagedType.Bool)] bool enabled);
    }
}