#region Usings

using System;
using System.Diagnostics;
using DirectX.NET.DXGI.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Test
{
    public static class DXGIProgram
    {
        public static void Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using (IDXGIFactory factory = new DXGIFactory())
            {
                uint adapterId = 0;

                while (factory.EnumAdapters(adapterId, out IDXGIAdapter adapter) == 0)
                {
                    using (adapter)
                    {
                        if (adapter.GetDesc(out DXGIAdapterDescription adapterDescription) == 0)
                        {
                            Console.Write("Adapter: {0}", adapterDescription.Description);

                            uint outputId = 0;
                            bool hasAnyOutputs = false;
                            while (adapter.EnumOutputs(outputId, out IDXGIOutput output) == 0)
                            {
                                using (output)
                                {
                                    if (!hasAnyOutputs)
                                    {
                                        hasAnyOutputs = true;
                                    }

                                    if (output.GetDesc(out DXGIOutputDescription outputDescription) == 0)
                                    {
                                        Console.Write(", have output #{1}: {0}", outputDescription.DeviceName, outputId);

                                        Array array = Enum.GetValues(typeof(DXGIFormat));

                                        foreach (DXGIFormat format in array)
                                        {
                                            uint numModes = 0;
                                            if (output.GetDisplayModeList(format, 0, ref numModes) != 0)
                                            {
                                                continue;
                                            }

                                            if (numModes == 0)
                                            {
                                                continue;
                                            }

                                            Console.Write(", and support Format {1} modes count: {0}\n", numModes, format);
                                            DXGIModeDescription[] modeDescriptions = new DXGIModeDescription[numModes];
                                            if (output.GetDisplayModeList(format, 0, ref numModes, modeDescriptions) != 0)
                                            {
                                                continue;
                                            }

                                            foreach (DXGIModeDescription description in modeDescriptions)
                                            {
                                                Console.WriteLine("   ├─{0}", description);
                                            }

                                            Console.WriteLine();
                                        }
                                    }
                                }

                                outputId++;
                            }

                            if (!hasAnyOutputs)
                            {
                                Console.Write(", have no outputs!");
                            }

                            Console.WriteLine();
                        }

                        adapterId++;
                    }
                }
            }

            sw.Stop();

            Console.WriteLine($"{sw.ElapsedMilliseconds}ms");

            Console.ReadKey(true);
        }
    }
}