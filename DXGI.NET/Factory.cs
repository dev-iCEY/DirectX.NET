#region Usings

using System;
using DXGI.NET.Interfaces;
using DXGI.NET.V1_2.Interfaces;

#endregion

namespace DXGI.NET
{
    public static class Factory
    {
        public static
#if !DEXP
            int
#else
            void
#endif
            CreateFactory<TFactory>(out TFactory factory)
        {
            Type factoryType = typeof(TFactory);
            Guid riid = factoryType.GUID;

            if (riid == typeof(IDXGIFactory).GUID)
            {
#if !DEXP
                int result =
#endif
                    NativeMethods.CreateDXGIFactory(ref riid, out object tmpFactory);

                factory = (TFactory) tmpFactory;

                return result;
            }

            if (riid == typeof(IDXGIFactory1).GUID || riid == typeof(IDXGIFactory2).GUID)
            {
#if !DEXP
                int result =
#endif
                    NativeMethods.CreateDXGIFactory1(ref riid, out object tmpFactory);

                factory = (TFactory) tmpFactory;

                return result;
            }

            throw new ArgumentException(
                $"Type \"{factoryType.FullName}\" is not valid for this method. Please use IDXGIFactory or IDXGIFactory1 or IDXGIFactory2.",
                nameof(factory));
        }
    }
}