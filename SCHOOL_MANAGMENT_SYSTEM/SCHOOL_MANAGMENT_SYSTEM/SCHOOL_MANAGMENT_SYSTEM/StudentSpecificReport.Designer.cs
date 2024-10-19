namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class StudentSpecificReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cRvReportStudentSpecifc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gunaPictureBoxClose = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cRvReportStudentSpecifc
            // 
            this.cRvReportStudentSpecifc.ActiveViewIndex = -1;
            this.cRvReportStudentSpecifc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRvReportStudentSpecifc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRvReportStudentSpecifc.DisplayStatusBar = false;
            this.cRvReportStudentSpecifc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRvReportStudentSpecifc.Location = new System.Drawing.Point(0, 62);
            this.cRvReportStudentSpecifc.Name = "cRvReportStudentSpecifc";
            this.cRvReportStudentSpecifc.ShowCloseButton = false;
            this.cRvReportStudentSpecifc.ShowCopyButton = false;
            this.cRvReportStudentSpecifc.ShowGroupTreeButton = false;
            this.cRvReportStudentSpecifc.ShowLogo = false;
            this.cRvReportStudentSpecifc.Size = new System.Drawing.Size(460, 300);
            this.cRvReportStudentSpecifc.TabIndex = 1;
            this.cRvReportStudentSpecifc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // gunaPictureBoxClose
            // 
            this.gunaPictureBoxClose.BackColor = System.Drawing.Color.White;
            this.gunaPictureBoxClose.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxClose.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.x;
            this.gunaPictureBoxClose.Location = new System.Drawing.Point(427, 20);
            this.gunaPictureBoxClose.Name = "gunaPictureBoxClose";
            this.gunaPictureBoxClose.Size = new System.Drawing.Size(13, 13);
            this.gunaPictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxClose.TabIndex = 2;
            this.gunaPictureBoxClose.TabStop = false;
            this.gunaPictureBoxClose.Click += new System.EventHandler(this.gunaPictureBoxClose_Click);
            // 
            // StudentSpecificReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPictureBoxClose);
            this.Controls.Add(this.cRvReportStudentSpecifc);
            this.Name = "StudentSpecificReport";
            this.Size = new System.Drawing.Size(460, 362);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cRvReportStudentSpecifc;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxClose;
    }
}
