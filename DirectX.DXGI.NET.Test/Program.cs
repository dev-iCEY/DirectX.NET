#region Usings

using System;
using DirectX.DXGI.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET.Test
{
    public static class Program
    {
        public static void Main()
        {
            IDXGIFactory factory = new DXGIFactory();
            using (factory)
            {
                uint adapterId = 0;

                while (factory.EnumAdapters(adapterId, out IDXGIAdapter adapter) == 0)
                {
                    using (adapter)
                    {
                        if (adapter.GetDesc(out AdapterDescription adapterDescription) == 0)
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

                                    if (output.GetDesc(out OutputDescription outputDescription) == 0)
                                    {
                                        Console.Write(", have output #{1}: {0}", outputDescription.DeviceName,
                                            outputId);
                                        uint numModes = 0;
                                        if (output.GetDisplayModeList(Format.R8G8B8A8UNorm, 0, ref numModes) == 0)
                                        {
                                            Console.Write(", and support Format R8G8B8A8UNorm modes count: {0}\n",
                                                numModes);
                                            ModeDescription[] modeDescriptions = new ModeDescription[numModes];
                                            if (output.GetDisplayModeList(Format.R8G8B8A8UNorm, 0, ref numModes,
                                                    modeDescriptions) == 0)
                                            {
                                                foreach (ModeDescription description in modeDescriptions)
                                                {
                                                    Console.WriteLine
                                                    (
                                                        "\t{0}x{1} @ {2} hz",
                                                        description.Width,
                                                        description.Height,
                                                        description.RefreshRate.Numerator /
                                                        description.RefreshRate.Denominator
                                                    );
                                                }
                                            }
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

            Console.ReadKey(true);
        }
    }
}