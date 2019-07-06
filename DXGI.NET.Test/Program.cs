#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;

#endregion

namespace DXGI.NET.Test
{
    public static class Program
    {
        public static int Main()
        {
            int result = Factory.CreateFactory(out IDXGIFactory factory);

            if (result != 0)
            {
                Exception ex = Marshal.GetExceptionForHR(result);
                if (ex != null)
                {
                    throw ex;
                }
            }

            LinkedList<IDXGIAdapter> adapters = new LinkedList<IDXGIAdapter>();

            uint adapterId = 0;
            while (factory.EnumAdapters(adapterId, out IDXGIAdapter adapter) == 0)
            {
                adapters.AddLast(adapter);
                adapterId++;
            }

            adapterId = 0;

            foreach (IDXGIAdapter adapter in adapters)
            {
                result = adapter.GetDesc(out AdapterDesc adapterDesc);
                if (result != 0)
                {
                    continue;
                }

                Console.WriteLine("| Adapter: {0} | {1}", adapterId, adapterDesc.HumanDescription);
                uint outputId = 0;
                while (adapter.EnumOutputs(outputId, out IDXGIOutput output) == 0)
                {
                    if (output.GetDesc(out OutputDesc outputDesc) == 0)
                    {
                        Console.WriteLine("| Output: {0,2} | {1}", outputId, outputDesc.HumanDeviceName);
                    }

                    outputId++;
                }
                adapterId++;
            }

            return Marshal.ReleaseComObject(factory); // if there is is non Zero value, we need to do something with interfaces.
        }
    }
}