#region Usings

using System;
using System.Runtime.InteropServices;

#endregion

namespace DXGI.NET
{
    public class MarshalFieldAsLpArrayWithFieldId : ICustomMarshaler
    {
        private static MarshalFieldAsLpArrayWithFieldId _instance;

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            IntPtr structAddress = IntPtr.Subtract(pNativeData, IntPtr.Size);

            return null;
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            throw new NotImplementedException();
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            throw new NotImplementedException();
        }

        public void CleanUpManagedData(object managedObj)
        {
            throw new NotImplementedException();
        }

        public int GetNativeDataSize()
        {
            throw new NotImplementedException();
        }

        public static ICustomMarshaler GetInstance(string str)
        {
            return _instance ?? (_instance = new MarshalFieldAsLpArrayWithFieldId());
        }
    }
}