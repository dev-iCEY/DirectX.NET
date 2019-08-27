#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    /// <inheritdoc cref="IDXGIAdapter" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIAdapter : DXGIObject, IDXGIAdapter
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 3u;

        /// <summary>
        ///     The methods count.
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIAdapter).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIAdapter" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIAdapter(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Enumerate adapter (video card) outputs.
        /// </summary>
        /// <param name="outputIndex">The index of the output.</param>
        /// <param name="output">The object to an output (see <seealso cref="IDXGIOutput" />).</param>
        /// <returns></returns>
        public int EnumOutputs(uint outputIndex, out IDXGIOutput output)
        {
            int result = GetMethodDelegate<EnumOutputsDelegate>().Invoke(this, outputIndex, out IntPtr outputPtr);
            output = result == 0 ? new DXGIOutput(outputPtr) : null;
            return result;
        }

        /// <summary>
        ///     Gets a DXGI 1.0 description of an adapter (or video card).
        /// </summary>
        /// <param name="desc">A pointer to a <seealso cref="DXGIAdapterDescription" /> structure that describes the adapter.</param>
        /// <returns></returns>
        public int GetDesc(out DXGIAdapterDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        /// <summary>
        ///     Checks to see if a device interface for a graphics component is supported by the system.
        /// </summary>
        /// <param name="interfaceName">
        ///     The GUID of the interface of the device version for which support is being checked. For example,
        ///     <example>
        ///         <code>
        /// int c = Math.Add(4, 5);
        /// if (c &gt; 10)
        /// {
        /// Console.WriteLine(c);
        /// }
        /// </code>
        ///     </example>
        /// </param>
        /// <param name="pUmdVersion"></param>
        /// <returns></returns>
        public int CheckInterfaceSupport(in Guid interfaceName, out LargeInteger pUmdVersion)
        {
            return GetMethodDelegate<CheckInterfaceSupportDelegate>().Invoke(this, in interfaceName, out pUmdVersion);
        }

        [ComMethodId(7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumOutputsDelegate(IntPtr thisPtr, uint adapterIndex, out IntPtr outputPtr);

        [ComMethodId(8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGIAdapterDescription description);

        [ComMethodId(9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CheckInterfaceSupportDelegate(IntPtr thisPtr, in Guid guid, out LargeInteger pUmdVersion);
    }
}