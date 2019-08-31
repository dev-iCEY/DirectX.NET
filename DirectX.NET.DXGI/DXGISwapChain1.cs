#region Usings

using System;
using System.Runtime.InteropServices;
using System.Security;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Provides presentation capabilities that are enhanced from <see cref="IDXGISwapChain" />.
    ///     These presentation capabilities consist of specifying dirty rectangles and scroll rectangle to optimize the
    ///     presentation.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGISwapChain" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGISwapChain1" />
    [SuppressUnmanagedCodeSecurity]
    public class DXGISwapChain1 : DXGISwapChain, IDXGISwapChain1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGISwapChain.LastMethodId + 11u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGISwapChain1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGISwapChain1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGISwapChain1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        public int GetDesc1(out DXGISwapChainDescription1 swapChainDescription1)
        {
            return GetMethodDelegate<DXGIGetDesc1Delegate>()
                .Invoke(this, out swapChainDescription1);
        }

        public int GetFullscreenDesc(out DXGISwapChainFullscreenDescription fullscreenDescription)
        {
            return GetMethodDelegate<DXGIGetFullscreenDescDelegate>()
                .Invoke(this, out fullscreenDescription);
        }

        public int GetHwnd(out IntPtr hwnd)
        {
            return GetMethodDelegate<DXGIGetHwndDelegate>()
                .Invoke(this, out hwnd);
        }

        public int GetCoreWindow(in Guid riid, out IntPtr pUnknown)
        {
            return GetMethodDelegate<DXGIGetCoreWindowDelegate>()
                .Invoke(this, in riid, out pUnknown);
        }

        public int Present1(uint syncInterval, DXGIPresentFlags flags, ref DXGIPresentParameters presentParameters)
        {
            return GetMethodDelegate<DXGIPresent1Delegate>()
                .Invoke(this, syncInterval, flags, ref presentParameters);
        }

        public bool IsTemporaryMonoSupported()
        {
            return GetMethodDelegate<DXGIIsTemporaryMonoSupportedDelegate>()
                .Invoke(this);
        }

        public int GetRestrictToOutput(out IDXGIOutput restrictToOutput)
        {
            int result = GetMethodDelegate<DXGIGetRestrictToOutputDelegate>()
                .Invoke(this, out IntPtr outputPtr);
            restrictToOutput = result == 0 ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        public int SetBackgroundColor(in DXGIRgba color)
        {
            return GetMethodDelegate<DXGISetBackgroundColorDelegate>()
                .Invoke(this, in color);
        }

        public int GetBackgroundColor(out DXGIRgba color)
        {
            return GetMethodDelegate<DXGIGetBackgroundColorDelegate>()
                .Invoke(this, out color);
        }

        public int SetRotation(DXGIModeRotation rotation)
        {
            return GetMethodDelegate<DXGISetRotationDelegate>()
                .Invoke(this, rotation);
        }

        public int GetRotation(out DXGIModeRotation rotation)
        {
            return GetMethodDelegate<DXGIGetRotationDelegate>()
                .Invoke(this, out rotation);
        }

        #region Delegates

        [ComMethodId(DXGISwapChain.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetDesc1Delegate(IntPtr thisPtr, out DXGISwapChainDescription1 swapChainDescription);

        [ComMethodId(DXGISwapChain.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetFullscreenDescDelegate(IntPtr thisPtr,
            out DXGISwapChainFullscreenDescription fullscreenDescription);

        [ComMethodId(DXGISwapChain.LastMethodId + 3u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetHwndDelegate(IntPtr thisPtr, out IntPtr windowHandle);

        [ComMethodId(DXGISwapChain.LastMethodId + 4u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetCoreWindowDelegate(IntPtr thisPtr, in Guid riid, out IntPtr pUnknown);

        [ComMethodId(DXGISwapChain.LastMethodId + 5u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIPresent1Delegate(IntPtr thisPtr, uint syncInterval, DXGIPresentFlags flags, ref DXGIPresentParameters presentParameters);

        [ComMethodId(DXGISwapChain.LastMethodId + 6u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private delegate bool DXGIIsTemporaryMonoSupportedDelegate(IntPtr thisPtr);

        [ComMethodId(DXGISwapChain.LastMethodId + 7u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetRestrictToOutputDelegate(IntPtr thisPtr, out IntPtr restrictToOutput);

        [ComMethodId(DXGISwapChain.LastMethodId + 8u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGISetBackgroundColorDelegate(IntPtr thisPtr, in DXGIRgba color);

        [ComMethodId(DXGISwapChain.LastMethodId + 9u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetBackgroundColorDelegate(IntPtr thisPtr, out DXGIRgba color);

        [ComMethodId(DXGISwapChain.LastMethodId + 10u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGISetRotationDelegate(IntPtr thisPtr, DXGIModeRotation rotation);

        [ComMethodId(DXGISwapChain.LastMethodId + 11u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetRotationDelegate(IntPtr thisPtr, out DXGIModeRotation rotation);

        #endregion
    }
}