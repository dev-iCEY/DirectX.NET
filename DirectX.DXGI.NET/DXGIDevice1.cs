#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIDevice1 : DXGIDevice, IDXGIDevice1
    {
        protected new const uint LastMethodId = DXGIDevice.LastMethodId + 2u;
        protected new readonly int MethodsCount = typeof(IDXGIDevice1).GetMethods().Length;

        public DXGIDevice1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int SetMaximumFrameLatency(uint maxLatency)
        {
            return GetMethodDelegate<SetMaximumFrameLatencyDelegate>().Invoke(this, maxLatency);
        }

        public int GetMaximumFrameLatency(out uint maxLatency)
        {
            return GetMethodDelegate<GetMaximumFrameLatencyDelegate>().Invoke(this, out maxLatency);
        }

        [ComMethodId(DXGIDevice.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetMaximumFrameLatencyDelegate(IntPtr thisPtr, uint maxLatency);

        [ComMethodId(DXGIDevice.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetMaximumFrameLatencyDelegate(IntPtr thisPtr, out uint maxLatency);
    }
}