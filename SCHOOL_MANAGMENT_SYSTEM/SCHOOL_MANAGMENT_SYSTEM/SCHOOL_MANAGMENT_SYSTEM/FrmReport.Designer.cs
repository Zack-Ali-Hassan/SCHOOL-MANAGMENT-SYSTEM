namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class FrmReport
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
            this.btnGenerate = new Guna.UI.WinForms.GunaButton();
            this.cRvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ComboBoxClassName = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cBoxAll = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.AnimationHoverSpeed = 0.07F;
            this.btnGenerate.AnimationSpeed = 0.03F;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerate.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerate.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Generate_removebg_preview;
            this.btnGenerate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerate.Location = new System.Drawing.Point(367, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Radius = 10;
            this.btnGenerate.Size = new System.Drawing.Size(74, 21);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // cRvReport
            // 
            this.cRvReport.ActiveViewIndex = -1;
            this.cRvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRvReport.DisplayStatusBar = false;
            this.cRvReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRvReport.Location = new System.Drawing.Point(0, 110);
            this.cRvReport.Name = "cRvReport";
            this.cRvReport.ShowCloseButton = false;
            this.cRvReport.ShowCopyButton = false;
            this.cRvReport.ShowGroupTreeButton = false;
            this.cRvReport.ShowLogo = false;
            this.cRvReport.Size = new System.Drawing.Size(460, 252);
            this.cRvReport.TabIndex = 0;
            this.cRvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.cRvReport.Load += new System.EventHandler(this.cRvReport_Load);
            // 
            // ComboBoxClassName
            // 
            this.ComboBoxClassName.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxClassName.BaseColor = System.Drawing.Color.White;
            this.ComboBoxClassName.BorderColor = System.Drawing.Color.Magenta;
            this.ComboBoxClassName.BorderSize = 3;
            this.ComboBoxClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClassName.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxClassName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassName.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassName.FormattingEnabled = true;
            this.ComboBoxClassName.Items.AddRange(new object[] {
            "Select"});
            this.ComboBoxClassName.Location = new System.Drawing.Point(224, 17);
            this.ComboBoxClassName.Name = "ComboBoxClassName";
            this.ComboBoxClassName.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.ComboBoxClassName.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassName.Radius = 5;
            this.ComboBoxClassName.Size = new System.Drawing.Size(118, 30);
            this.ComboBoxClassName.StartIndex = 0;
            this.ComboBoxClassName.TabIndex = 32;
            this.ComboBoxClassName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassName_SelectedIndexChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(147, 5);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel6.TabIndex = 33;
            this.gunaLabel6.Text = "ID";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxAll
            // 
            this.cBoxAll.BackColor = System.Drawing.Color.Transparent;
            this.cBoxAll.BaseColor = System.Drawing.Color.White;
            this.cBoxAll.BorderColor = System.Drawing.Color.Magenta;
            this.cBoxAll.BorderSize = 3;
            this.cBoxAll.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAll.FocusedColor = System.Drawing.Color.Empty;
            this.cBoxAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAll.ForeColor = System.Drawing.Color.Black;
            this.cBoxAll.FormattingEnabled = true;
            this.cBoxAll.Items.AddRange(new object[] {
            "All",
            "Custom"});
            this.cBoxAll.Location = new System.Drawing.Point(9, 17);
            this.cBoxAll.Name = "cBoxAll";
            this.cBoxAll.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cBoxAll.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cBoxAll.Radius = 5;
            this.cBoxAll.Size = new System.Drawing.Size(118, 30);
            this.cBoxAll.StartIndex = 0;
            this.cBoxAll.TabIndex = 32;
            this.cBoxAll.SelectedIndexChanged += new System.EventHandler(this.cBoxAll_SelectedIndexChanged);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cBoxAll);
            this.Controls.Add(this.ComboBoxClassName);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cRvReport);
            this.Name = "FrmReport";
            this.Size = new System.Drawing.Size(460, 362);
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnGenerate;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cRvReport;
        private Guna.UI.WinForms.GunaComboBox ComboBoxClassName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox cBoxAll;


    }
}
