#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Factory1 : Factory, IFactory1
    {
        protected new readonly int MethodsCount = typeof(IFactory1).GetMethods().Length;

        public Factory1() : this(NativeMethods.CreateFactory1())
        {
        }

        public Factory1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int EnumAdapters1(uint adapterId, out IAdapter1 adapter1)
        {
            int result = GetMethodDelegate<EnumAdapters1Delegate>().Invoke(this, adapterId, out IntPtr adapterPtr);
            adapter1 = result == 0 ? new Adapter1(adapterPtr) : null;
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