#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class Object : Unknown, IObject
    {
        protected new const uint LastMethodId = Unknown.LastMethodId + 4u;
        protected new readonly int MethodsCount = typeof(IObject).GetMethods().Length;

        public Object(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int SetPrivateData(in Guid name, uint dataSize, byte[] data)
        {
            return GetMethodDelegate<SetPrivateDataDelegate>().Invoke(this, in name, dataSize, data);
        }

        public int SetPrivateDataInterface(in Guid name, IUnknown iUnknown = null)
        {
            return GetMethodDelegate<SetPrivateDataInterfaceDelegate>()
                .Invoke(this, in name, (Unknown) iUnknown ?? IntPtr.Zero);
        }

        public int GetPrivateData(in Guid name, ref uint dataSize, [In, Out] byte[] data = null)
        {
            return GetMethodDelegate<GetPrivateDataDelegate>().Invoke(this, in name, ref dataSize, data);
        }

        public int GetParent(in Guid riid, out IntPtr parent)
        {
            return GetMethodDelegate<GetParentDelegate>().Invoke(this, in riid, out parent);
        }

        [ComMethodId(Unknown.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetPrivateDataDelegate(IntPtr thisPtr, in Guid name, uint dataSize, [MarshalAs(UnmanagedType.LPArray)] byte[] data);

        [ComMethodId(Unknown.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetPrivateDataInterfaceDelegate(IntPtr thisPtr, in Guid name, IntPtr iUnknown);

        [ComMethodId(Unknown.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetPrivateDataDelegate(IntPtr thisPtr, in Guid name, ref uint dataSize, [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] data = null);

        [ComMethodId(Unknown.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetParentDelegate(IntPtr thisPtr, in Guid riid, out IntPtr parent);
    }
}