#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     <inheritdoc cref="IDXGIDisplayControl" />
    /// </summary>
    /// <seealso cref="Unknown" />
    /// <seealso cref="IDXGIDisplayControl" />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DXGIDisplayControl : Unknown, IDXGIDisplayControl
    {
        /// <summary>
        ///     The last method identifier
        /// </summary>
        protected new const uint LastMethodId = Unknown.LastMethodId + 2u;

        /// <summary>
        ///     The methods count
        /// </summary>
        protected new readonly int MethodsCount = typeof(IDXGIDisplayControl).GetMethods().Length;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DXGIDisplayControl" /> class by unmanaged pointer to
        ///     <seealso cref="DirectX.NET.Interfaces.IUnknown" />.
        /// </summary>
        /// <param name="objectPtr">Unmanaged pointer to COM object.</param>
        /// <exception cref="ArgumentException">IUnknown object pointer cannot be IntPtr.Zero or null. - objectPtr</exception>
        public DXGIDisplayControl(IntPtr objectPtr) :
            base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Retrieves a Boolean value that indicates whether the operating system's stereoscopic 3D display behavior is
        ///     enabled.
        /// </summary>
        /// <returns>
        ///     <seealso cref="IDXGIDisplayControl.IsStereoEnabled" /> returns <seealso langword="true" /> when the operating
        ///     system's stereoscopic 3D
        ///     display behavior is enabled and <seealso langword="false" /> when this behavior is disabled.
        /// </returns>
        public bool IsStereoEnabled()
        {
            return GetMethodDelegate<IsStereoEnabledDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Set a Boolean value to either enable or disable the operating system's stereoscopic 3D display behavior.
        /// </summary>
        /// <param name="enabled">
        ///     A Boolean value that either enables or disables the operating system's stereoscopic 3D display
        ///     behavior. <seealso langword="true" /> enables the operating system's stereoscopic 3D display behavior and
        ///     <seealso langword="false" /> disables it.
        /// </param>
        /// <remarks>
        ///     Platform Update for Windows 7:  On Windows 7 or Windows Server 2008 R2 with the Platform Update for Windows 7
        ///     installed, SetStereoEnabled doesn't change stereoscopic 3D display behavior because stereoscopic 3D display
        ///     behavior isn’t available with the Platform Update for Windows 7. For more info about the Platform Update for
        ///     Windows 7, see Platform Update for Windows 7.
        /// </remarks>
        public void SetStereoEnabled(bool enabled)
        {
            GetMethodDelegate<SetStereoEnabledDelegate>().Invoke(this, enabled);
        }


        [ComMethodId(Unknown.LastMethodId + 1u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private delegate bool IsStereoEnabledDelegate(IntPtr thisPtr);

        [ComMethodId(Unknown.LastMethodId + 2u),
         UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetStereoEnabledDelegate(IntPtr thisPtr, [MarshalAs(UnmanagedType.Bool)] bool enabled);
    }
}