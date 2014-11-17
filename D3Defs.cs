using Microsoft.VisualBasic;
using System;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	internal static class basD3Defs
	{



		// Global D3 Constants
		// ===================
		// This module is reserved and should not be modified.
		//
		// (use  '; // comment  at the end of each line )
		//
		// [001] 05Aug96 MNB: Added unknow system error as maximum error code 4095.
		// [002] 12Aug96 MNB: Fixed d3MiscErr_NotImp was colliding with _Internal.
		// [003] 21Sep96 MNB: Added BadVmeHandle, BadTclHandle, BadCatHandle.
		// [004] 09Oct96 MNB: Added Hex(D3Magic), D3NoHandle, and D3 Object types as strings.
		//                    They should numbers and equated in the enum in PickObj.h,
		//                    and converted to strings in within VB. Oh well for now.
		//       10Oct96 MNB: Const Strings not supported in VC++, so translated D3Defs.h
		//                    would not compile. Eric commented out my changes until I
		//                    could do them as described above.
		// [005] 16Oct96 MNB: Added constants for clsD3TclCommand brResults and
		//                    clsD3Environment brTclFlags and clsD3VirtualMachine brSystem(15).
		// [006] 08Nov96 MNB: Added more constants for VB and error reporting
		// [007] 19Nov96 es:  Added BMR errors
		// [008] 21Nov96 MNB: Added more VB constants

		// [005]...
		// clsD3TclCommand/clsD3VirtualMachine brResults values
		public const int D3ExecuteNoResults = 0; //; // Neither
		public const int D3ExecuteCapturing = 1; //; // Capturing only
		public const int D3ExecuteReturning = 2; //; // Returning only
		public const int D3ExecuteWithBoth = 3; //; // Capturing and Returning

		// clsD3Envronment brTclFlags and clsD3VirtualMachine brSystem(15)
		public const int D3TclFlag_AFlg = -2147483647; //; // 0x80000000 Abort on error
		public const int D3TclFlag_DFlg = 268435456; //; // 0x10000000 Debug immediate
		public const int D3TclFlag_EFlg = 134217728; //; // 0x08000000 Error go debug
		public const int D3TclFlag_SFlg = 8192; //; // 0x00002000 Suppress ErrMsg
		// Other flags AFlg - ZFlg can also be defined.
		// ...[005]

		// [008]...
		// clsD3DynamicArray delimeters  *** Note: Must use Chr$(n) ***
		public const int D3SM = 255; //; // Segment Mark
		public const int D3AM = 254; //; // Attribute Mark
		public const int D3VM = 253; //; // Value Mark
		public const int D3SVM = 252; //; // Sub Value Mark
		public const int D3SB = 251; //; // Start Buffer

		// clsD3File brCreateIndex() values
		public const bool D3ReplaceIndex = true; //; // bOverwrite
		public const bool D3PreserveIndex = false; //; // bOverwrite
		public const bool D3EntireIndex = true; //; // bEntirety
		public const bool D3PartialIndex = false; //; // bEntirety

		// clsD3Index brKey() values     *** Note: Must use Chr$(n) ***
		public const int D3IndexCompKey = 67; //; // brKey("C"), brFindFirst()
		public const int D3IndexLastKey = 76; //; // brKey("L"), brFindLast()
		public const int D3IndexNextKey = 78; //; // brKey("N"), brFindNext()
		public const int D3IndexPrevKey = 80; //; // brKey("P"), brFindPrevious()
		public const int D3IndexRtrnKey = 82; //; // brKey("R")
		public const int D3IndexVrfyKey = 86; //; // brKey("V")
		public const int D3IndexXtraKey = 88; //; // brKeyX()

		// clsD3VirtualMachine brSelect() values
		public const bool D3SelectPrimary = false; //; // vbSecondary
		public const bool D3SelectSecondary = true; //; // vbSecondary
		// ...[008]

		// [004]...
		// Magic word that flags this as a D3 object handle
		public const int D3Magic = 54077; //; // xD33D
		// Class word (major/minor nibbles) type of object
		public const int D3ClassDA = 272; //; // x0110 1 aPickItem
		public const int D3ClassRM = 274; //; // x0112 2 aPBModule
		public const int D3ClassSL = 275; //; // x0113 3 aPickList
		public const int D3ClassFV = 512; //; // x0200 4 aPickFile (abstract)
		public const int D3ClassVM = 771; //; // x0303 5 aPickRpc
		public const int D3ClassTCL = 771; //; // x0303 6 aPickRpc
		public const int D3ClassDB = 2048; //; // x0800 7 aPickDatabase
		public const int D3ClassND = 2304; //; // x0900 8 aPickDomain
		public const int D3ClassDE = 61696; //; // xf100 9 clsD3Environement
		public const int D3ClassConn = 61952; //; // xf200 a clsD3Conn (super object)
		public const int D3ClassSA = 62208; //; // xf300 b clsD3StaticArray
		public const int D3ClassTTY = 62464; //; // xf400 c clsD3TtyManager
		public const int D3ClassTD = 62720; //; // xf500 d clsD3TapeDevice
		public const int D3ClassBT = 62976; //; // xf600 e clsD3BTreeIndex
		public const int D3ClassRC = 63232; //; // xf700 f clsD3RuleCatalog
		// Empty long indicates no valid handle to object.
		public const int D3NoHandle = 0; //; // x00000000
		// ...[004]

		public const int brDeadRule = 0; //; //
		public const int brLocalRule = 1; //; //
		public const int brRemoteRule = -1; //; //

		public const bool brTrue = true; //; //
		public const bool brFalse = false; //; //

		// D3 General Constants
		// ====================
		public const int d3Nothing = 0; //; //

		// D3 File constants
		// =================
		public const int d3File_AcntLevel = 1; //; //
		public const int d3File_DictLevel = 2; //; //
		public const int d3File_DataLevel = 3; //; //
		public const int d3File_Direct = 1; //; //
		public const int d3File_Hashed = 0; //; //
		public const int d3File_FrameSize = 4096; //; //
		public const bool d3File_Ansi = false; //; //
		public const bool d3File_Unicode = true; //; //
		public const bool d3File_CaseSensitive = false; //; //
		public const bool d3File_CaseInsensitive = true; //; //

		// D3 Item constants
		public const int D3Item_NoWaiting = 0; //; // False/NoTime
		public const int D3Item_AmWaiting = -1; //; // True/Forever
		public const bool D3Item_ReadLocked = true; //; // ReadU
		public const bool d3Item_ReadNoLock = false; //; // Read
		public const bool d3Item_writenlock = true; //; // Write
		public const bool d3Item_WriteNoLock = false; //; // Write{U}

		// D3 NT List constants
		public const int d3List_TypeNone = -1; //; // Initialize
		public const int d3List_TypeAcnt = 0; //; // d3ND.Select
		public const int d3List_TypeFile = 1; //; // d3DB.Select  (d3DB.SelectDict(d3FV))
		public const int d3List_TypeDict = 2; //; // d3FV.Select
		public const int d3List_TypeItem = 3; //; // d3DA.Select
		public const int d3List_TypeTCL = 4; //; // d3TCL.Select

		// D3 Exceptions Classes
		// =====================
		// Exceptions classes must NOT exceeed 11
		public const int d3SrvClsErr = 0; //; // Common services errors
		public const int d3MiscClsErr = 1; //; // Misc errors
		public const int d3FsiClsErr = 2; //; // D3/NT File System
		public const int d3VmeClsErr = 3; //; // D3/NT VME
		public const int d3BrmClsErr = 4; //; // D3/NT Business Rule Module
		public const int d3RpcClsErr = 5; //; // D3/NT RPC
		public const int d3RegClsErr = 6; //; // D3/NT Registry
		public const int d3TapeClsErr = 7; //; // D3/NT Tape
		public const int d3SpoolClsErr = 8; //; // D3/NT Spooler
		public const int d3StrClsErr = 9; //; // D3/NT String exception
		public const int d3VirtClsErr = 10; //; // D3/NT Virtual exception (place holder)
		public const int d3SysClsErr = 11; //; // D3/NT Underlying Host exception


		// D3 Exceptions Values
		// ====================
		public const int d3BaseErr = 1024; //; // Base of D3 error codes
		public static readonly int d3SrvErr = Constants.vbObjectError + d3BaseErr + 0; //; // Common server errors
		public static readonly int d3MiscErr = Constants.vbObjectError + d3BaseErr + d3MiscClsErr * 256; //; // Misc errors
		public static readonly int d3FsiErr = Constants.vbObjectError + d3BaseErr + d3FsiClsErr * 256; //; // D3/NT File System
		public static readonly int d3VmeErr = Constants.vbObjectError + d3BaseErr + d3VmeClsErr * 256; //; // D3/NT VME
		public static readonly int d3BrmErr = Constants.vbObjectError + d3BaseErr + d3BrmClsErr * 256; //; // D3/NT Business Rule Module
		public static readonly int d3RpcErr = Constants.vbObjectError + d3BaseErr + d3RpcClsErr * 256; //; // D3/NT RPC
		public static readonly int d3RegErr = Constants.vbObjectError + d3BaseErr + d3RegClsErr * 256; //; // D3/NT Registry
		public static readonly int d3TapeErr = Constants.vbObjectError + d3BaseErr + d3TapeClsErr * 256; //; // D3/NT Tape
		public static readonly int d3SpoolErr = Constants.vbObjectError + d3BaseErr + d3SpoolClsErr * 256; //; // D3/NT Spooler
		public static readonly int d3StrErr = Constants.vbObjectError + d3BaseErr + d3StrClsErr * 256; //; // D3/NT Strings
		public static readonly int d3VirtErr = Constants.vbObjectError + d3BaseErr + d3VirtClsErr * 256; //; // D3/NT Virtual
		public static readonly int d3SysErr = Constants.vbObjectError + d3BaseErr + d3SysClsErr * 256; //; // D3/NT System


		// D3 General Service Errors
		// =========================
		// These errors are the most likely errors to be found in a VB app
		public static readonly int d3SrvErr_NFile = d3SrvErr + 1; //; //  Too many opened files
		public static readonly int d3SrvErr_Access = d3SrvErr + 2; //; //  Item not present or no access to it
		public static readonly int d3SrvErr_Lock = d3SrvErr + 5; //; //  File/Item is locked
		public static readonly int d3SrvErr_Inval = d3SrvErr + 6; //; //  invalid Call
		public static readonly int d3SrvErr_NoNum = d3SrvErr + 7; //; //  Not a Number
		public static readonly int d3SrvErr_BadF = d3SrvErr + 8; //; //  File not opened
		public static readonly int d3SrvErr_Missing = d3SrvErr + 9; //; //  File not present
		public static readonly int d3SrvErr_Conv = d3SrvErr + 10; //; //  Conversion Error
		public static readonly int d3SrvErr_BadCol = d3SrvErr + 11; //; //  Bad column Number/Name
		public static readonly int d3SrvErr_EOF = d3SrvErr + 15; //; //  Reached end-of-file/item
		public static readonly int d3SrvErr_CallMain = d3SrvErr + 17; //; //  Tried to call main as sub
		public static readonly int d3SrvErr_NotRoot = d3SrvErr + 19; //; //  No index found on root statement
		public static readonly int d3SrvErr_NoIndexId = d3SrvErr + 22; //; //  No more index entries
		public static readonly int d3SrvErr_BadParams = d3SrvErr + 34; //; //  Wrong parameter number
		public static readonly int d3SrvErr_EndList = d3SrvErr + 36; //; //  End of List


		// D3 Miscellaneous Errors
		// =======================
		public static readonly int d3MiscErr_Internal = d3MiscErr + 1; //; //  Internal Library Failure
		public static readonly int d3MiscErr_NotImp = d3MiscErr + 2; //; //  [002] Not Implemented
		public static readonly int d3MiscErr_ODBC = d3MiscErr + 3; //; //  Domain must be "ODBC;"
		public static readonly int d3MiscErr_Misc = d3MiscErr + 99; //; //  Misc Error


		// D3/NT File System Interface Errors
		// ==================================
		// Most 'normal' exceptions from the FSI are reported as 'General Services Errors'
		// The following codes are normally trapped by the underlying OCX or automation
		// servers.
		public static readonly int d3FsiErr_FcbMissing = d3FsiErr + 3; //; // No FCB for the file
		public static readonly int d3FsiErr_FileExist = d3FsiErr + 6; //; // File already exist
		public static readonly int d3FsiErr_FileOpenError = d3FsiErr + 7; //; // Underlying IO error
		public static readonly int d3FsiErr_FileCreateError = d3FsiErr + 8; //; // Underlying IO error
		public static readonly int d3FsiErr_FileDeleteError = d3FsiErr + 9; //; // Underlying IO error
		public static readonly int d3FsiErr_FileReadError = d3FsiErr + 10; //; // Underlying IO error
		public static readonly int d3FsiErr_FileWriteError = d3FsiErr + 11; //; // Underlying IO error
		public static readonly int d3FsiErr_FileExtendError = d3FsiErr + 12; //; // File size increase error
		public static readonly int d3FsiErr_FileSeekError = d3FsiErr + 13; //; // Seek in file error
		public static readonly int d3FsiErr_AccountMissing = d3FsiErr + 14; //; // Database/Account missing
		public static readonly int d3FsiErr_NotDptr = d3FsiErr + 15; //; // Item is not a D ptr
		public static readonly int d3FsiErr_AccountExist = d3FsiErr + 16; //; // Cannt create account
		public static readonly int d3FsiErr_FileTooLarge = d3FsiErr + 17; //; // Not permitted
		public static readonly int d3FsiErr_FileStillOpened = d3FsiErr + 18; //; // File is still opened
		public static readonly int d3FsiErr_FileMappingError = d3FsiErr + 19; //; // View mapping error
		public static readonly int d3FsiErr_CreateFileMappingError = d3FsiErr + 20; //; // Create file mapping error
		public static readonly int d3FsiErr_ItemTruncated = d3FsiErr + 21; //; // Large item as truncated
		public static readonly int d3FsiErr_TooManyExtensions = d3FsiErr + 22; //; // Mapped file was extended too many times
		public static readonly int d3FsiErr_DptrDeleteError = d3FsiErr + 23; //; // Cannot delete D pointer
		public static readonly int d3FsiErr_TooManyClients = d3FsiErr + 24; //; // Exceeded licensed clients
		public static readonly int d3FsiErr_ObsoleteFsiVersion = d3FsiErr + 25; //; // Old fsi version
		public static readonly int d3FsiErr_FileInUse = d3FsiErr + 26; //; // Cannot lock file for exclusive access
		public static readonly int d3FsiErr_FileRenameError = d3FsiErr + 27; //; // Cannot rename file
		public static readonly int d3FsiErr_FilesNotOnSameServer = d3FsiErr + 28; //; // Operation requires files to be on same server
		public static readonly int d3FsiErr_CreateDirectoryError = d3FsiErr + 30; //; // Failed to create a directory
		public static readonly int d3FsiErr_NoMds = d3FsiErr + 31; //; // Cannot find any MDS
		public static readonly int d3FsiErr_CorruptedCellLength = d3FsiErr + 32; //; // Corrupted group
		public static readonly int d3FsiErr_DeleteMissingFile = d3FsiErr + 33; //; // Attempt to delete a missing file (ok)
		public static readonly int d3FsiErr_DeleteMissingAccount = d3FsiErr + 34; //; // Attempt to delete a missing account (ok)
		public static readonly int d3FsiErr_CallCorrMissing = d3FsiErr + 35; //; // Missing sub in a CALL file correlative
		public static readonly int d3FsiErr_CallCorrError = d3FsiErr + 36; //; // Sub error in a CALL file correlative
		public static readonly int d3FsiErr_MaxQptrDepth = d3FsiErr + 37; //; // Sub error in a CALL file correlative


		// D3OleCtl.OCX (only) throws these
		public static readonly int d3FsiErr_BadNtwkHandle = d3FsiErr + 101; //; // Null NetDomain handle
		public static readonly int d3FsiErr_BadAcntHandle = d3FsiErr + 102; //; //      Database handle
		public static readonly int d3FsiErr_BadFileHandle = d3FsiErr + 103; //; //       File Var. handle
		public static readonly int d3FsiErr_BadItemHandle = d3FsiErr + 104; //; //       aPickItem handle
		public static readonly int d3FsiErr_BadListHandle = d3FsiErr + 105; //; //       Select List handle
		public static readonly int d3FsiErr_BadRootHandle = d3FsiErr + 106; //; //      BTree Root handle
		public static readonly int d3FsiErr_BadRuleHandle = d3FsiErr + 107; //; //       Rule Module handle
		public static readonly int d3FsiErr_BadStrgHandle = d3FsiErr + 108; //; //      aPickString handle
		public static readonly int d3FsiErr_BadFlatHandle = d3FsiErr + 109; //; //      Static Array handle
		public static readonly int d3FsiErr_BadAmCount = d3FsiErr + 110; //; //
		public static readonly int d3FsiErr_BadVmCount = d3FsiErr + 111; //; //
		public static readonly int d3FsiErr_BadSvmCount = d3FsiErr + 112; //; //
		public static readonly int d3FsiErr_BadVmeHandle = d3FsiErr + 113; //; // [003]
		public static readonly int d3FsiErr_BadTclHandle = d3FsiErr + 113; //; // [003]
		public static readonly int d3FsiErr_BadCatHandle = d3FsiErr + 113; //; // [003]



		// D3 VME Errors
		// =============
		// These errors are normally not seen by VB applications.
		public static readonly int d3VmeErr_UdefDllEntry = d3VmeErr + 1; //; // Missing entry table in  DLL
		public static readonly int d3VmeErr_UdefDll = d3VmeErr + 2; //; // Missing DLL
		public static readonly int d3VmeErr_MutexPibsCreateError = d3VmeErr + 3; //; // Failed to create PIBS mutex
		public static readonly int d3VmeErr_MutexPibsWaitError = d3VmeErr + 4; //; // Failed to wait on PIBS mutex
		public static readonly int d3VmeErr_MutexPibsWaitTimeout = d3VmeErr + 5; //; // Timed out on gettting lock on pibs
		public static readonly int d3VmeErr_MutexPibsReleaseError = d3VmeErr + 6; //; // Fialed to release pibs mutex
		public static readonly int d3VmeErr_DiskError = d3VmeErr + 7; //; // Disk error
		public static readonly int d3VmeErr_NoFreePib = d3VmeErr + 8; //; // All pibs are busy
		public static readonly int d3VmeErr_AlreadyExists = d3VmeErr + 9; //; // VME is already started or initialized
		public static readonly int d3VmeErr_NotAPickProcess = d3VmeErr + 10; //; // The thread has no pick object
		public static readonly int d3VmeErr_BadPib = d3VmeErr + 11; //; // invalid PIB
		public static readonly int d3VmeErr_GetConsoleModeError = d3VmeErr + 12; //; // Cannot get the console mode
		public static readonly int d3VmeErr_SetConsoleModeError = d3VmeErr + 13; //; // Cannot program the console
		public static readonly int d3VmeErr_InvalidConsole = d3VmeErr + 14; //; // Cannot get handles to stdin/out
		public static readonly int d3VmeErr_TLSAllocError = d3VmeErr + 15; //; // Cannot allocate TLS
		public static readonly int d3VmeErr_TLSSetError = d3VmeErr + 16; //; // Cannot store data in TLS
		public static readonly int d3VmeErr_TLSNotSet = d3VmeErr + 17; //; // TLS not initialized
		public static readonly int d3VmeErr_EventCreateError = d3VmeErr + 18; //; // Event creation error
		public static readonly int d3VmeErr_BadPibSetProcess = d3VmeErr + 19; //; // No PCB attached to an object
		public static readonly int d3VmeErr_UdefMode = d3VmeErr + 20; //; // Undefined call to a mode
		public static readonly int d3VmeErr_ComOpenFail = d3VmeErr + 22; //; // Cannot open COM port
		public static readonly int d3VmeErr_ComIOError = d3VmeErr + 23; //; // COM IO error
		public static readonly int d3VmeErr_PrinterError = d3VmeErr + 24; //; // Printer parameter error
		public static readonly int d3VmeErr_AbortedShutdown = d3VmeErr + 25; //; // Shutdown was aborted
		public static readonly int d3VmeErr_RemoteNotSup = d3VmeErr + 26; //; // Not suported on remote connections


		// D3 RPC Errors
		// =============
		// These errors are normally not visible from a user VB application. They
		// may be used by some system applets
		public static readonly int d3RpcErr_SetServiceStatusError = d3RpcErr + 1; //; // Cannot update status
		public static readonly int d3RpcErr_StartdispatcherError = d3RpcErr + 2; //; // Cannot start Service Control dispatcher
		public static readonly int d3RpcErr_CannotInstall = d3RpcErr + 3; //; // Generic " Unable to install Service"
		public static readonly int d3RpcErr_OpenServiceError = d3RpcErr + 4; //; // Cannot open service
		public static readonly int d3RpcErr_OpenSCManagerError = d3RpcErr + 5; //; // Cannot access Service Control Manager
		public static readonly int d3RpcErr_CreateServiceError = d3RpcErr + 6; //; // Cannot create service
		public static readonly int d3RpcErr_BindingError = d3RpcErr + 7; //; // Binding error
		public static readonly int d3RpcErr_ComposeError = d3RpcErr + 8; //; // StringBindingCompose error
		public static readonly int d3RpcErr_RegisterIfError = d3RpcErr + 9; //; // Cannot register interface
		public static readonly int d3RpcErr_InqBindingErr = d3RpcErr + 10; //; // Inq Binding error
		public static readonly int d3RpcErr_BindingExportErr = d3RpcErr + 11; //; // Export binding failed
		public static readonly int d3RpcErr_BindingUnexportErr = d3RpcErr + 12; //; // UnExport binding failed
		public static readonly int d3RpcErr_BindinVectorFreeErr = d3RpcErr + 13; //; // Cannot free binding vector
		public static readonly int d3RpcErr_BindingImportError = d3RpcErr + 14; //; // Import from name service error
		public static readonly int d3RpcErr_WaitServerListenError = d3RpcErr + 15; //; // RpcMgmtWaitServerListenError
		public static readonly int d3RpcErr_NoBinding = d3RpcErr + 16; //; // Cannot get a valid binding handle
		public static readonly int d3RpcErr_RtException = d3RpcErr + 17; //; // RPC run time exception
		public static readonly int d3RpcErr_NoProtocol = d3RpcErr + 18; //; // No available protocol
		public static readonly int d3RpcErr_ListenError = d3RpcErr + 19; //; // RpcServerListen error
		public static readonly int d3RpcErr_EpRegisterError = d3RpcErr + 20; //; // RpcEpRegister Error
		public static readonly int d3RpcErr_UnregisterIfErr = d3RpcErr + 21; //; // RpcUnregisterIf error
		public static readonly int d3RpcErr_MultipleInstance = d3RpcErr + 22; //; // Multiple instance of server
		public static readonly int d3RpcErr_ServerLock = d3RpcErr + 23; //; // Global server mutex locked
		public static readonly int d3RpcErr_ServerUnlock = d3RpcErr + 24; //; // Failed to release server mutex
		public static readonly int d3RpcErr_StartServiceError = d3RpcErr + 25; //; // Cannot start service
		public static readonly int d3RpcErr_DeleteServiceError = d3RpcErr + 26; //; // Cannot delete service
		public static readonly int d3RpcErr_ServerNotActivated = d3RpcErr + 27; //; // Cannot delete service


		// D3 Host System Errors
		// =====================
		public static readonly int d3SysErr_MissingVersId = d3SysErr + 1; //; // Missing resource id in .exe
		public static readonly int d3SysErr_TlsAllocation = d3SysErr + 2; //; // Can not allocate Thread Local Storage
		public static readonly int d3SysErr_TlsGet = d3SysErr + 3; //; // Can not access Thread Local Storage
		public static readonly int d3SysErr_TlsSet = d3SysErr + 4; //; // Can not update Thread Local Storage

		public static readonly int d3SysErr_Obsolete = d3SysErr + 252; //; // [006] 4092, or -4 or x7FC
		public static readonly int d3SysErr_NotImp = d3SysErr + 253; //; // [006] 4093, or -3 or x7FD
		public static readonly int d3SysErr_Reserved = d3SysErr + 254; //; // [006] 4094, or -2 or x7FE
		public static readonly int d3SysErr_Unknown = d3SysErr + 255; //; // [001] 4095, or -1 or x7FF


		// D3 Flash Interpreter Errors
		// ===========================
		public static readonly int d3BrmErr_AllocPbError = d3BrmErr + 1; //; // Failed to allocate memory
		public static readonly int d3BrmErr_RelocPbError = d3BrmErr + 2; //; // Relocation error
		public static readonly int d3BrmErr_UnhandledDebugInput = d3BrmErr + 3; //; // Runtime class does not support debugger input
		public static readonly int d3BrmErr_UnhandledInput = d3BrmErr + 4; //; // Runtime class does not support input
		public static readonly int d3BrmErr_MissingObject = d3BrmErr + 5; //; // No flash object

		// General Constants

		public const int gD3Error_OleServer = 1;
		public const int d3ENErr_OpenFail = 2;
		public const int d3NDErr_OpenFail = 3;

		// Constants that seemed to be missed by Raining Data ...
		// WHK 23/07/2004

		public const bool d3ExactItemCount = true;
	}
}