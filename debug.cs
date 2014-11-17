using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
/*
* Debug and Trace classes including Exception Handling
* Courtesy of wwww.codeproject.com by Marc Clifton, 13 Oct 2002
*/
namespace ReportPhantom
{
	// The problem/reason dictionary key type
	public class DbgKey
	{
		private string key;
		
		public string Name
		{
			get {return key;}
			set {key=value;}
		}
		
		public DbgKey(string s)
		{
			key=s;
		}
	}
	
	// The problem/reason object
	public class ProblemReason
	{
		string problem;
		string[] reasons;

		public ProblemReason(string s1, string[] s2)
		{
			problem=s1;
			reasons=s2;
		}
			
		public string GetProblem()
		{
			return problem;
		}
			
		public string[] GetReasons()
		{
			return reasons;
		}
	}

	// the problem/reason collection
	public class DbgProblemCollection
	{
		private SortedList probs;
		
		public DbgProblemCollection()
		{
			probs=new SortedList();
		}
		
		public void Add(DbgKey key, string problem, string[] reasonList)
		{
			probs.Add(key.Name, new ProblemReason(problem, reasonList));
		}
		
		public bool Contains(DbgKey key)
		{
			return probs.Contains(key.Name);
		}
		
		public int Count
		{
			get
			{
				return probs.Count;
			}
		}
		
		public ProblemReason this[DbgKey key]
		{
			get
			{
				return (ProblemReason)probs[key.Name];
			}
		}
	}
	
	public class Dbg
	{
		// The debug extensions:
		private static DbgProblemCollection problems=new DbgProblemCollection();
	
		// return the problem/reason collection
		public static DbgProblemCollection Problems
		{
			get {return problems;}
		}

		[Conditional("TRACE")]
		public static void InitializeUnhandledExceptionHandler()
		{
			AppDomain.CurrentDomain.UnhandledException+=new UnhandledExceptionEventHandler(DbgExceptionHandler);
		}

		public static void DbgExceptionHandler(object sender, UnhandledExceptionEventArgs args)
		{
			Exception e=(Exception) args.ExceptionObject;
			Trace.WriteLine("Exception: "+e.Message);
			MessageBox.Show(
				"A fatal problem has occurred.\n"+e.Message,
				"Program Stopped",
				MessageBoxButtons.OK,
				MessageBoxIcon.Stop,
				MessageBoxDefaultButton.Button1);
			Trace.Close();
			Process.GetCurrentProcess().Kill();
		}
		
		// The Warn method is enabled in release mode
		[Conditional("TRACE")]
		public static void Warn(bool b, DbgKey key)
		{
			Trace.WriteLine("Warning: "+key.Name);
			if (problems.Contains(key))
			{
				string explanation=GetExplanation(key);
				MessageBox.Show(
					explanation,
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1);
			}
			else
			{
				MessageBox.Show(
					"A problem has occurred that should be corrected.\n\nReference: "+key.Name,
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1);
			}
		}

		// The Assert method is enabled in release mode
		[Conditional("TRACE")]
		public static void Assert(bool b, DbgKey key)
		{
			Trace.WriteLine("Assert: "+key.Name);
			if (problems.Contains(key))
			{
				string explanation=GetExplanation(key);
				MessageBox.Show(
					explanation,
					"Program Stopped",
					MessageBoxButtons.OK,
					MessageBoxIcon.Stop,
					MessageBoxDefaultButton.Button1);
			}
			else
			{
				MessageBox.Show(
					"A fatal problem has occurred.\n\nReference: "+key.Name,
					"Program Stopped",
					MessageBoxButtons.OK,
					MessageBoxIcon.Stop,
					MessageBoxDefaultButton.Button1);
			}
			Trace.Close();
			Process.GetCurrentProcess().Kill();
		}

		[Conditional("TRACE")]
		public static void LogOutput(string fn)
		{
            if (mVars.Debug)
            {
                if (File.Exists(fn))
                {
                    File.Delete(fn);
                }
                Trace.Listeners.Add(new TextWriterTraceListener(fn));
                DateTime dt = DateTime.Now;
                Trace.WriteLine("Debug Logging Initialised: " + dt.ToString());
                Trace.WriteLine("=======================================================================================");
            }
        }

		// Flag the debugger to break at the next instruction.
		[Conditional("DEBUG")]
		public static void Break()
		{
			Debugger.Break();
		}

