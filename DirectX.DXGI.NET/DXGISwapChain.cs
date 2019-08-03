#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGISwapChain : DXGIDeviceSubObject, IDXGISwapChain
    {
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 10u;
        protected new readonly int MethodsCount = typeof(IDXGISwapChain).GetMethods().Length;

        public DXGISwapChain(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int Present(uint syncInterval, PresentFlags flags = 0)
        {
            return GetMethodDelegate<PresentDelegate>().Invoke(this, syncInterval, flags);
        }

        public int GetBuffer(uint buffer, in Guid riid, out IUnknown surface)
        {
            int result = GetMethodDelegate<GetBufferDelegate>().Invoke(this, buffer, in riid, out IntPtr surfacePtr);
            surface = result == 0 ? new DXGISurface(surfacePtr) : null;
            return result;
        }

        public int SetFullscreenState(bool state, IDXGIOutput target = null)
        {
            return GetMethodDelegate<SetFullscreenStateDelegate>().Invoke(this, state, (DXGIOutput) target ?? IntPtr.Zero);
        }

        public int GetFullscreenState(out bool state, out IDXGIOutput target)
        {
            int result = GetMethodDelegate<GetFullscreenStateDelegate>().Invoke(this, out state, out IntPtr outputPtr);
            target = result == 0 && outputPtr != IntPtr.Zero ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        public int GetDesc(out DXGISwapChainDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        public int ResizeBuffers(uint bufferCount, uint width, uint height, DXGIFormat newFormat, DXGISwapChainFlag flags)
        {
            return GetMethodDelegate<ResizeBuffersDelegate>()
                .Invoke(this, bufferCount, width, height, newFormat, flags);
        }

        public int ResizeTarget(in DXGIModeDescription newTargetParameters)
        {
            return GetMethodDelegate<ResizeTargetDelegate>().Invoke(this, in newTargetParameters);
        }

        public int GetContainingOutput(out IDXGIOutput output)
        {
            int result = GetMethodDelegate<GetContainingOutputDelegate>().Invoke(this, out IntPtr outputPtr);
            output = result == 0 ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        public int GetFrameStatistics(out DXGIFrameStatistics frameStatistics)
        {
            return GetMethodDelegate<GetFrameStatisticsDelegate>().Invoke(this, out frameStatistics);
        }

        public int GetLastPresentCount(out uint lastPresentCount)
        {
            return GetMethodDelegate<GetLastPresentCountDelegate>().Invoke(this, out lastPresentCount);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int PresentDelegate(IntPtr thisPtr, uint syncInterval, PresentFlags flags = 0);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetBufferDelegate(IntPtr thisPtr, uint buffer, in Guid riid, out IntPtr surfacePtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetFullscreenStateDelegate(IntPtr thisPtr,
            [MarshalAs(UnmanagedType.Bool)] bool fullscreenState, IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFullscreenStateDelegate(IntPtr thisPtr, out bool fullscreenState, out IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGISwapChainDescription desc);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ResizeBuffersDelegate(IntPtr thisPtr, uint bufferCount, uint width, uint height,
            DXGIFormat newFormat, DXGISwapChainFlag flags);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ResizeTargetDelegate(IntPtr thisPtr, in DXGIModeDescription newTargetParameters);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetContainingOutputDelegate(IntPtr thisPtr, out IntPtr outputPtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFrameStatisticsDelegate(IntPtr thisPtr, out DXGIFrameStatistics frameStatistics);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 10u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetLastPresentCountDelegate(IntPtr thisPtr, out uint countPresent);
    }
}