#region Usings

using System;

#endregion

namespace DirectX.NET
{
    [AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false)]
    public class ComMethodIdAttribute : Attribute
    {
        public ComMethodIdAttribute(uint id)
        {
            Id = id;
        }

        public uint Id { get; protected set; }
    }
}