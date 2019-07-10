#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;
using DXGI.NET.V1_2.Interfaces;

#endregion

namespace DXGI.NET.Test
{
    public static class Program
    {
        public static int Main()
        {
            int result = Dxgi1Test();
            if (result != 0)
            {
                Console.WriteLine("{0} method Failed: {1}", "Dxgi1Test", Marshal.GetExceptionForHR(result).Message);
            }

            return 0;
        }

        private static int Dxgi1Test()
        {
            int hResult = Factory.CreateFactory(out IDXGIFactory factory2);
            if (hResult != 0)
            {
                return hResult;
            }

            uint adapterId = 0;
            bool hasAnyAdapters = false;

            while (factory2.EnumAdapters(adapterId, out IDXGIAdapter adapter) == 0)
            {
                hasAnyAdapters = true;
                if (adapter.GetDesc(out AdapterDescription adapterDescription) == 0)
                {
                    Console.WriteLine("Adapter: {0}", adapterDescription.Description);

                    uint outputId = 0;
                    bool hasAnyOutput = false;
                    while (adapter.EnumOutputs(outputId, out IDXGIOutput output) == 0)
                    {
                        hasAnyOutput = true;

                        if (output.GetDesc(out OutputDescription outputDescription) == 0)
                        {
                            Console.WriteLine("Output: {0}", outputDescription.DeviceName);
                        }

                        outputId++;
                    }

                    if (!hasAnyOutput)
                    {
                        Console.WriteLine("Adapter: {0}, have no outputs.", adapterDescription.Description);
                    }
                }

                adapterId++;
            }

            if (!hasAnyAdapters)
            {
                Console.WriteLine("No adapters found!");
            }

            return Marshal.ReleaseComObject(factory2);
        }
    }
}