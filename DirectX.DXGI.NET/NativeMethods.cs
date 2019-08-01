#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public static class NativeMethods
    {
        [DllImport("dxgi.dll", PreserveSig = true)]
        public static extern int CreateDXGIFactory(in Guid riid, out IntPtr factory);

        internal static IntPtr CreateFactory()
        {
            int result = CreateDXGIFactory(typeof(IDXGIFactory).GUID, out IntPtr factoryPtr);

            if (result != 0)
            {
                throw Marshal.GetExceptionForHR(result);
            }

            return factoryPtr;
        }

        internal static IntPtr CreateFactory1()
        {
            int result = CreateDXGIFactory1(typeof(IDXGIFactory1).GUID, out IntPtr factoryPtr);

            if (result != 0)
            {
                throw Marshal.GetExceptionForHR(result);
            }

            return factoryPtr;
        }

        [DllImport("dxgi.dll", PreserveSig = true)]
        public static extern int CreateDXGIFactory1(in Guid riid, out IntPtr factory1);
    }
}