using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace ReportPhantom
{
	partial class frmReportView
	{

		#region "Upgrade Support "
		private static frmReportView m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmReportView DefInstance
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
		public static frmReportView CreateInstance()
		{
			frmReportView theInstance = new frmReportView();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cryView"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public AxCrystalActiveXReportViewerLib10.AxCrystalActiveXReportViewer cryView;
		public System.Windows.Forms.OpenFileDialog dlgPrintOpen;
		public System.Windows.Forms.SaveFileDialog dlgPrintSave;
		public System.Windows.Forms.FontDialog dlgPrintFont;
		public System.Windows.Forms.ColorDialog dlgPrintColor;
		public System.Windows.Forms.PrintDialog dlgPrintPrint;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportView));
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.cryView = new AxCrystalActiveXReportViewerLib10.AxCrystalActiveXReportViewer();
            this.dlgPrintOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgPrintSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgPrintFont = new System.Windows.Forms.FontDialog();
            this.dlgPrintColor = new System.Windows.Forms.ColorDialog();
            this.dlgPrintPrint = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cryView)).BeginInit();
            this.SuspendLayout();
            // 
            // cryView
            // 
            this.cryView.Enabled = true;
            this.cryView.Location = new System.Drawing.Point(0, 0);
            this.cryView.Name = "cryView";
            this.cryView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cryView.OcxState")));
            this.cryView.Size = new System.Drawing.Size(0, 0);
            this.cryView.TabIndex = 0;
            this.cryView.PrintButtonClicked += new AxCrystalActiveXReportViewerLib10._ICRViewerEvents_PrintButtonClickedEventHandler(this.cryView_PrintButtonClicked);
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 543);
            this.Controls.Add(this.cryView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(4, 23);
            this.Name = "frmReportView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.Closed += new System.EventHandler(this.frmReportView_Closed);
            this.Resize += new System.EventHandler(this.frmReportView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.cryView)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	}
}