using UpgradeHelpers.VB6.Utils;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	internal static class basD3Global
	{

		// Change: [001] 11Oct96 MNB: Implemented extended error handling. Sweeping Changes.

		public static string g_sErrClass = String.Empty; // Global error class  m_sTypeId
		public static int g_nErrNumber = 0; // Global error number
		public static string g_sErrString = String.Empty; // Global error string
		public static string g_sErrModule = String.Empty; // Glbale error module
		public static string g_sErrSource = String.Empty; // Global error source   App.Name & " (VB4-32) " & m_cClassId & "." & g_sErrModule




		internal static void rsVerify(bool bPassed, string sMessage)
		{
			// Theory: If condition evaluates to FALSE, display message, otherwise do nothing.
			// Change: [000] 12Oct96 MNB: Original creation.

			if (bPassed)
			{
				Debug.WriteLine(sMessage); // Nothing
			}
			else
			{
				MessageBox.Show(sMessage, g_sErrClass + " " + g_sErrModule, MessageBoxButtons.OK, MessageBoxIcon.Question);
			}

		}


		internal static void rsAssert(bool bPassed, string sMessage)
		{
			// Theory: If debugging and condition evaluates to FALSE, display message.
			//         otherwise, trac
			// Change: [000] 12Oct96 MNB: Original creation.

			if (true)
			{
				if (bPassed)
				{
					// Nothing
				}
				else
				{
					MessageBox.Show(sMessage, g_sErrClass + " " + g_sErrModule, MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}

		}

		internal static string rsTrace(string sStrng, params object[] vParam)
		{
			// Theory: First param is a string with embedded formating commands in it.
			//         "%n", and "%x" indicate decimal and hexadecimal numbers.
			//         "\n" indicates a newline.
			// Change: [000] 12Oct96 MNB: Original creation. Incomplete.

			StringBuilder s = new StringBuilder();
			int i = 0;
			object n = 0;

			s = new StringBuilder(sStrng);
			for (i = vParam.GetLowerBound(0); i <= vParam.GetUpperBound(0); i++)
			{
				s.Append(", " + ReflectionHelper.GetPrimitiveValue<string>(vParam[i])); // temp for now
			}
			object tempRefParam = n;
			ReflectionHelper.SetPrimitiveValue(ref tempRefParam, ReflectionHelper.GetPrimitiveValue(i));

			return s.ToString();

		}



		internal static string rsGetHandle(int nClass, int hMyself)
		{
			// Theory: Generate magic handle from D3Magic, D3ClassXX, and m_hMyself
			// Change: [000] 10Oct96 MNB: Original creation.

			return Strings.Right("0000" + basD3Defs.D3Magic.ToString("X"), 4) + Strings.Right("0000" + nClass.ToString("X"), 4) + Strings.Right("00000000" + hMyself.ToString("X"), 8);

		}

		internal static int rsSetError(int nError, string sError)
		{
			// Change: [001] 12Aug96 MNB: Adding vbObjectError in again caused overflow.
			//               If nError is negative, assume it was already added in.
			//         [002] 13Sep96 MNB: Added d3FsiErr_DeleteMissingAccount.
			//         [003] 11Oct96 MNB: Extended error handling implemented.
			//         [004] 21Oct96 MNB: Misc Error not supported by Message translater.
			//         [005] 11Nov96 MNB: Implementing indexes.

			// vbObjectError = x7FFC0000 = -2147221504
			// d3SrvErr      = x7FFBFC00 = -2147220480
			// d3MiscErr     = x7FFBFB00 = -2147220224
			//  . . .        getting less negative!?!?
			// d3SysErr      = x7FFBF100 = -2147217664

			// Compensate if vbObjectError was already added in, making it negative.
			if (nError < 0)
			{ // [001]...
				nError -= Constants.vbObjectError;
			}
			if (nError < 0)
			{
				rsDebug("Illegal error number %n!", nError);
			} // ...001

			rsDebug("Error " + nError.ToString() + " in " + g_sErrClass + " " + g_sErrModule); // [003]

			// Get default global error parameters
			g_nErrNumber = nError + Constants.vbObjectError; // vbObjectError = x7FFC0000 = -2147221504
			g_sErrSource = AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()) + " (D3/NT) " + g_sErrClass + "." + g_sErrModule;
			// [005] was: (nError)
			if (g_nErrNumber == basD3Defs.d3SysErr_Unknown) {  // (4096 - 1)                         ' [004]... 
				g_sErrString = "Unknown System error. Required service may not be running." + 
					            "\r" + "Make sure either D3Fsi.Exe xor D3Vme.Exe is running.";
            }
            else if (g_nErrNumber == basD3Defs.d3SysErr_Reserved)
            {  // (4096 - 2)            ' [005]... 
				g_sErrString = "Reserved for future use.";
            }
            else if (g_nErrNumber == basD3Defs.d3SysErr_NotImp)
            {  // (4096 - 3) 
				g_sErrString = "Unimplemented feature.";
            }
            else if (g_nErrNumber == basD3Defs.d3SysErr_Obsolete)
            {  // (4096 - 4) 
				g_sErrString = "Obsolete feature."; 
            } else {
			// ...005 
				g_sErrString = sError;  // [003] was: "Miscellaneous Error" 
            }
			// ...004

			//   Select Case g_nErrNumber
			//
			//       ' Brad: generalized ODBC errors
			//       Case d3SrvErr_Access                ' d3SrvErr      = x7FFBFC00 = -2147220480
			//           g_sErrString = "Item is missing"
			//       Case d3SrvErr_Lock
			//           g_sErrString = "File/Item is locked"
			//       Case d3SrvErr_Inval
			//           g_sErrString = "invalid call"
			//       Case d3SrvErr_NoNum
			//           g_sErrString = "Not a number"
			//       Case d3SrvErr_Missing
			//           g_sErrString = "File not present"
			//       Case d3SrvErr_Conv
			//           g_sErrString = "Bad conversion"
			//       Case d3SrvErr_BadCol
			//           g_sErrString = "Bad column (attribute) name/number"
			//       Case d3SrvErr_EOF
			//           g_sErrString = "Reached end of file/item"
			//       Case d3SrvErr_CallMain
			//           g_sErrString = "Tried to call a main program as a subroutine"
			//       Case d3SrvErr_NotRoot
			//           g_sErrString = "Unable to open index"
			//       Case d3SrvErr_NotRoot
			//           g_sErrString = "Unable to open index"
			//       Case d3SrvErr_NoIndexId
			//           g_sErrString = "No Index Id found"
			//       Case d3SrvErr_BadParams
			//           g_sErrString = "Bad Parameters"
			//       Case d3SrvErr_EndList
			//           g_sErrString = "End of List"
			//
			//       ' Mike: Miscellaneous errors
			//       Case d3MiscErr_Internal                 ' d3MiscErr     = x7FFBFB00 = -2147220224
			//           g_sErrString = "Internal error"
			//       Case d3MiscErr_NotImp
			//           g_sErrString = "Not implemented"
			//       Case d3MiscErr_ODBC
			//           g_sErrString = "Domain must be 'ODBC;'"
			//       Case d3MiscErr_Misc
			//           g_sErrString = "Miscellaneous error"
			//
			//       ' Mike: File System Interface errors
			//       Case d3FsiErr_FcbMissing
			//           g_sErrString = "No FCB for the file"
			//       Case d3FsiErr_FileExist
			//           g_sErrString = "File already exist"
			//       Case d3FsiErr_FileOpenError
			//           g_sErrString = "File open error"
			//       Case d3FsiErr_FileCreateError
			//           g_sErrString = "File create error"
			//       Case d3FsiErr_FileDeleteError
			//           g_sErrString = "File delete error"
			//       Case d3FsiErr_FileReadError
			//           g_sErrString = "File read error"
			//       Case d3FsiErr_FileWriteError
			//           g_sErrString = "File write error"
			//       Case d3FsiErr_FileExtendError
			//           g_sErrString = "File size increase error"
			//       Case d3FsiErr_FileSeekError
			//           g_sErrString = "Seek in file error"
			//       Case d3FsiErr_AccountMissing
			//           g_sErrString = "Database/Account missing"
			//       Case d3FsiErr_NotDptr
			//           g_sErrString = "Item is not a D ptr"
			//       Case d3FsiErr_AccountExist
			//           g_sErrString = "Can not create account"
			//       Case d3FsiErr_FileTooLarge
			//           g_sErrString = "File too large - not permited"
			//       Case d3FsiErr_FileStillOpened           ' -2147219950 = x7FFFBxxx
			//           g_sErrString = "File is still opened"
			//       Case d3FsiErr_FileMappingError
			//           g_sErrString = "View mapping error"
			//       Case d3FsiErr_CreateFileMappingError
			//           g_sErrString = "Create file mapping error"
			//       Case d3FsiErr_ItemTruncated
			//           g_sErrString = "Large item as truncated"
			//       Case d3FsiErr_TooManyExtensions
			//           g_sErrString = "Mapped file was extended too many times"
			//       Case d3FsiErr_DptrDeleteError
			//           g_sErrString = "Cannot delete D pointer"
			//       Case d3FsiErr_TooManyClients
			//           g_sErrString = "Exceeded licensed clients"
			//       Case d3FsiErr_ObsoleteFsiVersion
			//           g_sErrString = "Old fsi version"
			//       Case d3FsiErr_FileInUse
			//           g_sErrString = "Cannot lock file for exclusive access"
			//       Case d3FsiErr_FileRenameError
			//           g_sErrString = "Cannot rename file"
			//       Case d3FsiErr_FilesNotOnSameServer
			//           g_sErrString = "Operation requires files to be on same server"
			//       Case d3FsiErr_CreateDirectoryError
			//           g_sErrString = "Failed to create a directory"
			//       Case d3FsiErr_NoMds
			//           g_sErrString = "Cannot find any MDS"
			//       Case d3FsiErr_CorruptedCellLength
			//           g_sErrString = "Corrupted group"
			//       Case d3FsiErr_DeleteMissingFile
			//           g_sErrString = "Attempt to delete a missing file (ok)"
			//       Case d3FsiErr_DeleteMissingAccount                              ' [002]
			//           g_sErrString = "Attempt to delete a missing account (ok)"   ' [002]
			//
			//       ' Mike: Bad FSI object handles
			//       Case d3FsiErr_BadNtwkHandle
			//           g_sErrString = "Bad FSI Domain object handle"
			//       Case d3FsiErr_BadAcntHandle
			//           g_sErrString = "Bad FSI Database object handle"
			//       Case d3FsiErr_BadFileHandle
			//           g_sErrString = "Bad FSI File object handle"
			//       Case d3FsiErr_BadItemHandle
			//           g_sErrString = "Bad FSI Dynamic Array object handle"
			//       Case d3FsiErr_BadListHandle
			//           g_sErrString = "Bad FSI Select List object handle"
			//       Case d3FsiErr_BadRootHandle
			//           g_sErrString = "Bad FSI Index object handle"
			//       Case d3FsiErr_BadRuleHandle
			//           g_sErrString = "Bad FSI Rule Module object handle"
			//       Case d3FsiErr_BadStrgHandle
			//           g_sErrString = "Bad FSI PString object handle"
			//       Case d3FsiErr_BadFlatHandle
			//           g_sErrString = "Bad FSI Static Array object handle"
			//
			//       Case d3SysErr_Unkown
			//           g_sErrString = "Unknow System error. " & Chr(13) & "Required service may not be running."
			//
			//       Case Else
			//           ' Internal is the default error - Include original number in desc.
			//           g_nErrNumber = d3MiscErr_Internal
			//           g_sErrString = g_sErrString & " (" & nError + vbObjectError & ")"
			//           Debug.Print "rsSetError Unrecognized " & g_sErrString
			//   End Select

			// Init the error object
			Information.Err().Clear();
			Information.Err().Number = g_nErrNumber;
			Information.Err().Source = g_sErrSource;
			Information.Err().Description = g_sErrString;

			return g_nErrNumber;
		}




		internal static void rsDebug(string sStrng, params object[] vParam)
		{
			// Theory: First param is a string with embedded formating commands in it.
			//         "%n", and "%x" indicate decimal and hexadecimal numbers.
			//         "\n" indicates a newline.
			// Change: [000] 12Oct96 MNB: Original creation. Incomplete.

			StringBuilder s = new StringBuilder();
			int i = 0;
			int n = 0;

			s = new StringBuilder(sStrng);
			for (i = vParam.GetLowerBound(0); i <= vParam.GetUpperBound(0); i++)
			{
				s.Append(", " + ReflectionHelper.GetPrimitiveValue<string>(vParam[i])); // temp for now
			}
			n = i;

			Debug.WriteLine(s.ToString());

		}
	}
}