namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class frmAttendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chSelectAll = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dateOfAttendence = new Guna.UI.WinForms.GunaDateTimePicker();
            this.ComboBoxClassNameaTTENDENCE = new Guna.UI.WinForms.GunaComboBox();
            this.dgvAttendence = new Guna.UI.WinForms.GunaDataGridView();
            this.btnViewAttendance = new Guna.UI.WinForms.GunaButton();
            this.btnSaveAttendence = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // chSelectAll
            // 
            this.chSelectAll.BaseColor = System.Drawing.Color.Magenta;
            this.chSelectAll.CheckedOffColor = System.Drawing.Color.Gray;
            this.chSelectAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chSelectAll.FillColor = System.Drawing.Color.White;
            this.chSelectAll.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSelectAll.ForeColor = System.Drawing.Color.Black;
            this.chSelectAll.Location = new System.Drawing.Point(374, 68);
            this.chSelectAll.Name = "chSelectAll";
            this.chSelectAll.Size = new System.Drawing.Size(123, 33);
            this.chSelectAll.TabIndex = 54;
            this.chSelectAll.Text = "Select all";
            this.chSelectAll.CheckedChanged += new System.EventHandler(this.chSelectAll_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(234, 42);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 30);
            this.gunaLabel2.TabIndex = 55;
            this.gunaLabel2.Text = "Class:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(14, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 30);
            this.gunaLabel1.TabIndex = 56;
            this.gunaLabel1.Text = "Date:";
            // 
            // dateOfAttendence
            // 
            this.dateOfAttendence.BackColor = System.Drawing.Color.Transparent;
            this.dateOfAttendence.BaseColor = System.Drawing.Color.White;
            this.dateOfAttendence.BorderColor = System.Drawing.Color.Magenta;
            this.dateOfAttendence.BorderSize = 3;
            this.dateOfAttendence.CustomFormat = null;
            this.dateOfAttendence.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfAttendence.FocusedColor = System.Drawing.Color.Red;
            this.dateOfAttendence.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateOfAttendence.ForeColor = System.Drawing.Color.Black;
            this.dateOfAttendence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfAttendence.Location = new System.Drawing.Point(14, 57);
            this.dateOfAttendence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfAttendence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfAttendence.Name = "dateOfAttendence";
            this.dateOfAttendence.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateOfAttendence.OnHoverBorderColor = System.Drawing.Color.Red;
            this.dateOfAttendence.OnHoverForeColor = System.Drawing.Color.Black;
            this.dateOfAttendence.OnPressedColor = System.Drawing.Color.White;
            this.dateOfAttendence.OnPressedDepth = 2;
            this.dateOfAttendence.Radius = 5;
            this.dateOfAttendence.Size = new System.Drawing.Size(190, 24);
            this.dateOfAttendence.TabIndex = 60;
            this.dateOfAttendence.Text = "12/11/2022";
            this.dateOfAttendence.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            this.dateOfAttendence.ValueChanged += new System.EventHandler(this.dateOfBirthStudent_ValueChanged);
            // 
            // ComboBoxClassNameaTTENDENCE
            // 
            this.ComboBoxClassNameaTTENDENCE.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxClassNameaTTENDENCE.BaseColor = System.Drawing.Color.White;
            this.ComboBoxClassNameaTTENDENCE.BorderColor = System.Drawing.Color.Magenta;
            this.ComboBoxClassNameaTTENDENCE.BorderSize = 3;
            this.ComboBoxClassNameaTTENDENCE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxClassNameaTTENDENCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClassNameaTTENDENCE.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxClassNameaTTENDENCE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClassNameaTTENDENCE.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassNameaTTENDENCE.FormattingEnabled = true;
            this.ComboBoxClassNameaTTENDENCE.Items.AddRange(new object[] {
            "Select"});
            this.ComboBoxClassNameaTTENDENCE.Location = new System.Drawing.Point(234, 67);
            this.ComboBoxClassNameaTTENDENCE.Name = "ComboBoxClassNameaTTENDENCE";
            this.ComboBoxClassNameaTTENDENCE.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.ComboBoxClassNameaTTENDENCE.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxClassNameaTTENDENCE.Radius = 5;
            this.ComboBoxClassNameaTTENDENCE.Size = new System.Drawing.Size(134, 30);
            this.ComboBoxClassNameaTTENDENCE.StartIndex = 0;
            this.ComboBoxClassNameaTTENDENCE.TabIndex = 59;
            this.ComboBoxClassNameaTTENDENCE.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClassName_SelectedIndexChanged);
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.AllowUserToAddRows = false;
            this.dgvAttendence.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAttendence.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendence.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendence.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendence.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAttendence.EnableHeadersVisualStyles = false;
            this.dgvAttendence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttendence.Location = new System.Drawing.Point(0, 127);
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.RowHeadersVisible = false;
            this.dgvAttendence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendence.Size = new System.Drawing.Size(445, 235);
            this.dgvAttendence.TabIndex = 61;
            this.dgvAttendence.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAttendence.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttendence.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAttendence.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAttendence.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAttendence.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAttendence.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttendence.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttendence.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAttendence.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttendence.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAttendence.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAttendence.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAttendence.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAttendence.ThemeStyle.ReadOnly = false;
            this.dgvAttendence.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttendence.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendence.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAttendence.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAttendence.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAttendence.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttendence.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendence_CellContentClick);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.AnimationHoverSpeed = 0.07F;
            this.btnViewAttendance.AnimationSpeed = 0.03F;
            this.btnViewAttendance.BaseColor = System.Drawing.Color.White;
            this.btnViewAttendance.BorderColor = System.Drawing.Color.Black;
            this.btnViewAttendance.BorderSize = 3;
            this.btnViewAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewAttendance.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewAttendance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnViewAttendance.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.View_removebg_preview1;
            this.btnViewAttendance.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewAttendance.Location = new System.Drawing.Point(378, 40);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewAttendance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewAttendance.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewAttendance.OnHoverImage = null;
            this.btnViewAttendance.OnPressedColor = System.Drawing.Color.White;
            this.btnViewAttendance.Size = new System.Drawing.Size(58, 16);
            this.btnViewAttendance.TabIndex = 62;
            this.btnViewAttendance.Text = "View";
            this.btnViewAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnSaveAttendence
            // 
            this.btnSaveAttendence.AnimationHoverSpeed = 0.07F;
            this.btnSaveAttendence.AnimationSpeed = 0.03F;
            this.btnSaveAttendence.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAttendence.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveAttendence.BorderColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveAttendence.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAttendence.ForeColor = System.Drawing.Color.White;
            this.btnSaveAttendence.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnSaveAttendence.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveAttendence.Location = new System.Drawing.Point(14, 94);
            this.btnSaveAttendence.Name = "btnSaveAttendence";
            this.btnSaveAttendence.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnSaveAttendence.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveAttendence.OnHoverImage = null;
            this.btnSaveAttendence.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.Radius = 6;
            this.btnSaveAttendence.Size = new System.Drawing.Size(60, 18);
            this.btnSaveAttendence.TabIndex = 48;
            this.btnSaveAttendence.Text = "Save";
            this.btnSaveAttendence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveAttendence.Click += new System.EventHandler(this.btnSaveAttendence_Click);
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.dgvAttendence);
            this.Controls.Add(this.dateOfAttendence);
            this.Controls.Add(this.ComboBoxClassNameaTTENDENCE);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnSaveAttendence);
            this.Controls.Add(this.chSelectAll);
            this.Name = "frmAttendence";
            this.Size = new System.Drawing.Size(445, 362);
            this.Load += new System.EventHandler(this.frmAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaButton btnSaveAttendence;
        private Guna.UI.WinForms.GunaCheckBox chSelectAll;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dateOfAttendence;
        private Guna.UI.WinForms.GunaComboBox ComboBoxClassNameaTTENDENCE;
        private Guna.UI.WinForms.GunaDataGridView dgvAttendence;
        public Guna.UI.WinForms.GunaButton btnViewAttendance;
    }
}
