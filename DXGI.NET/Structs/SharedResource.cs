﻿#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SharedResource
    {
        public IntPtr Handle{ get; set; }
    }
}