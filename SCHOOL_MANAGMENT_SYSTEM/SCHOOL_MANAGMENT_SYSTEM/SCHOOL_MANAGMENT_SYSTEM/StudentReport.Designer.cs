namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class StudentReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPictureBoxClose = new Guna.UI.WinForms.GunaPictureBox();
            this.cRvReportStudentSpecifc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPictureBoxClose
            // 
            this.gunaPictureBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaPictureBoxClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaPictureBoxClose.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.x;
            this.gunaPictureBoxClose.Location = new System.Drawing.Point(544, 10);
            this.gunaPictureBoxClose.Name = "gunaPictureBoxClose";
            this.gunaPictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.gunaPictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxClose.TabIndex = 3;
            this.gunaPictureBoxClose.TabStop = false;
            this.gunaPictureBoxClose.Click += new System.EventHandler(this.gunaPictureBoxClose_Click);
            // 
            // cRvReportStudentSpecifc
            // 
            this.cRvReportStudentSpecifc.ActiveViewIndex = -1;
            this.cRvReportStudentSpecifc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRvReportStudentSpecifc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRvReportStudentSpecifc.DisplayStatusBar = false;
            this.cRvReportStudentSpecifc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRvReportStudentSpecifc.Location = new System.Drawing.Point(0, 41);
            this.cRvReportStudentSpecifc.Name = "cRvReportStudentSpecifc";
            this.cRvReportStudentSpecifc.ShowCloseButton = false;
            this.cRvReportStudentSpecifc.ShowCopyButton = false;
            this.cRvReportStudentSpecifc.ShowGroupTreeButton = false;
            this.cRvReportStudentSpecifc.ShowLogo = false;
            this.cRvReportStudentSpecifc.Size = new System.Drawing.Size(580, 485);
            this.cRvReportStudentSpecifc.TabIndex = 4;
            this.cRvReportStudentSpecifc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(580, 46);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "Specific Student";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 526);
            this.Controls.Add(this.cRvReportStudentSpecifc);
            this.Controls.Add(this.gunaPictureBoxClose);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentReport";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxClose;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cRvReportStudentSpecifc;
        private System.Windows.Forms.Label lblDisplay;
    }
}