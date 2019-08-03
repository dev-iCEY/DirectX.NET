#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class DXGIOutput : DXGIObject, IDXGIOutput
    {
        protected new const uint LastMethodId = DXGIObject.LastMethodId + 12u;
        protected new readonly int MethodsCount = typeof(IDXGIOutput).GetMethods().Length;

        public DXGIOutput(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDesc(out DXGIOutputDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        public int GetDisplayModeList(DXGIFormat format, uint flags, ref uint numModes,
            [In, Out] DXGIModeDescription[] modesDesc = null)
        {
            return GetMethodDelegate<GetDisplayModeListDelegate>().Invoke(this, format, flags, ref numModes, modesDesc);
        }

        public int FindClosestMatchingMode(in DXGIModeDescription modeMatch, out DXGIModeDescription closestMatch,
            IUnknown device)
        {
            return GetMethodDelegate<FindClosestMatchingModeDelegate>()
                .Invoke(this, in modeMatch, out closestMatch, (Unknown) device);
        }

        public int WaitForVBlank()
        {
            return GetMethodDelegate<WaitForVBlankDelegate>().Invoke(this);
        }

        public int TakeOwnership(IUnknown device, bool isExclusive)
        {
            return GetMethodDelegate<TakeOwnershipDelegate>().Invoke(this, (Unknown) device, isExclusive);
        }

        public void ReleaseOwnership()
        {
            GetMethodDelegate<ReleaseOwnershipDelegate>().Invoke(this);
        }

        public int GetGammaControlCapabilities(out DXGIGammaControlCapabilities gammaControlCapabilities)
        {
            return GetMethodDelegate<GetGammaControlCapabilitiesDelegate>().Invoke(this, out gammaControlCapabilities);
        }

        public int SetGammaControl(in DXGIGammaControl gammaControl)
        {
            return GetMethodDelegate<SetGammaControlDelegate>().Invoke(this, in gammaControl);
        }

        public int GetGammaControl(out DXGIGammaControl gammaControl)
        {
            return GetMethodDelegate<GetGammaControlDelegate>().Invoke(this, out gammaControl);
        }

        public int SetDisplaySurface(IDXGISurface surface)
        {
            return GetMethodDelegate<SetDisplaySurfaceDelegate>().Invoke(this, (DXGISurface) surface);
        }

        public int GetDisplaySurfaceData(IDXGISurface surface)
        {
            return GetMethodDelegate<GetDisplaySurfaceDataDelegate>().Invoke(this, (DXGISurface) surface);
        }

        public int GetFrameStatistics(out DXGIFrameStatistics frameStatistics)
        {
            return GetMethodDelegate<GetFrameStatisticsDelegate>().Invoke(this, out frameStatistics);
        }

        [ComMethodId(DXGIObject.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out DXGIOutputDescription description);

        [ComMethodId(DXGIObject.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplayModeListDelegate(IntPtr thisPtr, DXGIFormat format, uint flags, ref uint numModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray)]
            DXGIModeDescription[] modesDesc = null);

        [ComMethodId(DXGIObject.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int FindClosestMatchingModeDelegate(IntPtr thisPtr, in DXGIModeDescription modeMatch,
            out DXGIModeDescription closestMatch, IntPtr concernedDevicePtr);

        [ComMethodId(DXGIObject.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int WaitForVBlankDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIObject.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TakeOwnershipDelegate(IntPtr thisPtr, IntPtr device,
            [MarshalAs(UnmanagedType.Bool)] bool isExclusive);

        [ComMethodId(DXGIObject.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseOwnershipDelegate(IntPtr thisPtr);

        [ComMethodId(DXGIObject.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlCapabilitiesDelegate(IntPtr thisPtr,
            out DXGIGammaControlCapabilities gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetGammaControlDelegate(IntPtr thisPtr,
            in DXGIGammaControl gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlDelegate(IntPtr thisPtr,
            out DXGIGammaControl gammaControlCapabilities);

        [ComMethodId(DXGIObject.LastMethodId + 10u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetDisplaySurfaceDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(DXGIObject.LastMethodId + 11u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplaySurfaceDataDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(DXGIObject.LastMethodId + 12u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFrameStatisticsDelegate(IntPtr thisPtr, out DXGIFrameStatistics frameStatistics);
    }
}