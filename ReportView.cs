using UpgradeHelpers.VB6.Utils;
using System;
using System.Windows.Forms;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	internal partial class frmReportView
		: System.Windows.Forms.Form
	{

		public frmReportView()
			: base()
		{
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}



		private void cryView_PrintButtonClicked(Object eventSender, AxCrystalActiveXReportViewerLib10._ICRViewerEvents_PrintButtonClickedEvent eventArgs)
		{


			eventArgs.useDefault = false;
			bool MBoolean1 = mVars.cryReport.PrinterSetupEx(Handle.ToInt32()) != 0;
			if (!MBoolean1)
			{
				Application.DoEvents();
				cryView.PrintReport();
			}
			else
			{
				MessageBox.Show("Printing was aborted...", "Report printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
		private void Form_Load()
		{
			this.Icon = frmMain.DefInstance.Icon;
			cryView.EnableRefreshButton = false;
		}

		private void frmReportView_Resize(Object eventSender, EventArgs eventArgs)
		{
			if (this.WindowState != FormWindowState.Minimized)
			{
				cryView.Top = (int) 0;
				cryView.Left = (int) 0;
				cryView.Height = (int) this.ClientRectangle.Height;
				cryView.Width = (int) this.ClientRectangle.Width;
			}
		}

		public void Maximise()
		{
			WindowState = FormWindowState.Maximized;
		}

		private void frmReportView_Closed(Object eventSender, EventArgs eventArgs)
		{
			mVars.cryReport = MemoryHelper.ReleaseAndCleanObject<CRAXDRT.Report>(mVars.cryReport, null);
			mVars.cryApplication = MemoryHelper.ReleaseAndCleanObject<CRAXDRT.Application>(mVars.cryApplication, null);
			if (mVars.Hidden)
			{
				frmMain.DefInstance.Close();
				Environment.Exit(0);
			}
			MemoryHelper.ReleaseMemory();
		}
	}
}