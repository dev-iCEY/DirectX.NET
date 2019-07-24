#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET
{
    [StructLayout(LayoutKind.Sequential), SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public struct Matrix3X2
    {
        public float M11;
        public float M12;
        public float M21;
        public float M22;
        public float M31;
        public float M32;

        public IEnumerable<IEnumerable<float>> AsEnumerable
        {
            get
            {
                for (int row = 0; row < 3; row++)
                {
                    yield return ((float[][])this)[row];
                }
            }
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return M11;
                    case 1:
                        return M12;
                    case 2:
                        return M21;
                    case 3:
                        return M22;
                    case 4:
                        return M31;
                    case 5:
                        return M32;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        M11 = value;
                        break;
                    case 1:
                        M12 = value;
                        break;
                    case 2:
                        M21 = value;
                        break;
                    case 3:
                        M22 = value;
                        break;
                    case 4:
                        M31 = value;
                        break;
                    case 5:
                        M32 = value;
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public float this[int row, int column]
        {
            get
            {
                switch (row)
                {
                    case 0 when column == 0:
                        return M11;
                    case 0 when column == 1:
                        return M12;
                    case 1 when column == 0:
                        return M21;
                    case 1 when column == 1:
                        return M22;
                    case 2 when column == 0:
                        return M31;
                    case 2 when column == 1:
                        return M32;
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                switch (row)
                {
                    case 0 when column == 0:
                        M11 = value;
                        break;
                    case 0 when column == 1:
                        M12 = value;
                        break;
                    case 1 when column == 0:
                        M21 = value;
                        break;
                    case 1 when column == 1:
                        M22 = value;
                        break;
                    case 2 when column == 0:
                        M31 = value;
                        break;
                    case 2 when column == 1:
                        M32 = value;
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        public static implicit operator float[,](Matrix3X2 matrix)
        {
            float[,] result = new float[3, 2];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 2; column++)
                {
                    result[row, column] = matrix[row, column];
                }
            }

            return result;
        }

        public static implicit operator float[][](Matrix3X2 matrix)
        {
            float[][] result = new float[3][];

            for (int row = 0; row < 3; row++)
            {
                result[row] = new float[2];
                for (int column = 0; column < 2; column++)
                {
                    result[row][column] = matrix[row, column];
                }
            }

            return result;
        }
    }
}