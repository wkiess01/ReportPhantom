using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	partial class frmMain
	{

		#region "Upgrade Support "
		private static frmMain m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmMain DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmMain CreateInstance()
		{
			frmMain theInstance = new frmMain();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "lstStatus", "lblMsg", "fraMsg", "chkExportToPDF", "chkExportToExcel", "cmdExit", "txtDSN", "txtComments", "txtTitle", "CommDiagOpen", "chkToScreen", "cmdPrint", "txtSelCrit", "cmdCRFilename", "txtCRFilename", "lblDSN", "lblComments", "lblTitle", "lblSelCrit", "lblCRFilename", "lblHeading", "listBoxHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ListBox lstStatus;
		public System.Windows.Forms.Label lblMsg;
		public System.Windows.Forms.Panel fraMsg;
		public System.Windows.Forms.CheckBox chkExportToPDF;
		public System.Windows.Forms.CheckBox chkExportToExcel;
		public System.Windows.Forms.Button cmdExit;
		public System.Windows.Forms.TextBox txtDSN;
		public System.Windows.Forms.TextBox txtComments;
		public System.Windows.Forms.TextBox txtTitle;
		public System.Windows.Forms.OpenFileDialog CommDiagOpen;
		public System.Windows.Forms.CheckBox chkToScreen;
		public System.Windows.Forms.Button cmdPrint;
		public System.Windows.Forms.TextBox txtSelCrit;
		public System.Windows.Forms.Button cmdCRFilename;
		public System.Windows.Forms.TextBox txtCRFilename;
		public System.Windows.Forms.Label lblDSN;
		public System.Windows.Forms.Label lblComments;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblSelCrit;
		public System.Windows.Forms.Label lblCRFilename;
		public System.Windows.Forms.Label lblHeading;
		private UpgradeHelpers.VB6.Gui.ListBoxHelper listBoxHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.fraMsg = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.chkExportToPDF = new System.Windows.Forms.CheckBox();
            this.chkExportToExcel = new System.Windows.Forms.CheckBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtDSN = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.CommDiagOpen = new System.Windows.Forms.OpenFileDialog();
            this.chkToScreen = new System.Windows.Forms.CheckBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.txtSelCrit = new System.Windows.Forms.TextBox();
            this.cmdCRFilename = new System.Windows.Forms.Button();
            this.txtCRFilename = new System.Windows.Forms.TextBox();
            this.lblDSN = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelCrit = new System.Windows.Forms.Label();
            this.lblCRFilename = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.listBoxHelper1 = new UpgradeHelpers.VB6.Gui.ListBoxHelper(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fraMsg.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStatus
            // 
            this.lstStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lstStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstStatus.Location = new System.Drawing.Point(16, 72);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxHelper1.SetSelectionMode(this.lstStatus, System.Windows.Forms.SelectionMode.One);
            this.lstStatus.Size = new System.Drawing.Size(489, 225);
            this.lstStatus.TabIndex = 19;
            // 
            // fraMsg
            // 
            this.fraMsg.BackColor = System.Drawing.Color.Green;
            this.fraMsg.Controls.Add(this.lblMsg);
            this.fraMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.fraMsg.ForeColor = System.Drawing.Color.Blue;
            this.fraMsg.Location = new System.Drawing.Point(96, 120);
            this.fraMsg.Name = "fraMsg";
            this.fraMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraMsg.Size = new System.Drawing.Size(321, 105);
            this.fraMsg.TabIndex = 17;
            this.fraMsg.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Green;
            this.lblMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Yellow;
            this.lblMsg.Location = new System.Drawing.Point(32, 40);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsg.Size = new System.Drawing.Size(261, 33);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.Text = "Producing Report ...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkExportToPDF
            // 
            this.chkExportToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkExportToPDF.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkExportToPDF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkExportToPDF.Location = new System.Drawing.Point(16, 312);
            this.chkExportToPDF.Name = "chkExportToPDF";
            this.chkExportToPDF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkExportToPDF.Size = new System.Drawing.Size(97, 25);
            this.chkExportToPDF.TabIndex = 16;
            this.chkExportToPDF.Text = "Export to PDF";
            this.chkExportToPDF.UseVisualStyleBackColor = false;
            this.chkExportToPDF.CheckStateChanged += new System.EventHandler(this.chkExportToPDF_CheckStateChanged);
            // 
            // chkExportToExcel
            // 
            this.chkExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkExportToExcel.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkExportToExcel.Location = new System.Drawing.Point(144, 312);
            this.chkExportToExcel.Name = "chkExportToExcel";
            this.chkExportToExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkExportToExcel.Size = new System.Drawing.Size(97, 25);
            this.chkExportToExcel.TabIndex = 15;
            this.chkExportToExcel.Text = "Export to Excel";
            this.chkExportToExcel.UseVisualStyleBackColor = false;
            this.chkExportToExcel.CheckStateChanged += new System.EventHandler(this.chkExportToExcel_CheckStateChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExit.Location = new System.Drawing.Point(448, 312);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExit.Size = new System.Drawing.Size(57, 25);
            this.cmdExit.TabIndex = 14;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtDSN
            // 
            this.txtDSN.AcceptsReturn = true;
            this.txtDSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDSN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDSN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDSN.Location = new System.Drawing.Point(16, 88);
            this.txtDSN.MaxLength = 0;
            this.txtDSN.Name = "txtDSN";
            this.txtDSN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDSN.Size = new System.Drawing.Size(485, 20);
            this.txtDSN.TabIndex = 0;
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComments.Location = new System.Drawing.Point(16, 280);
            this.txtComments.MaxLength = 0;
            this.txtComments.Name = "txtComments";
            this.txtComments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComments.Size = new System.Drawing.Size(485, 20);
            this.txtComments.TabIndex = 5;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTitle.Location = new System.Drawing.Point(16, 232);
            this.txtTitle.MaxLength = 0;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.Size = new System.Drawing.Size(485, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // chkToScreen
            // 
            this.chkToScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkToScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkToScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkToScreen.Location = new System.Drawing.Point(272, 312);
            this.chkToScreen.Name = "chkToScreen";
            this.chkToScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkToScreen.Size = new System.Drawing.Size(97, 25);
            this.chkToScreen.TabIndex = 6;
            this.chkToScreen.Text = "Print to Screen";
            this.chkToScreen.UseVisualStyleBackColor = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPrint.Location = new System.Drawing.Point(384, 312);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPrint.Size = new System.Drawing.Size(57, 25);
            this.cmdPrint.TabIndex = 7;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // txtSelCrit
            // 
            this.txtSelCrit.AcceptsReturn = true;
            this.txtSelCrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSelCrit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelCrit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSelCrit.Location = new System.Drawing.Point(16, 184);
            this.txtSelCrit.MaxLength = 0;
            this.txtSelCrit.Name = "txtSelCrit";
            this.txtSelCrit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSelCrit.Size = new System.Drawing.Size(485, 20);
            this.txtSelCrit.TabIndex = 3;
            this.txtSelCrit.TextChanged += new System.EventHandler(this.txtSelCrit_TextChanged);
            // 
            // cmdCRFilename
            // 
            this.cmdCRFilename.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCRFilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCRFilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCRFilename.Location = new System.Drawing.Point(448, 133);
            this.cmdCRFilename.Name = "cmdCRFilename";
            this.cmdCRFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCRFilename.Size = new System.Drawing.Size(57, 25);
            this.cmdCRFilename.TabIndex = 2;
            this.cmdCRFilename.Text = "Browse";
            this.cmdCRFilename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdCRFilename.UseVisualStyleBackColor = false;
            this.cmdCRFilename.Click += new System.EventHandler(this.cmdCRFilename_Click);
            // 
            // txtCRFilename
            // 
            this.txtCRFilename.AcceptsReturn = true;
            this.txtCRFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCRFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCRFilename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCRFilename.Location = new System.Drawing.Point(16, 136);
            this.txtCRFilename.MaxLength = 0;
            this.txtCRFilename.Name = "txtCRFilename";
            this.txtCRFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCRFilename.Size = new System.Drawing.Size(429, 20);
            this.txtCRFilename.TabIndex = 1;
            this.txtCRFilename.TextChanged += new System.EventHandler(this.txtCRFilename_TextChanged);
            // 
            // lblDSN
            // 
            this.lblDSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDSN.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDSN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDSN.Location = new System.Drawing.Point(16, 72);
            this.lblDSN.Name = "lblDSN";
            this.lblDSN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDSN.Size = new System.Drawing.Size(277, 17);
            this.lblDSN.TabIndex = 13;
            this.lblDSN.Text = "DSN";
            // 
            // lblComments
            // 
            this.lblComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComments.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComments.Location = new System.Drawing.Point(16, 264);
            this.lblComments.Name = "lblComments";
            this.lblComments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComments.Size = new System.Drawing.Size(277, 17);
            this.lblComments.TabIndex = 12;
            this.lblComments.Text = "Report Sub-Title";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(16, 216);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(277, 17);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Report Title";
            // 
            // lblSelCrit
            // 
            this.lblSelCrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSelCrit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSelCrit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelCrit.Location = new System.Drawing.Point(16, 168);
            this.lblSelCrit.Name = "lblSelCrit";
            this.lblSelCrit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelCrit.Size = new System.Drawing.Size(277, 17);
            this.lblSelCrit.TabIndex = 10;
            this.lblSelCrit.Text = "Selection Criteria";
            // 
            // lblCRFilename
            // 
            this.lblCRFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCRFilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCRFilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCRFilename.Location = new System.Drawing.Point(16, 120);
            this.lblCRFilename.Name = "lblCRFilename";
            this.lblCRFilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCRFilename.Size = new System.Drawing.Size(277, 17);
            this.lblCRFilename.TabIndex = 9;
            this.lblCRFilename.Text = "Crystal Reports Filename";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHeading.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(104, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeading.Size = new System.Drawing.Size(277, 33);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Crystal Reports Phantom";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Report Phantom";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Text = "Close";
            this.contextMenuStrip1.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "Close";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.cmdPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(515, 353);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.fraMsg);
            this.Controls.Add(this.chkExportToPDF);
            this.Controls.Add(this.chkExportToExcel);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.txtDSN);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkToScreen);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.txtSelCrit);
            this.Controls.Add(this.cmdCRFilename);
            this.Controls.Add(this.txtCRFilename);
            this.Controls.Add(this.lblDSN);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSelCrit);
            this.Controls.Add(this.lblCRFilename);
            this.Controls.Add(this.lblHeading);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(4, 30);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Crystal Reports Phantom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.fraMsg.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
	}
}