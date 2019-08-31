#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     The <see cref="IDXGIAdapter2" /> interface represents a display subsystem, which includes one or more GPUs, DACs,
    ///     and video memory.
    /// </summary>
    /// <seealso cref="DirectX.NET.DXGI.DXGIAdapter1" />
    /// <seealso cref="DirectX.NET.DXGI.Interfaces.IDXGIAdapter2" />
    public class DXGIAdapter2 : DXGIAdapter1, IDXGIAdapter2
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIAdapter1.LastMethodId + 1u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIAdapter2).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIAdapter1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIAdapter2(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount,  ref MethodsCount);
        }

        /// <summary>
        ///     Gets a Microsoft DirectX Graphics Infrastructure (DXGI) 1.2 description of an adapter or video card.
        /// </summary>
        /// <param name="adapterDescription">The adapter description.</param>
        /// <returns></returns>
        public int GetDesc2(out DXGIAdapterDescription2 adapterDescription)
        {
            return GetMethodDelegate<DXGIGetDesc2Delegate>().Invoke(this, out adapterDescription);
        }


        [ComMethodId(DXGIAdapter1.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DXGIGetDesc2Delegate(IntPtr thisPtr, out DXGIAdapterDescription2 adapterDescription2);
    }
}