#region Usings

using System;
using System.Runtime.InteropServices;
using DXGI.NET.Interfaces;
using DXGI.NET.V1_3;

#endregion

namespace DXGI.NET.Test
{
    public static class Program
    {
        public static int Main()
        {
            Matrix3X2F matrix = new Matrix3X2F
            {
                [0u, 0u] = 0.0f,
                [0u, 1u] = 1.0f,
                [1u, 0u] = 2.0f,
                [1u, 1u] = 3.0f,
                [2u, 0u] = 4.0f,
                [2u, 1u] = 5.0f
            };


            Console.WriteLine(matrix);

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