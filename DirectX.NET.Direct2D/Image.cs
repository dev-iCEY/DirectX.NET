using System;
using DirectX.NET.Direct2D.Interfaces;

namespace DirectX.NET.Direct2D
{
    public class Image : Resource, IImage
    {
        public Image(IntPtr objectPtr) : base(objectPtr)
        {
        }
    }
}