#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Tag
    {
        public Tag(ulong value)
        {
            Value = value;
        }

        public ulong Value;

        public static implicit operator ulong(Tag tag) =>  tag.Value;
        public static implicit operator Tag(ulong value) => new Tag(value);
    }
}