namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class frmAllAttendance
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
            this.ComboBoxClassName = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cRvReportAttendance = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGenerate = new Guna.UI.WinForms.GunaButton();
            this.dateEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dateBeginDate = new Guna.UI.WinForms.GunaLabel();
            this.BeginDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.SuspendLayout();
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
            this.ComboBoxClassName.Location = new System.Drawing.Point(266, 37);
            this.ComboBoxClassName.Name = "ComboBoxClassName";
            this.ComboBoxClassName.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.ComboBoxClassName.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassName.Radius = 5;
            this.ComboBoxClassName.Size = new System.Drawing.Size(100, 30);
            this.ComboBoxClassName.StartIndex = 0;
            this.ComboBoxClassName.TabIndex = 37;
            this.ComboBoxClassName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassName_SelectedIndexChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(239, 2);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel6.TabIndex = 38;
            this.gunaLabel6.Text = "Class:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cRvReportAttendance
            // 
            this.cRvReportAttendance.ActiveViewIndex = -1;
            this.cRvReportAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRvReportAttendance.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRvReportAttendance.DisplayStatusBar = false;
            this.cRvReportAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRvReportAttendance.Location = new System.Drawing.Point(0, 126);
            this.cRvReportAttendance.Name = "cRvReportAttendance";
            this.cRvReportAttendance.ShowCloseButton = false;
            this.cRvReportAttendance.ShowCopyButton = false;
            this.cRvReportAttendance.ShowGroupTreeButton = false;
            this.cRvReportAttendance.ShowLogo = false;
            this.cRvReportAttendance.Size = new System.Drawing.Size(460, 236);
            this.cRvReportAttendance.TabIndex = 34;
            this.cRvReportAttendance.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.btnGenerate.Location = new System.Drawing.Point(370, 34);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Radius = 10;
            this.btnGenerate.Size = new System.Drawing.Size(68, 21);
            this.btnGenerate.TabIndex = 35;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.BackColor = System.Drawing.Color.Transparent;
            this.dateEnd.BaseColor = System.Drawing.Color.White;
            this.dateEnd.BorderColor = System.Drawing.Color.Magenta;
            this.dateEnd.BorderSize = 3;
            this.dateEnd.CustomFormat = null;
            this.dateEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateEnd.FocusedColor = System.Drawing.Color.Red;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateEnd.ForeColor = System.Drawing.Color.Black;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(135, 28);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateEnd.OnHoverBorderColor = System.Drawing.Color.Red;
            this.dateEnd.OnHoverForeColor = System.Drawing.Color.Black;
            this.dateEnd.OnPressedColor = System.Drawing.Color.White;
            this.dateEnd.OnPressedDepth = 2;
            this.dateEnd.Radius = 5;
            this.dateEnd.Size = new System.Drawing.Size(123, 24);
            this.dateEnd.TabIndex = 62;
            this.dateEnd.Text = "12/11/2022";
            this.dateEnd.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateOfAttendence_ValueChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(149, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(172, 38);
            this.gunaLabel1.TabIndex = 61;
            this.gunaLabel1.Text = "End Date";
            // 
            // dateBeginDate
            // 
            this.dateBeginDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.dateBeginDate.ForeColor = System.Drawing.Color.Black;
            this.dateBeginDate.Location = new System.Drawing.Point(6, 9);
            this.dateBeginDate.Name = "dateBeginDate";
            this.dateBeginDate.Size = new System.Drawing.Size(147, 38);
            this.dateBeginDate.TabIndex = 61;
            this.dateBeginDate.Text = "Begin Date";
            // 
            // BeginDate
            // 
            this.BeginDate.BackColor = System.Drawing.Color.Transparent;
            this.BeginDate.BaseColor = System.Drawing.Color.White;
            this.BeginDate.BorderColor = System.Drawing.Color.Magenta;
            this.BeginDate.BorderSize = 3;
            this.BeginDate.CustomFormat = null;
            this.BeginDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.BeginDate.FocusedColor = System.Drawing.Color.Red;
            this.BeginDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BeginDate.ForeColor = System.Drawing.Color.Black;
            this.BeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginDate.Location = new System.Drawing.Point(6, 28);
            this.BeginDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BeginDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.BeginDate.OnHoverBorderColor = System.Drawing.Color.Red;
            this.BeginDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.BeginDate.OnPressedColor = System.Drawing.Color.White;
            this.BeginDate.OnPressedDepth = 2;
            this.BeginDate.Radius = 5;
            this.BeginDate.Size = new System.Drawing.Size(123, 24);
            this.BeginDate.TabIndex = 62;
            this.BeginDate.Text = "12/11/2022";
            this.BeginDate.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            // 
            // frmAllAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.ComboBoxClassName);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dateBeginDate);
            this.Controls.Add(this.cRvReportAttendance);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "frmAllAttendance";
            this.Size = new System.Drawing.Size(460, 362);
            this.Load += new System.EventHandler(this.frmAllAttendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox ComboBoxClassName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton btnGenerate;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer cRvReportAttendance;
        private Guna.UI.WinForms.GunaDateTimePicker dateEnd;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel dateBeginDate;
        private Guna.UI.WinForms.GunaDateTimePicker BeginDate;
    }
}
