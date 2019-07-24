#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Allows the drawing state to be atomically created. This also specifies the drawing state that is saved into an
    ///     IDrawingStateBlock object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DrawingStateDescription
    {
        public AntialiasMode AntialiasMode;
        public TextAntialiasMode TextAntialiasMode;
        public Tag Tag1;
        public Tag Tag2;
        public Matrix3X2 Transform;
    }
}