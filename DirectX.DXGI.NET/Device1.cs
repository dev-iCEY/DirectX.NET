#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Device1 : Device, IDevice1
    {
        protected new const uint LastMethodId = Device.LastMethodId + 2u;
        protected new readonly int MethodsCount = typeof(IDevice1).GetMethods().Length;

        public Device1(IntPtr objectPtr) : base(objectPtr)
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

        [ComMethodId(Device.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetMaximumFrameLatencyDelegate(IntPtr thisPtr, uint maxLatency);

        [ComMethodId(Device.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetMaximumFrameLatencyDelegate(IntPtr thisPtr, out uint maxLatency);
    }
}