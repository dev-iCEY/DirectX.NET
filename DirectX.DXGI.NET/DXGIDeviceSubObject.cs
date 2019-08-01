#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIDeviceSubObject : DXGIObject, IDXGIDeviceSubObject
    {
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 1u;
        protected new readonly int MethodsCount = typeof(IDXGIDeviceSubObject).GetMethods().Length;

        public DXGIDeviceSubObject(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDevice(in Guid riid, out IUnknown device)
        {
            int result = GetMethodDelegate<GetDeviceDelegate>().Invoke(this, in riid, out IntPtr devicePtr);
            device = result == 0 ? new Unknown(devicePtr) : null;
            return result;
        }

        [ComMethodId(DXGIObject.LastMethodId + 1), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDeviceDelegate(IntPtr thisPtr, in Guid riid, out IntPtr devicePtr);
    }
}