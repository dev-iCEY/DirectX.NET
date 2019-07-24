#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4X3
    {
        public float _11, _12, _13;
        public float _21, _22, _23;
        public float _31, _32, _33;
        public float _41, _42, _43;
    }
}