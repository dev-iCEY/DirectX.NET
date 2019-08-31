#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     An <seealso cref="IDXGIDevice" /> interface implements a derived class for DXGI objects that produce image data.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIDevice : DXGIObject, IDXGIDevice
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 5u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIDevice).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIDevice" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIDevice(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, ref MethodsCount);
        }

        /// <summary>
        ///     Returns the adapter for the specified device.
        /// </summary>
        /// <param name="adapter">
        ///     The address of an <seealso cref="IDXGIAdapter" /> interface pointer to the adapter. This
        ///     parameter must not be <seealso langword="null" />.
        /// </param>
        public int GetAdapter(out IDXGIAdapter adapter)
        {
            int result = GetMethodDelegate<GetAdapterDelegate>().Invoke(this, out IntPtr adapterPtr);
            adapter = result == 0 ? new DXGIAdapter(adapterPtr) : null;
            return result;
        }

        /// <summary>
        ///     This method is used internally and should not be called directly by your application code.
        /// </summary>
        /// <param name="surfaceDesc">A <seealso cref="DXGISurfaceDescription" /> structure that describes the surface.</param>
        /// <param name="numSurfaces">The number of surfaces to create.</param>
        /// <param name="usage">A <seealso cref="DXGIUsage" /> flag that specifies how the surface is expected to be used.</param>
        /// <param name="sharedResource">
        ///     An optional pointer to a <seealso cref="DXGISharedResource" /> structure that represents
        ///     shared resource information for opening views of such resources.
        /// </param>
        /// <param name="surfaces">
        ///     The address of an <seealso cref="IDXGISurface" /> interface pointer to the first created
        ///     surface.
        /// </param>
        /// <returns></returns>
        public int CreateSurface(in DXGISurfaceDescription surfaceDesc, uint numSurfaces, DXGIUsage usage,
            in DXGISharedResource sharedResource,
            out IDXGISurface[] surfaces)
        {
            int result = GetMethodDelegate<CreateSurfaceDelegate>().Invoke(this, in surfaceDesc, numSurfaces, usage,
                in sharedResource, out IntPtr[] surfacePtrArray);
            surfaces = (IDXGISurface[]) (result == 0 ? surfacePtrArray.Select(ptr => new DXGISurface(ptr)) : null);
            return result;
        }

        /// <summary>
        ///     Gets the residency status of an array of resources.
        /// </summary>
        /// <param name="resources">An array of <seealso cref="IDXGIResource" /> interfaces.</param>
        /// <param name="residencyStatus">
        ///     An array of <seealso cref="DXGIResidency" /> flags. Each element describes the residency
        ///     status for corresponding element in the ppResources argument array.
        /// </param>
        /// <param name="numResources">
        ///     The number of resources in the resources argument array and residencyStatus argument
        ///     array.
        /// </param>
        /// <returns>
        ///     Returns S_OK if successfull; otherwise, returns D3DERR_DEVICEREMOVED (see D3DERR for more information),
        ///     E_INVALIDARG, or E_POINTER (see WinError.h for more information).
        /// </returns>
        public int QueryResourceResidency(IDXGIResource[] resources, out DXGIResidency[] residencyStatus,
            uint numResources)
        {
            IntPtr[] pointers = resources.Select<IDXGIResource, IntPtr>(resource => (DXGIResource) resource).ToArray();
            return GetMethodDelegate<QueryResourceResidencyDelegate>()
                .Invoke(this, in pointers, out residencyStatus, numResources);
        }

        /// <summary>
        ///     Sets the GPU thread priority
        /// </summary>
        /// <param name="priority">
        ///     A value that specifies the required GPU thread priority. This value must be between -7 and 7,
        ///     inclusive, where 0 represents normal priority.
        /// </param>
        /// <returns>Return S_OK if successful; otherwise, returns E_INVALIDARG if the Priority parameter is invalid.</returns>
        public int SetGpuThreadPriority(int priority)
        {
            return GetMethodDelegate<SetGpuThreadPriorityDelegate>().Invoke(this, priority);
        }

        /// <summary>
        ///     Gets the GPU thread priority.
        /// </summary>
        /// <param name="priority">
        ///     A pointer to a variable that receives a value that indicates the current GPU thread priority.
        ///     The value will be between -7 and 7, inclusive, where 0 represents normal priority.
        /// </param>
        /// <returns></returns>
        public int GetGpuThreadPriority(out int priority)
        {
            return GetMethodDelegate<GetGpuThreadPriorityDelegate>().Invoke(this, out priority);
        }

        [ComMethodId(DXGIObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetAdapterDelegate(IntPtr thisPtr, out IntPtr adapterPtr);

        [ComMethodId(DXGIObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CreateSurfaceDelegate(IntPtr thisPtr, in DXGISurfaceDescription surfaceDesc,
            uint numSurfaces,
            DXGIUsage usage, in DXGISharedResource sharedResource,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
            out IntPtr[] surfacePtr);

        [ComMethodId(DXGIObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int QueryResourceResidencyDelegate(IntPtr thisPtr,
            [MarshalAs(UnmanagedType.LPArray)] in IntPtr[] ppResources,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
            out DXGIResidency[] residencyStatus,
            uint numResources);

        [ComMethodId(DXGIObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetGpuThreadPriorityDelegate(IntPtr thisPtr, int priority);

        [ComMethodId(DXGIObject.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGpuThreadPriorityDelegate(IntPtr thisPtr, out int priority);
    }
}