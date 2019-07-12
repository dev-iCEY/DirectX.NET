#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Adapter : Object, IAdapter
    {
        protected new readonly int MethodsCount = typeof(IAdapter).GetMethods().Length;

        public Adapter(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int EnumOutputs(uint outputIndex, out IOutput output)
        {
            int result = GetMethodDelegate<EnumOutputsDelegate>().Invoke(this, outputIndex, out IntPtr outputPtr);
            output = result == 0 ? new Output(outputPtr) : null;
            return result;
        }

        public int GetDesc(out AdapterDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        public int CheckInterfaceSupport(in Guid interfaceName, out LargeInteger pUmdVersion)
        {
            return GetMethodDelegate<CheckInterfaceSupportDelegate>().Invoke(this, in interfaceName, out pUmdVersion);
        }

        [ComMethodId(7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumOutputsDelegate(IntPtr thisPtr, uint adapterIndex, out IntPtr outputPtr);

        [ComMethodId(8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out AdapterDescription description);

        [ComMethodId(9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CheckInterfaceSupportDelegate(IntPtr thisPtr, in Guid guid, out LargeInteger pUmdVersion);
    }
}