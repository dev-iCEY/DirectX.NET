namespace DirectX.NET.Direct2D
{
    #region Usings

    using System;
    using System.Runtime.InteropServices;
    using Interfaces;

    #endregion

    public class Resource : Unknown, IResource
    {
        protected new const uint LastMethodId = Unknown.LastMethodId + 1u;
        protected new readonly int MethodsCount = typeof(IResource).GetMethods().Length;

        public Resource(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public void GetFactory(out IFactory factory)
        {
            GetMethodDelegate<GetFactoryDelegate>().Invoke(this, out IntPtr factoryPtr);
            factory = new Factory(factoryPtr);
        }

        [ComMethodId(Unknown.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void GetFactoryDelegate(IntPtr thisPtr, out IntPtr factoryPtr);
    }
}