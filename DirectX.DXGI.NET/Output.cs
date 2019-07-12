#region Usings

using System;
using System.Runtime.InteropServices;
using DirectX.DXGI.NET.Interfaces;
using DirectX.NET;
using DirectX.NET.Interfaces;

#endregion

namespace DirectX.DXGI.NET
{
    public class Output : Object, IOutput
    {
        protected new const uint LastMethodId = Object.LastMethodId + 12u;
        protected new readonly int MethodsCount = typeof(IOutput).GetMethods().Length;

        public Output(IntPtr objectPtr) : base(objectPtr)
        {
            AddMethodsToVTableList(base.MethodsCount, MethodsCount);
            MethodsCount = base.MethodsCount + MethodsCount;
        }

        public int GetDesc(out OutputDescription desc)
        {
            return GetMethodDelegate<GetDescDelegate>().Invoke(this, out desc);
        }

        public int GetDisplayModeList(Format format, uint flags, ref uint numModes,
            [In, Out] ModeDescription[] modesDesc = null)
        {
            return GetMethodDelegate<GetDisplayModeListDelegate>().Invoke(this, format, flags, ref numModes, modesDesc);
        }

        public int FindClosestMatchingMode(in ModeDescription modeMatch, out ModeDescription closestMatch,
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

        public int GetGammaControlCapabilities(out GammaControlCapabilities gammaControlCapabilities)
        {
            return GetMethodDelegate<GetGammaControlCapabilitiesDelegate>().Invoke(this, out gammaControlCapabilities);
        }

        public int SetGammaControl(in GammaControl gammaControl)
        {
            return GetMethodDelegate<SetGammaControlDelegate>().Invoke(this, in gammaControl);
        }

        public int GetGammaControl(out GammaControl gammaControl)
        {
            return GetMethodDelegate<GetGammaControlDelegate>().Invoke(this, out gammaControl);
        }

        public int SetDisplaySurface(ISurface surface)
        {
            return GetMethodDelegate<SetDisplaySurfaceDelegate>().Invoke(this, (Surface) surface);
        }

        public int GetDisplaySurfaceData(ISurface surface)
        {
            return GetMethodDelegate<GetDisplaySurfaceDataDelegate>().Invoke(this, (Surface) surface);
        }

        public int GetFrameStatistics(out FrameStatistics frameStatistics)
        {
            return GetMethodDelegate<GetFrameStatisticsDelegate>().Invoke(this, out frameStatistics);
        }

        [ComMethodId(Object.LastMethodId + 1u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr thisPtr, out OutputDescription description);

        [ComMethodId(Object.LastMethodId + 2u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplayModeListDelegate(IntPtr thisPtr, Format format, uint flags, ref uint numModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray)]
            ModeDescription[] modesDesc = null);

        [ComMethodId(Object.LastMethodId + 3u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int FindClosestMatchingModeDelegate(IntPtr thisPtr, in ModeDescription modeMatch,
            out ModeDescription closestMatch, IntPtr concernedDevicePtr);

        [ComMethodId(Object.LastMethodId + 4u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int WaitForVBlankDelegate(IntPtr thisPtr);

        [ComMethodId(Object.LastMethodId + 5u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TakeOwnershipDelegate(IntPtr thisPtr, IntPtr device,
            [MarshalAs(UnmanagedType.Bool)] bool isExclusive);

        [ComMethodId(Object.LastMethodId + 6u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseOwnershipDelegate(IntPtr thisPtr);

        [ComMethodId(Object.LastMethodId + 7u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlCapabilitiesDelegate(IntPtr thisPtr,
            out GammaControlCapabilities gammaControlCapabilities);

        [ComMethodId(Object.LastMethodId + 8u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetGammaControlDelegate(IntPtr thisPtr,
            in GammaControl gammaControlCapabilities);

        [ComMethodId(Object.LastMethodId + 9u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGammaControlDelegate(IntPtr thisPtr,
            out GammaControl gammaControlCapabilities);

        [ComMethodId(Object.LastMethodId + 10u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int SetDisplaySurfaceDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(Object.LastMethodId + 11u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDisplaySurfaceDataDelegate(IntPtr thisPtr, IntPtr surfacePtr);

        [ComMethodId(Object.LastMethodId + 12u), UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFrameStatisticsDelegate(IntPtr thisPtr, out FrameStatistics frameStatistics);
    }
}