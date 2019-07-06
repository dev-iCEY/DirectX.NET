#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    internal static class NativeMethods
    {
        [DllImport
        ("dxgi.dll"
#if !DEXP
            , PreserveSig = true
#endif
        )]
        internal static extern
#if !DEXP
            int
#else
                void
#endif
            CreateDXGIFactory(ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object factory);

        [DllImport
        ("dxgi.dll"
#if !DEXP
            , PreserveSig = true
#endif
        )]
        internal static extern
#if !DEXP
            int
#else
                void
#endif
            CreateDXGIFactory1(ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object factory1);
    }
}