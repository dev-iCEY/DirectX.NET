#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_2
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PresentParameters
    {
        private readonly uint _dirtyRectsCount;
        private readonly IntPtr _dirtyRects;

        public IEnumerable<Rect> DirtyRects
        {
            get
            {
                for (int i = 0; i < _dirtyRectsCount; i++)
                {
                    yield return Marshal.PtrToStructure<Rect>(IntPtr.Add(_dirtyRects, i * Marshal.SizeOf<Rect>()));
                }
            }
        }

        [field: MarshalAs(UnmanagedType.LPStruct)]
        public Rect ScrollRect { get; }

        [field: MarshalAs(UnmanagedType.LPStruct)]
        public Point ScrollOffset { get; }
    }
}