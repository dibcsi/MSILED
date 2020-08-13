using System;
using System.Runtime.InteropServices;

namespace MSILED
{
       

    public static class SDK_Class
    {
        private const string MSISDK = @".\sdkdll\MysticLight_SDK.dll";


        public static bool API_RESULT(int retCode, out string error)
        {
            if (retCode == 0)
            {
                error = null;
                return true;
            }

            MLAPI_GetErrorMessage(retCode, out error);
            return false;
        }


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetErrorMessage(
            int errorCode,
            [Out, MarshalAs(UnmanagedType.BStr)] out string description
        );



        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MLAPI_Initialize();


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetDeviceInfo(
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] devTypes,
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] ledCount
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetDeviceName(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] devName
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetDeviceNameEx(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.BStr)] out string deviceName
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedInfo(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.BStr)] out string name,
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] ledStyles
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MLAPI_GetLedName(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] deviceName
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedColor(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.U4)] out uint R,
            [Out, MarshalAs(UnmanagedType.U4)] out uint G,
            [Out, MarshalAs(UnmanagedType.U4)] out uint B
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedStyle(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.BStr)] out string style
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedMaxBright(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.U4)] out uint maxLevel
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedBright(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.U4)] out uint currentLevel
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedMaxSpeed(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.U4)] out uint maxLevel
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_GetLedSpeed(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [Out, MarshalAs(UnmanagedType.U4)] out uint currentLevel
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedColor(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.U4)] uint R,
            [In, MarshalAs(UnmanagedType.U4)] uint G,
            [In, MarshalAs(UnmanagedType.U4)] uint B
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedColors(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] ref String[] ledName,
            [MarshalAs(UnmanagedType.U4)] ref uint R,
            [MarshalAs(UnmanagedType.U4)] ref uint G,
            [MarshalAs(UnmanagedType.U4)] ref uint B
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedColorEx(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.BStr)] string ledName,
            [In, MarshalAs(UnmanagedType.U4)] uint R,
            [In, MarshalAs(UnmanagedType.U4)] uint G,
            [In, MarshalAs(UnmanagedType.U4)] uint B,
            [In, MarshalAs(UnmanagedType.U4)] uint Sync
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedColorSync(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.BStr)] string ledName,
            [In, MarshalAs(UnmanagedType.U4)] uint R,
            [In, MarshalAs(UnmanagedType.U4)] uint G,
            [In, MarshalAs(UnmanagedType.U4)] uint B,
            [In, MarshalAs(UnmanagedType.U4)] uint Sync
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedStyle(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.BStr)] string style
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedBright(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.U4)] uint level
        );


        [DllImport(MSISDK, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int MLAPI_SetLedSpeed(
            [In, MarshalAs(UnmanagedType.BStr)] string type,
            [In, MarshalAs(UnmanagedType.U4)] uint index,
            [In, MarshalAs(UnmanagedType.U4)] uint level
        );


        

    }
}
