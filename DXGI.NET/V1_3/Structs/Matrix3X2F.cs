#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET.V1_3
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public struct Matrix3X2F
    {
        [FieldOffset(0)] public MatrixFields Fields;

        public unsafe ref float this[uint row, uint column] // BUG: fix return value by ref, but this work with unsafe context.
        {
            get
            {
                if (row > 2)
                {
                    throw new ArgumentOutOfRangeException(nameof(row),
                        "A \"Matrix 3x2\" row cannot be greater than 2.");
                }

                if (column > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(column),
                        "A \"Matrix 3x2\" column cannot be greater than 1.");
                }

                fixed (Matrix3X2F* matrix = &this)
                {
                    switch (row)
                    {
                        case 0 when column == 0:
                            return ref matrix->Fields.M11;
                        case 0 when column == 1:
                            return ref matrix->Fields.M12;
                        case 1 when column == 0:
                            return ref matrix->Fields.M21;
                        case 1 when column == 1:
                            return ref matrix->Fields.M22;
                        case 2 when column == 0:
                            return ref matrix->Fields.M31;
                        case 2 when column == 1:
                            return ref matrix->Fields.M32;
                        default: throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0:N1} {1:N1} {2:N1}\n{3:N1} {4:N1} {5:N1}", Fields.M11, Fields.M21,
                Fields.M31, Fields.M12, Fields.M22, Fields.M32);
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct MatrixFields
        {
            [FieldOffset(0)] public float M11;
            [FieldOffset(4)] public float M12;
            [FieldOffset(8)] public float M21;
            [FieldOffset(12)] public float M22;
            [FieldOffset(16)] public float M31;
            [FieldOffset(20)] public float M32;
        }
    }
}