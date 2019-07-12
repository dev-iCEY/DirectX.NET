#region Usings

using System;

#endregion

namespace DirectX.NET
{
    [AttributeUsage(AttributeTargets.Delegate)]
    public class ComMethodIdAttribute : Attribute
    {
        public ComMethodIdAttribute(uint id)
        {
            Id = id;
        }

        public uint Id { get; protected set; }
    }
}