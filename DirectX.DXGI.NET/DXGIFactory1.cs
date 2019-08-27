#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     <inheritdoc cref="IDXGIFactory1" />
    /// </summary>
    /// <seealso cref="DXGIFactory" />
    /// <seealso cref="IDXGIFactory1" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIFactory1 : DXGIFactory, IDXGIFactory1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIFactory.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIFactory1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory1" /> class.
        /// </summary>
        public DXGIFactory1() : this(NativeMethods.CreateFactory1())
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIFactory1" /> class.
        /// </summary>
        /// <param name="objectPtr"></param>
        public DXGIFactory1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Enumerates both adapters (video cards) with or without outputs.
        /// </summary>
        /// <param name="adapterId">The index of the adapter to enumerate.</param>
        /// <param name="adapter1">
        ///     The out object as <seealso cref="IDXGIAdapter1" /> interface at the position specified by the Adapter
        ///     parameter. This parameter must not be NULL.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     The set of adapters available in the system is enumerated when the factory is created. Therefore, if you change the
        ///     adapters in a system, you must destroy and recreate the <seealso cref="IDXGIFactory1" /> object. The number of
        ///     adapters adapters in a
        ///     system changes when you add or remove a display card, or dock or undock a laptop.
        ///     When the <seealso cref="EnumAdapters1" /> method succeeds and the adapter interface is filled, the adapters
        ///     reference count will be
        ///     incremented. When you are finished with the adapter interface, be sure to call the Release method to decrement the
        ///     reference count before you destroy the pointer.
        ///     The local adapter with output on which the Desktop primary is displayed is returned first, followed by other
        ///     adapter(s) with outputs, then adapter(s) without outputs.
        ///     The following code example demonstrates how to enumerate adapters using the EnumAdapters1 method.
        ///     <example>
        ///         <code>
        /// uint i = 0;
        /// IDXGIAdapter1 adapter;
        /// List&lt;IDXGIAdapter&gt; adapters = new List&lt;IDXGIAdapter1&gt;
        /// while(factory.EnumAdapters1(i, out adapter) != DXGI_ERROR_NOT_FOUND)
        /// {
        /// adapters.Add(pAdapter);
        /// ++i;
        /// }
        /// </code>
        ///     </example>
        /// </remarks>
        public int EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1)
        {
            int result = GetMethodDelegate<EnumAdapters1Delegate>().Invoke(this, adapterId, out IntPtr adapterPtr);
            adapter1 = result == 0 ? new DXGIAdapter1(adapterPtr) : null;
            return result;
        }

        /// <summary>
        ///     Informs an application of the possible need to re-enumerate adapters.
        /// </summary>
        /// <returns>
        ///     <c>false</c>, if a new adapter is becoming available or the current adapter is going away. <c>true</c>, no adapter
        ///     changes.
        ///     IsCurrent returns <c>false</c> to inform the calling application to re-enumerate adapters.
        /// </returns>
        public bool IsCurrent()
        {
            return GetMethodDelegate<IsCurrentDelegate>().Invoke(this);
        }

        [ComMethodId(DXGIFactory.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumAdapters1Delegate(IntPtr thisPtr, uint adapterId, out IntPtr adapterPtr);

        [ComMethodId(DXGIFactory.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private delegate bool IsCurrentDelegate(IntPtr thisPtr);
    }
}