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
    ///     <inheritdoc cref="IDXGIResource" />
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.DXGIDeviceSubObject" />
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIResource" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIResource : DXGIDeviceSubObject, IDXGIResource
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 4u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIResource).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIResource" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGIResource(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Get the handle to a shared resource. The returned handle can be used to open the resource using different Direct3D
        ///     devices.
        /// </summary>
        /// <param name="sharedHandle">A pointer to a handle.</param>
        /// <returns></returns>
        public int GetSharedHandle(out IntPtr sharedHandle)
        {
            return GetMethodDelegate<GetSharedHandleDelegate>().Invoke(this, out sharedHandle);
        }

        /// <summary>
        ///     Get the expected resource usage.
        /// </summary>
        /// <param name="usage">
        ///     A out parameter to a usage flag (see <seealso cref="DXGIUsage" />). For Direct3D 10, a surface can
        ///     be used as a shader input or a render-target output.
        /// </param>
        /// <returns></returns>
        public int GetUsage(out DXGIUsage usage)
        {
            return GetMethodDelegate<GetUsageDelegate>().Invoke(this, out usage);
        }

        /// <summary>
        ///     Set the priority for evicting the resource from memory.
        /// </summary>
        /// <param name="evictionPriority">The eviction priority.</param>
        /// <returns></returns>
        /// <remarks>
        ///     The eviction priority is a memory-management variable that is used by DXGI for determining how to populate
        ///     overcommitted memory.
        ///     You can set priority levels other than the defined values when appropriate. For example, you can set a resource
        ///     with a priority level of 0x78000001 to indicate that the resource is slightly above normal.
        /// </remarks>
        public int SetEvictionPriority(DXGIResourcePriority evictionPriority)
        {
            return GetMethodDelegate<SetEvictionPriorityDelegate>().Invoke(this, evictionPriority);
        }

        /// <summary>
        ///     Get the eviction priority.
        /// </summary>
        /// <param name="evictionPriority">
        ///     A out parameter to the eviction priority, which determines when a resource can be
        ///     evicted from memory.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     The eviction priority is a memory-management variable that is used by DXGI to determine how to manage overcommitted
        ///     memory.
        ///     Priority levels other than the defined values are used when appropriate. For example, a resource with a priority
        ///     level of 0x78000001 indicates that the resource is slightly above normal.
        /// </remarks>
        public int GetEvictionPriority(out DXGIResourcePriority evictionPriority)
        {
            return GetMethodDelegate<GetEvictionPriorityDelegate>().Invoke(this, out evictionPriority);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetSharedHandleDelegate(IntPtr thisPtr, out IntPtr sharedHandlePtr);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetUsageDelegate(IntPtr thisPtr, out DXGIUsage usage);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetEvictionPriorityDelegate(IntPtr thisPtr, DXGIResourcePriority priority);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetEvictionPriorityDelegate(IntPtr thisPtr, out DXGIResourcePriority priority);
    }
}