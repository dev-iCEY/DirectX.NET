#region Usings

using System;
using DirectX.NET.Direct2D.Interfaces;

#endregion

namespace DirectX.NET.Direct2D
{
    public class Factory : Unknown, IFactory
    {
        public Factory(IntPtr objectPtr) : base(objectPtr)
        {
        }

        public int ReloadSystemMetrics()
        {
            throw new NotImplementedException();
        }

        public void GetDesktopDpi(out float dpiX, out float dpiY)
        {
            throw new NotImplementedException();
        }
    }
}