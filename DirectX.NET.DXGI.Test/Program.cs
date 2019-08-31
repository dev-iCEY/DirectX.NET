#region Usings

using System;
using System.Collections.Generic;
using DirectX.NET.DXGI.Interfaces;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.NET.DXGI.Test
{
    public static class DXGIProgram
    {
        public static int Main()
        {
            int result;

            using (IDXGIFactory1 factory1 = new DXGIFactory1())
            {
                LinkedList<IDXGIAdapter1> adapters = new LinkedList<IDXGIAdapter1>();

                uint adapterId = 0;
                while ((result = factory1.EnumAdapters1(adapterId, out IDXGIAdapter1 currentAdapter)) == 0)
                {
                    adapterId++;
                    result = currentAdapter.GetDesc1(out DXGIAdapterDescription1 adapterDescription);

                    if (result != 0)
                    {
                        foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                        {
                            dxgiAdapter1.Dispose();
                        }

                        return 1;
                    }

                    if ((adapterDescription.Flags & DXGIAdapterFlag.Software) != 0)
                    {
                        currentAdapter.Dispose();
                        continue;
                    }

                    adapters.AddLast(currentAdapter);
                }

                if (adapters.Count == 0)
                {
                    foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                    {
                        dxgiAdapter1.Dispose();
                    }

                    return 2;
                }

                FeatureLevel[] featureLevels =
                {
                    FeatureLevel.Level_12_1,
                    FeatureLevel.Level_12_0,
                    FeatureLevel.Level_11_1,
                    FeatureLevel.Level_11_0,
                    FeatureLevel.Level_10_1,
                    FeatureLevel.Level_10_0,
                    FeatureLevel.Level_9_3,
                    FeatureLevel.Level_9_2,
                    FeatureLevel.Level_9_1
                };

                result = DXGINativeMethods.D3D11CreateDevice
                (
                    adapters.First.Value,
                    DriverType.Unknown,
                    IntPtr.Zero,
                    0x2,
                    featureLevels,
                    7u,
                    out IUnknown d3d11Device,
                    out FeatureLevel selectedLevel,
                    out IUnknown d3d11DeviceContext
                );

                if (result != 0)
                {
                    foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                    {
                        dxgiAdapter1.Dispose();
                    }

                    return 3;
                }

                using (d3d11Device)
                {
                    using (IDXGIAdapter1 adapter = adapters.First.Value)
                    {
                        using (d3d11DeviceContext)
                        {
                            result = adapter.EnumOutputs(0, out IDXGIOutput output);

                            if (result != 0)
                            {
                                foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                                {
                                    dxgiAdapter1.Dispose();
                                }

                                return 4;
                            }

                            using (output)
                            {
                                result = output.QueryInterface(typeof(IDXGIOutput1).GUID, out IntPtr output1Ptr);
                                if (result != 0)
                                {
                                    foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                                    {
                                        dxgiAdapter1.Dispose();
                                    }

                                    return 5;
                                }

                                using (IDXGIOutput1 output1 = new DXGIOutput1(output1Ptr))
                                {
                                    result = output1.DuplicateOutput(d3d11Device,
                                        out IDXGIOutputDuplication duplicationOutput);

                                    if (result != 0)
                                    {
                                        foreach (IDXGIAdapter1 dxgiAdapter1 in adapters)
                                        {
                                            dxgiAdapter1.Dispose();
                                        }

                                        return 6;
                                    }

                                    duplicationOutput.GetDesc(out DXGIOutDuplDescription duplDescription);

                                    duplicationOutput.ReleaseFrame();
                                    duplicationOutput.Dispose();
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}