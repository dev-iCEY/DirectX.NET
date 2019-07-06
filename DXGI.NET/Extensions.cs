#region Usings

using System.Collections.Generic;
using System.Linq;

#endregion

namespace DXGI.NET
{
    public static class Extensions
    {

        public static char[] ToCharArray(this IEnumerable<short> source)
        {
            return source.TakeWhile(arg => arg != 0).Select(@ushort => (char)@ushort).ToArray();
        }

        public static char[] ToCharArray(this IEnumerable<ushort> source)
        {
            return source.TakeWhile(arg => arg != 0).Select(@ushort => (char)@ushort).ToArray();
        }
    }
}