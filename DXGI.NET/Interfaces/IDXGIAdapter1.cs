﻿#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("29038f61-3839-4626-91fd-086879011a05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIAdapter1 : IDXGIAdapter
    {
        #region IDXGIAdapter methods

        #region IDXGIObject methods

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetPrivateData
            (
                [In] ref Guid name,
                uint dataSize,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                byte[] data
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            SetPrivateDataInterface
            (
                [In] ref Guid name,
                [MarshalAs(UnmanagedType.IUnknown)] object iUnknown = null
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetPrivateData
            (
                [In] ref Guid name,
                ref uint dataSize,
                [In, Out, MarshalAs(UnmanagedType.LPArray)]
                byte[] data = null
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetParent
            (
                [In] ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object parent
            );

        #endregion

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            EnumOutputs
            (
                uint outputIndex,
                out IDXGIOutput output
            );

#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            GetDesc
            (
                out AdapterDescription desc
            );


#if !DEXP
        [PreserveSig]
        new int
#else
        new void
#endif
            CheckInterfaceSupport
            (
                [In] ref Guid interfaceName,
                out LargeInteger pUmdVersion
            );

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            GetDesc1(out AdapterDescription1 adapterDesc1);
    }
}