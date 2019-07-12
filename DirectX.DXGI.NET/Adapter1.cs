#region Usings

using System;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Adapter1 : Adapter, IAdapter1
    {
        protected new readonly int MethodsCount = typeof(IAdapter1).GetMethods().Length;

        public Adapter1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDesc1(out AdapterDescription1 adapterDesc1)
        {
            return GetMethodDelegate<GetDesc1Delegate>().Invoke(this, out adapterDesc1);
        }

        [ComMethodId(10u)]
        private delegate int GetDesc1Delegate(IntPtr thisPtr, out AdapterDescription1 adapterDescription1);
    }
}