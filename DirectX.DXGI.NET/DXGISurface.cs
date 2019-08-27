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
    ///     <inheritdoc cref="IDXGISurface" />
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.DXGIDeviceSubObject" />
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGISurface" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGISurface : DXGIDeviceSubObject, IDXGISurface
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGIDeviceSubObject.LastMethodId + 3u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGISurface).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGISurface" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGISurface(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Get a description of the surface.
        /// </summary>
        /// <param name="surfaceDesc">A out struct to the surface description (see <seealso cref="DXGISurfaceDescription" />).</param>
        /// <returns></returns>
        public int GetDesc(out DXGISurfaceDescription surfaceDesc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out surfaceDesc);
        }

        /// <summary>
        ///     Get a struct to the data contained in the surface, and deny GPU access to the surface.
        /// </summary>
        /// <param name="mappedRect">A ref to the surface data (see <seealso cref="DXGIMappedRect" />).</param>
        /// <param name="flags">CPU read-write flags. These flags can be combined with a logical OR.</param>
        /// <returns></returns>
        /// <remarks>
        ///     Use <seealso cref="IDXGISurface.Map" /> to access a surface from the CPU. To release a mapped surface (and allow
        ///     GPU access) call <seealso cref="IDXGISurface.UnMap" />.
        /// </remarks>
        public int Map(ref DXGIMappedRect mappedRect, DXGIMap flags)
        {
            return GetMethodDelegate<MapDelegate>().Invoke(this, ref mappedRect, flags);
        }

        /// <summary>
        ///     Invalidate the ref to the surface retrieved by <seealso cref="IDXGISurface.Map" /> and re-enable GPU access to the
        ///     resource.
        /// </summary>
        /// <returns></returns>
        public int UnMap()
        {
            return GetMethodDelegate<UnMapDelegate>().Invoke(this);
        }

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGISurfaceDescription surfaceDescription);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int MapDelegate(IntPtr thisPtr, ref DXGIMappedRect rect, DXGIMap flags);

        [ComMethodId(DXGIDeviceSubObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int UnMapDelegate(IntPtr thisPtr);
    }
}