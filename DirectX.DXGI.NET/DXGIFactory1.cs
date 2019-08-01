#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIFactory1 : DXGIFactory, IDXGIFactory1
    {
        protected new readonly int MethodsCount = typeof(IDXGIFactory1).GetMethods().Length;

        public DXGIFactory1() : this(NativeMethods.CreateFactory1())
        {
        }

        public DXGIFactory1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1)
        {
            int result = GetMethodDelegate<EnumAdapters1Delegate>().Invoke(this, adapterId, out IntPtr adapterPtr);
            adapter1 = result == 0 ? new DXGIAdapter1(adapterPtr) : null;
            return result;
        }

        public bool IsCurrent()
        {
            return GetMethodDelegate<IsCurrentDelegate>().Invoke(this);
        }

        [ComMethodId(12u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumAdapters1Delegate(IntPtr thisPtr, uint adapterId, out IntPtr adapterPtr);

        [ComMethodId(13u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private delegate bool IsCurrentDelegate(IntPtr thisPtr);
    }
}