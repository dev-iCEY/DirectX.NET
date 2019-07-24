#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    /// Describes the opacity and transformation of a brush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public ref struct BrushProperties
    {
        public float Opacity { get; set; }
        public Matrix3X2 Transform { get; set; }
    }
}