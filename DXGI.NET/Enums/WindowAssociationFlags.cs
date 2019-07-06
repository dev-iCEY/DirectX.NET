#region Usings

using System;

#endregion

namespace DXGI.NET
{
    [Flags]
    public enum WindowAssociationFlags : uint
    {
        NoWindowChanges = 1 << 0,
        NoAltEnter = 1 << 1,
        NoPrintScreen = 1 << 2,
        Valid = 0x7
    }
}