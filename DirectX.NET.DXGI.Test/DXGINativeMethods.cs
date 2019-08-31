#region Usings

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Test
{
    [SuppressUnmanagedCodeSecurity]
    public class DXGINativeMethods
    {
        [DllImport("d3d11.dll")]
        private static extern int D3D11CreateDevice
        (
            IntPtr devicePtr,
            DriverType driverType,
            IntPtr moduleSoftware,
            uint flags,
            IntPtr fvlvls,
            uint featureLevels,
            uint sdkVersion,
            out IntPtr d3d11DevicePtr,
            out FeatureLevel selectedLevel,
            out IntPtr d3d11DeviceContextPtr
        );

        public static int D3D11CreateDevice
        (
            IUnknown device,
            DriverType driverType,
            IntPtr moduleSoftware,
            uint flags,
            FeatureLevel[] levels,
            uint sdkVersion,
            out IUnknown d3d11Device,
            out FeatureLevel selectedLevel,
            out IUnknown d3d11DeviceContext
        )
        {
            int[] arr = levels.Select(level => (int) level).ToArray();
            GCHandle handle = GCHandle.Alloc(arr, GCHandleType.Pinned);

            int result = D3D11CreateDevice((Unknown) device, driverType, moduleSoftware, flags, handle.AddrOfPinnedObject(),
                (uint) levels.Length, sdkVersion, out IntPtr d3d11DevicePtr, out selectedLevel,
                out IntPtr d3d11DeviceContextPtr);

            handle.Free();

            d3d11Device = result == 0 ? new Unknown(d3d11DevicePtr) : null;
            d3d11DeviceContext = result == 0 ? new Unknown(d3d11DeviceContextPtr) : null;

            return result;
        }
    }
}