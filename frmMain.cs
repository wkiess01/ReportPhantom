using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	internal partial class frmMain
		: System.Windows.Forms.Form
	{

		public frmMain()
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

		private void chkExportToExcel_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			chkToScreen.CheckState = chkExportToExcel.CheckState;
		}

		private void chkExportToPDF_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			chkToScreen.CheckState = chkExportToPDF.CheckState;
		}

		private void cmdCRFilename_Click(Object eventSender, EventArgs eventArgs)
		{
			CommDiagOpen.DefaultExt = "rpt";
			if (Strings.Len(txtCRFilename.Text) == 0)
			{
				CommDiagOpen.FileName = "*.rpt";
			}
			else
			{
				CommDiagOpen.FileName = txtCRFilename.Text;
			}
			CommDiagOpen.Filter = "Crystal Report Files (*.rpt)|*.rpt|All Files (*.*)|*.*";
			CommDiagOpen.FilterIndex = 2;
			CommDiagOpen.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
			CommDiagOpen.FilterIndex = 1;
			CommDiagOpen.ShowDialog();
			txtCRFilename.Text = CommDiagOpen.FileName;
			if (Strings.Right(txtCRFilename.Text, 4).ToLower() != ".rpt")
			{
				txtCRFilename.Text = txtCRFilename.Text + ".rpt";
			}
		}

		private void cmdExit_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
			frmMain.DefInstance = null;
			Environment.Exit(0);
		}

		private void cmdPrint_Click(Object eventSender, EventArgs eventArgs)
		{
			fraMsg.Visible = true;
			Application.DoEvents();
			this.Cursor = Cursors.WaitCursor;
			cmdPrint.Enabled = false;
            lstStatus.Visible = true;

			msubs.PrintReport();

			this.Cursor = Cursors.Default;
			cmdPrint.Enabled = true;
			fraMsg.Visible = false;
            lstStatus.Visible = false;
		}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dbg.WriteLine("Closing Main form and exiting...");
            Dbg.Close();
        }

        private void Form_Load()
        {
            if (!mVars.Hidden)
            {
                txtCRFilename.Text = mVars.CRFilename;
                txtSelCrit.Text = mVars.SelCrit;
                txtTitle.Text = mVars.Title;
                txtComments.Text = mVars.Comments;
                txtDSN.Text = mVars.DSN;
                lstStatus.Visible = false;
            }
        }

		private void txtComments_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			mVars.Comments = txtComments.Text;
		}

		private void txtCRFilename_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			mVars.CRFilename = txtCRFilename.Text;
		}

		private void txtSelCrit_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			mVars.SelCrit = txtSelCrit.Text;
		}

		private void txtTitle_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			mVars.Title = txtTitle.Text;
		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}