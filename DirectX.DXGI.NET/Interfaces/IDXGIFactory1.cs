#region Usings

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#endregion

namespace DirectX.DXGI.NET.Interfaces
{
    /// <summary>
    ///     The <seealso cref="IDXGIFactory1" /> interface implements methods for generating DXGI objects.
    /// </summary>
    /// <seealso cref="DirectX.DXGI.NET.Interfaces.IDXGIFactory" />
    [Guid("770aae78-f26f-4dba-a829-253c83d1b387"), SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface IDXGIFactory1 : IDXGIFactory
    {
        /// <summary>
        ///     Enumerates both adapters (video cards) with or without outputs.
        /// </summary>
        /// <param name="adapterId">The index of the adapter to enumerate.</param>
        /// <param name="adapter1">
        ///     The out object as <seealso cref="IDXGIAdapter1" /> interface at the position specified by the Adapter
        ///     parameter. This parameter must not be NULL.
        /// </param>
        /// <remarks>
        ///     The set of adapters available in the system is enumerated when the factory is created. Therefore, if you change the
        ///     adapters in a system, you must destroy and recreate the <seealso cref="IDXGIFactory1" /> object. The number of
        ///     adapters adapters in a
        ///     system changes when you add or remove a display card, or dock or undock a laptop.
        ///     When the <seealso cref="EnumAdapters1" /> method succeeds and the adapter interface is filled, the adapters
        ///     reference count will be
        ///     incremented. When you are finished with the adapter interface, be sure to call the Release method to decrement the
        ///     reference count before you destroy the pointer.
        ///     The local adapter with output on which the Desktop primary is displayed is returned first, followed by other
        ///     adapter(s) with outputs, then adapter(s) without outputs.
        ///     The following code example demonstrates how to enumerate adapters using the EnumAdapters1 method.
        ///     <example>
        ///         <code>
        ///         uint i = 0;
        ///         IDXGIAdapter1 adapter;
        ///         List&lt;IDXGIAdapter&gt; adapters = new List&lt;IDXGIAdapter1&gt;
        ///         while(factory.EnumAdapters1(i, out adapter) != DXGI_ERROR_NOT_FOUND)
        ///         {
        ///             adapters.Add(pAdapter);
        ///             ++i;
        ///         }
        ///         </code>
        ///     </example>
        /// </remarks>
        int EnumAdapters1(uint adapterId, out IDXGIAdapter1 adapter1);

        /// <summary>
        ///     Informs an application of the possible need to re-enumerate adapters.
        /// </summary>
        /// <returns>
        ///     <c>false</c>, if a new adapter is becoming available or the current adapter is going away. <c>true</c>, no adapter
        ///     changes.
        ///     IsCurrent returns <c>false</c> to inform the calling application to re-enumerate adapters.
        /// </returns>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsCurrent();
    }
}