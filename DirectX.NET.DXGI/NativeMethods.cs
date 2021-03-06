﻿#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    /// </summary>
    public static class DXGINativeMethods
    {
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

        internal static IntPtr CreateFactory2()
        {
            int result = CreateDXGIFactory1(typeof(IDXGIFactory2).GUID, out IntPtr factoryPtr);

            if (result != 0)
            {
                throw Marshal.GetExceptionForHR(result);
            }

            return factoryPtr;
        }

        /// <summary>
        ///     Creates the dxgi factory1.
        /// </summary>
        /// <param name="riid">The riid.</param>
        /// <param name="factory1">The factory1.</param>
        /// <returns></returns>
        [DllImport("dxgi.dll", PreserveSig = true)]
        private static extern int CreateDXGIFactory1(in Guid riid, out IntPtr factory1);

        /// <summary>
        ///     Creates the dxgi factory.
        /// </summary>
        /// <param name="riid">The riid.</param>
        /// <param name="factory">The factory.</param>
        /// <returns></returns>
        [DllImport("dxgi.dll", PreserveSig = true)]
        private static extern int CreateDXGIFactory(in Guid riid, out IntPtr factory);
    }
}