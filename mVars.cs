using System;
using System.Runtime.InteropServices;

namespace ReportPhantom
{
    internal static class mVars
    {
        public static readonly string CRLF = Environment.NewLine;
        public static readonly string CRLF2 = Environment.NewLine + Environment.NewLine;
        public static readonly string SYS_ADM = CRLF2 + "Please contact your System Administrator.";

        public static string Comments = String.Empty;
        public static string CRFilename = String.Empty;
        public static CRAXDRT.Report cryReport = null;
        public static D3OleSrv.clsD3Connection D3Conn = null;
        public static D3OleSrv.clsD3Database D3Database = null;
        public static D3OleSrv.clsD3Environment D3Environment = null;
        public static D3OleSrv.clsD3NetDomain D3NetDomain = null;
        public static D3OleSrv.clsD3SelectList D3SelList = null;
        public static D3OleSrv.clsD3TclCommand D3TclCmd = null;
        public static D3OleSrv.clsD3VirtualMachine D3VME = null;
        public static bool Debug = false;
        public static string DSN = String.Empty;
        public static string ErrMsg = string.Empty;
        public static string ExportFilename = String.Empty;
        public static CRAXDRT.CRExportFormatType ExportType = (CRAXDRT.CRExportFormatType)0;
        public static bool Hidden = false;
        public static string INIFilename = String.Empty;
        public static bool Printed = true;
        public static string SelCrit = String.Empty;
        public static string StackTrace = String.Empty;
        public static string Title = String.Empty;
        private static CRAXDRT.Application _cryApplication = null;

        internal static CRAXDRT.Application cryApplication
        {
            get
            {
                if (_cryApplication == null)
                {
                    _cryApplication = new CRAXDRT.Application();
                }
                return _cryApplication;
            }

            set
            {
                _cryApplication = value;
            }
        }

        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        extern public static int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)]
            ref string lpSectionName, System.IntPtr lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)]
            ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString,
            int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        extern public static int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)]
            ref string lpSectionName, System.IntPtr lpKeyName, System.IntPtr lpString,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);
    }
}