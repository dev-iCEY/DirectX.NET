﻿#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;

#endregion

namespace DirectX.DXGI.NET
{
    /// <summary>
    ///     <inheritdoc cref="IDXGISurface1" />
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.DXGISurface" />
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGISurface1" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGISurface1 : DXGISurface, IDXGISurface1
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = DXGISurface.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGISurface1).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGISurface1" /> class.
        /// </summary>
        /// <param name="objectPtr">The object PTR.</param>
        public DXGISurface1(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Returns a device context (DC) that allows you to render to a DXGI surface using GDI.
        /// </summary>
        /// <param name="discard">
        ///     If true the application will not preserve any rendering with GDI; otherwise, false. If false, any
        ///     previous rendering to the device context will be preserved. This flag is ideal for simply reading the device
        ///     context and not doing any rendering to the surface.
        /// </param>
        /// <param name="dcHandle">A pointer to an HDC handle that represents the current device context for GDI rendering.</param>
        /// <returns></returns>
        /// <remarks>
        ///     After you use the GetDC method to retrieve a DC, you can render to the DXGI surface using GDI. The GetDC
        ///     method readies the surface for GDI rendering and allows interoperation between DXGI and GDI technologies.
        ///     <list type="bullet">
        ///         <listheader>
        ///             <term>NOTE:</term><description>Keep the following in mind when using this method:</description>
        ///         </listheader>
        ///         <item>
        ///             You must create the surface using the D3D10_RESOURCE_MISC_GDI_COMPATIBLE flag for a surface or
        ///             use the <seealso cref="DXGISwapChainFlag.GdiCompatible" /> flag for swap chains, otherwise this method will
        ///             fail.
        ///         </item>
        ///         <item>
        ///             You must release the device and call the <seealso cref="ReleaseDc" /> method before issuing any new
        ///             Direct3D commands.
        ///         </item>
        ///         <item>This method will fail if an outstanding DC has already been created by this method. </item>
        ///         <item>
        ///             The format for the surface or swapchain must
        ///             <seealso cref="DXGIFormat.B8G8R8A8UNormSRgb" /> or <seealso cref="DXGIFormat.B8G8R8A8UNorm" />
        ///         </item>
        ///         <item>
        ///             On <seealso cref="GetDc" />, the render targer in the output merger of the Direct3D pipeline is unbound
        ///             from the surface.
        ///             OMSetRenderTargets must be called on the device prior to Direct3D rendering after GDI rendering.
        ///         </item>
        ///         <item>
        ///             Prior to resizing buffers you must release all outstanding DCs.
        ///         </item>
        ///     </list>
        ///     GetDC can also be called on the back buffer at index 0 of a swap chain by obtaining an
        ///     <seealso cref="IDXGISurface1" /> from the Swap
        ///     Chain. The following code illustrates the process.
        ///     <example>
        ///         <code>IDXGISwapChain swapChain;
        /// IDXGISurface1 surface1;
        /// ...
        /// //Setup the device and and swapchain
        /// swapChain.GetBuffer(0, typeof(IDXGISurface1).GUID, out surface1);
        /// surface1.GetDc( false, out hDC );
        /// ...
        /// //Draw on the DC using GDI
        /// ...
        /// //When finish drawing release the DC
        /// surface1.ReleaseDc( IntPtr.Zero );
        /// </code>
        ///     </example>
        /// </remarks>
        public int GetDc(bool discard, out IntPtr dcHandle)
        {
            return GetMethodDelegate<GetDcDelegate>().Invoke(this, discard, out dcHandle);
        }

        /// <summary>
        ///     Releases the GDI device context (DC) associated with the current surface and allows rendering using Direct3D.
        /// </summary>
        /// <param name="dirtyRect">
        ///     A <seealso cref="Rect" /> structure that identifies the dirty region of the surface. A dirty region
        ///     is any part of the surface that you have used for GDI rendering and that you want to preserve. This is used as a
        ///     performance hint to graphics subsystem in certain scenarios. Do not use this parameter to restrict rendering to the
        ///     specified rectangular region. Passing in NULL causes the whole surface to be considered dirty. Otherwise the area
        ///     specified by the <seealso cref="Rect" /> will be used as a performance hint to indicate what areas have been
        ///     manipulated by GDI
        ///     rendering.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        ///     Use the <seealso cref="ReleaseDc" /> method to release the DC and indicate that your application has finished all
        ///     GDI rendering to
        ///     this surface. You must call the <seealso cref="ReleaseDc" /> method before you perform addition rendering using
        ///     Direct3D.
        ///     Prior to resizing buffers all outstanding DCs must be released.
        /// </remarks>
        public int ReleaseDc(ref Rect dirtyRect)
        {
            return GetMethodDelegate<ReleaseDcDelegate>().Invoke(this, ref dirtyRect);
        }

        [ComMethodId(DXGISurface.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDcDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.Bool)] bool discard,
            out IntPtr dcHandle);

        [ComMethodId(DXGISurface.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseDcDelegate(IntPtr thisPtr, ref Rect dirtyRect);
    }
}