#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}