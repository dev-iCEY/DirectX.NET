#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.NET.Direct2D.Interfaces;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     The root brush interface. All brushes can be used to fill or pen a geometry.
    /// </summary>
    public class Brush : Resource, IBrush
    {
        protected new const uint LastMethodId = Resource.LastMethodId + 4u;
        protected new readonly int MethodsCount = typeof(IBrush).GetMethods().Length;

        public Brush(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        /// <summary>
        ///     Sets the opacity for when the brush is drawn over the entire fill of the brush.
        /// </summary>
        public void SetOpacity(float opacity)
        {
            GetMethodDelegate<SetOpacityDelegate>().Invoke(this, opacity);
        }

        /// <summary>
        ///     Sets the transform that applies to everything drawn by the brush.
        /// </summary>
        public void SetTransform(in Matrix3X2 transform)
        {
            GetMethodDelegate<SetTransformDelegate>().Invoke(this, in transform);
        }

        /// <summary>
        ///     Get the opacity for when the brush is drawn over the entire fill of the brush.
        /// </summary>
        public float GetOpacity()
        {
            return GetMethodDelegate<GetOpacityDelegate>().Invoke(this);
        }

        /// <summary>
        ///     Get the transform that applies to everything drawn by the brush.
        /// </summary>
        public void GetTransform(out Matrix3X2 transform)
        {
            GetMethodDelegate<GetTransformDelegate>().Invoke(Pointer, out transform);
        }

        [ComMethodId(Resource.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetOpacityDelegate(IntPtr thisPtr, float opacity);

        [ComMethodId(Resource.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void SetTransformDelegate(IntPtr thisPtr, in Matrix3X2 transform);

        [ComMethodId(Resource.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate float GetOpacityDelegate(IntPtr thisPtr);

        [ComMethodId(Resource.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void GetTransformDelegate(IntPtr thisPtr, out Matrix3X2 transform);
    }
}