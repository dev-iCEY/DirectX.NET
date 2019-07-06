﻿#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.Interfaces
{
    [ComImport, Guid("9d8e1289-d7b3-465f-8126-250e349af85d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIKeyedMutex : IDXGIDeviceSubObject
    {
        #region IDXGIDeviceSubObject

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
            GetDevice
            (
                ref Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object device
            );

        #endregion

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            AcquireSync
            (
                ulong key,
                uint milliseconds
            );

#if !DEXP
        [PreserveSig]
        int
#else
        void
#endif
            ReleaseSync
            (
                ulong key
            );
    }
}