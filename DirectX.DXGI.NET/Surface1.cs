#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    public class Surface1 : Surface, ISurface1
    {
        protected new const uint LastMethodId = Surface.LastMethodId + 2u;
        protected new readonly int MethodsCount = typeof(ISurface1).GetMethods().Length;

        public Surface1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDc(bool discard, out IntPtr dcHandle)
        {
            return GetMethodDelegate<GetDcDelegate>().Invoke(this, discard, out dcHandle);
        }

        public int ReleaseDc(in Rect dirtyRect)
        {
            return GetMethodDelegate<ReleaseDcDelegate>().Invoke(this, in dirtyRect);
        }

        [ComMethodId(Surface.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDcDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.Bool)] bool discard,
            out IntPtr dcHandle);

        [ComMethodId(Surface.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseDcDelegate(IntPtr thisPtr, in Rect dirtyRect);
    }
}