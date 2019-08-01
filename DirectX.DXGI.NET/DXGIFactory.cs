#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIFactory : DXGIObject, IDXGIFactory
    {
        protected new readonly int MethodsCount = typeof(IDXGIFactory).GetMethods().Length;

        public DXGIFactory() : this(NativeMethods.CreateFactory())
        {
        }

        public DXGIFactory(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int EnumAdapters(uint adapterIndex, out IDXGIAdapter adapter)
        {
            int result = GetMethodDelegate<EnumAdaptersDelegate>().Invoke(this, adapterIndex, out IntPtr adapterPtr);

            adapter = result == 0 ? new DXGIAdapter(adapterPtr) : null;

            return result;
        }

        public int MakeWindowAssociation(IntPtr windowHandle, WindowAssociationFlags flags)
        {
            return GetMethodDelegate<MakeWindowAssociationDelegate>().Invoke(this, windowHandle, flags);
        }

        public int GetWindowAssociation(out IntPtr windowHandle)
        {
            return GetMethodDelegate<GetWindowAssociationDelegate>().Invoke(this, out windowHandle);
        }

        public int CreateSwapChain(IUnknown device, in SwapChainDescription desc, out IDXGISwapChain swapChain)
        {
            int result = GetMethodDelegate<CreateSwapChainDelegate>()
                .Invoke(this, (Unknown) device, out IntPtr swapChainPtr);
            swapChain = result == 0 ? new DXGISwapChain(swapChainPtr) : null;
            return result;
        }

        public int CreateSoftwareAdapter(IntPtr moduleHandle, out IDXGIAdapter softwareAdapter)
        {
            int result = GetMethodDelegate<CreateSoftwareAdapterDelegate>()
                .Invoke(this, moduleHandle, out IntPtr softwareAdapterPtr);
            softwareAdapter = result == 0 ? new DXGIAdapter(softwareAdapterPtr) : null;
            return result;
        }

        [ComMethodId(7), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumAdaptersDelegate(IntPtr thisPtr, uint adapterIndex, out IntPtr adapterPtr);

        [ComMethodId(8), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int MakeWindowAssociationDelegate(IntPtr thisPtr, IntPtr windowHandle,
            WindowAssociationFlags flags);

        [ComMethodId(9), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetWindowAssociationDelegate(IntPtr thisPtr, out IntPtr windowHandle);

        [ComMethodId(10), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSwapChainDelegate(IntPtr thisPtr, IntPtr devicePtr, out IntPtr swapChainPtr);

        [ComMethodId(11), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSoftwareAdapterDelegate(IntPtr thisPtr, IntPtr hModule, out IntPtr adapterPtr);
    }
}