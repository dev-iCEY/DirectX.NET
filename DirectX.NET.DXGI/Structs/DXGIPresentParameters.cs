#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.DXGI
{
    /// <summary>
    ///     Describes information about present that helps the operating system optimize presentation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class DXGIPresentParameters : IDisposable
    {
        /// <summary>
        ///     The number of updated rectangles that you update in the back buffer for the presented frame. The operating system
        ///     uses this information to optimize presentation. You can set this member to 0 to indicate that you update the whole
        ///     frame.
        /// </summary>
        public uint DirtyRectsCount { get; set; }

        private IntPtr dirtyRectsPtr;

        /// <summary>
        /// </summary>
        public Rect[] DirtyRects
        {
            get
            {
                Rect[] rects = new Rect[DirtyRectsCount];
                for (int i = 0; i < DirtyRectsCount; i++)
                {
                    rects[i] = Marshal.PtrToStructure<Rect>(IntPtr.Add(dirtyRectsPtr, i * IntPtr.Size));
                }

                return rects;
            }
            set
            {
                if (dirtyRectsPtr != IntPtr.Zero)
                {
                    ReleaseUnmanagedResources();
                }

                int size = value.Length;

                IntPtr tmpPtr = IntPtr.Zero;
                Marshal.AllocCoTaskMem(size * Marshal.SizeOf<Rect>());

                IntPtr[] pointers = {tmpPtr};

                for (int i = 0; i < value.Length; i++)
                {
                    GCHandle handle = GCHandle.Alloc(value[i], GCHandleType.Pinned);
                    byte[] bytes = new byte[Marshal.SizeOf<Rect>()];
                    Marshal.Copy(handle.AddrOfPinnedObject(), bytes, 0, Marshal.SizeOf<Rect>());
                    Marshal.Copy(IntPtr.Add(tmpPtr, i * Marshal.SizeOf<Rect>()), bytes, 0, 1);
                    handle.Free();
                }
            }


        }

        public IntPtr ScrollRect;
        public IntPtr ScrollOffset;

        private void ReleaseUnmanagedResources()
        {
            if (dirtyRectsPtr == IntPtr.Zero)
            {
                return;
            }

            Marshal.FreeCoTaskMem(dirtyRectsPtr);

            dirtyRectsPtr = IntPtr.Zero;
        }

        /// <summary>Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.</summary>
        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        /// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
        ~DXGIPresentParameters()
        {
            ReleaseUnmanagedResources();
        }
    }
}