		// Put together the list of possible reasons for the particular problem.
		private static string GetExplanation(DbgKey key)
		{
			ProblemReason ps=problems[key];
			string explanation=ps.GetProblem()+"\n\nPossible reasons:\n\n";
			int n=1;
			foreach (string sol in ps.GetReasons())
			{
				explanation+="  "+n.ToString()+". "+sol+"\n";
				++n;
			}
			return explanation;
		}

		/*
		 * Mirror the current Debug and Trace class functionality.
		 */
		
		public static bool AutoFlush
		{
			get {return Debug.AutoFlush;}
			set {Debug.AutoFlush=value;}
		}
		
		public static int IndentLevel
		{
			get {return Debug.IndentLevel;}
			set {Debug.IndentLevel=value;}
		}
		
		public static int IndentSize
		{
			get {return Debug.IndentSize;}
			set {Debug.IndentSize=value;}
		}
		
		public static TraceListenerCollection Listeners
		{
			get {return Trace.Listeners;}
		}
		
		[Conditional("TRACE")]
		public static void Assert(bool b)
		{
			Trace.Assert(b);
		}
		
		[Conditional("TRACE")]
		public static void Assert(bool b, string s)
		{
			Trace.Assert(b, s);
		}
		
		[Conditional("TRACE")]
		public static void Assert(bool b, string s1, string s2)
		{
			Trace.Assert(b, s1, s2);
		}

		[Conditional("TRACE")]
		public static void Fail(string s)
		{
			Trace.Fail(s);
		}
		
		[Conditional("TRACE")]
		public static void Fail(string s1, string s2)
		{
			Trace.Fail(s1, s2);
		}
		
		[Conditional("TRACE")]		
		public static void Close()
		{
			Trace.Close();
		}
		
		[Conditional("TRACE")]		
		public static void Flush()
		{
			Trace.Flush();
		}
		
		[Conditional("TRACE")]		
		public static void Indent()
		{
            if (mVars.Debug)
            {
                Trace.Indent();
            }
		}
		
		[Conditional("TRACE")]		
		public static void Unindent()
		{
            if (mVars.Debug)
            {
                Trace.Unindent();
            }
		}
		
		// Write
		
		[Conditional("DEBUG")]
		public static void Write(object obj)
		{
			Debug.Write(obj);
		}
		
		[Conditional("DEBUG")]		
		public static void Write(string s)
		{
			Debug.Write(s);
		}
		
		[Conditional("DEBUG")]		
		public static void Write(object obj, string s)
		{
			Debug.Write(obj, s);
		}
		
		[Conditional("DEBUG")]		
		public static void Write(string s1, string s2)
		{
			Debug.Write(s1, s2);
		}
		
		// WriteIf
		
		[Conditional("DEBUG")]		
		public static void WriteIf(bool b, object obj)
		{
			Debug.WriteIf(b, obj);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteIf(bool b, string s)
		{
			Debug.WriteIf(b, s);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteIf(bool b, object obj, string s)
		{
			Debug.WriteIf(b, obj, s);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteIf(bool b, string s1, string s2)
		{
			Debug.WriteIf(b, s1, s2);
		}
		
		// WriteLine
		
		[Conditional("TRACE")]		
		public static void WriteLine(object obj)
		{
            if (mVars.Debug)
            {
                Trace.WriteLine(obj);
            }
		}
		
		[Conditional("TRACE")]		
		public static void WriteLine(string s)
		{
            if (mVars.Debug)
            {
                DateTime dt = DateTime.Now;
                Trace.WriteLine(dt.ToString() + "  " + s);
            }
		}
		
		[Conditional("DEBUG")]		
		public static void WriteLine(object obj, string s)
		{
			Debug.WriteLine(obj, s);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteLine(string s1, string s2)
		{
			Debug.WriteLine(s1, s2);
		}
		
		// WriteLineIf
		
		[Conditional("DEBUG")]		
		public static void WriteLineIf(bool b, object obj)
		{
			Debug.WriteLineIf(b, obj);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteLineIf(bool b, string s)
		{
			Debug.WriteLineIf(b, s);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteLineIf(bool b, object obj, string s)
		{
			Debug.WriteLineIf(b, obj, s);
		}
		
		[Conditional("DEBUG")]		
		public static void WriteLineIf(bool b, string s1, string s2)
		{
			Debug.WriteLineIf(b, s1, s2);
		}
		
	}
}