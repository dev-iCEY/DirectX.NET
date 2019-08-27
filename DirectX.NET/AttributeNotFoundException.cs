#region Usings

using System;

#endregion

namespace DirectX.NET
{
    public class AttributeNotFoundException : Exception
    {
        public AttributeNotFoundException()
        {
        }

        public AttributeNotFoundException(string message)
            : base(message)
        {
        }

        public AttributeNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}