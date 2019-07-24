#region Usings

using System.Runtime.InteropServices;

#endregion

namespace DirectX.NET.Direct2D
{
    /// <summary>
    ///     Allows additional parameters for factory creation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FactoryOptions
    {
        /// <summary>
        ///     Requests a certain level of debugging information from the debug layer. This
        ///     parameter is ignored if the debug layer DLL is not present.
        /// </summary>
        public DebugLevel DebugLevel;
    }
}