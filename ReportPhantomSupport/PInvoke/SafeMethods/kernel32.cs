using System.Runtime.InteropServices;
using System;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantomSupport.PInvoke.SafeNative
{
	public static class kernel32
	{

		public static int GetPrivateProfileString(ref string lpSectionName, string lpKeyName, ref string lpDefault, ref string lpReturnedString, int nSize, ref string lpFileName)
		{
			int result = 0;
			IntPtr tmpPtr = Marshal.StringToHGlobalAnsi(lpKeyName);
			try
			{
				result = ReportPhantomSupport.PInvoke.UnsafeNative.kernel32.GetPrivateProfileString(ref lpSectionName, tmpPtr, ref lpDefault, ref lpReturnedString, nSize, ref lpFileName);
				lpKeyName = Marshal.PtrToStringAnsi(tmpPtr);
			}
			finally
			{
					Marshal.FreeHGlobal(tmpPtr);
			}
			return result;
		}
		public static void Sleep(int dwMilliseconds)
		{
			ReportPhantomSupport.PInvoke.UnsafeNative.kernel32.Sleep(dwMilliseconds);
		}
		public static int WritePrivateProfileString(ref string lpSectionName, string lpKeyName, string lpString, ref string lpFileName)
		{
			int result = 0;
			IntPtr tmpPtr = Marshal.StringToHGlobalAnsi(lpKeyName);
			IntPtr tmpPtr2 = Marshal.StringToHGlobalAnsi(lpString);
			try
			{
				result = ReportPhantomSupport.PInvoke.UnsafeNative.kernel32.WritePrivateProfileString(ref lpSectionName, tmpPtr, tmpPtr2, ref lpFileName);
				lpString = Marshal.PtrToStringAnsi(tmpPtr2);
				lpKeyName = Marshal.PtrToStringAnsi(tmpPtr);
			}
			finally
			{
					Marshal.FreeHGlobal(tmpPtr);
					Marshal.FreeHGlobal(tmpPtr2);
			}
			return result;
		}
	}
}