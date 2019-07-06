#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SharedResource
    {
        public readonly IntPtr Handle;

        public SharedResource(IntPtr handle)
        {
            Handle = handle;
        }
    }
}