namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnUpdateAttendance = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.dGvDisplayAttendance = new Guna.UI.WinForms.GunaDataGridView();
            this.dateOfAttendence = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblDisplayId = new Guna.UI.WinForms.GunaLabel();
            this.cBStatus = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cBClassname = new Guna.UI.WinForms.GunaComboBox();
            this.btnFilter = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvDisplayAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnUpdateAttendance
            // 
            this.btnUpdateAttendance.AnimationHoverSpeed = 0.07F;
            this.btnUpdateAttendance.AnimationSpeed = 0.03F;
            this.btnUpdateAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAttendance.BaseColor = System.Drawing.Color.Transparent;
            this.btnUpdateAttendance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdateAttendance.BorderSize = 3;
            this.btnUpdateAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateAttendance.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAttendance.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.exit4;
            this.btnUpdateAttendance.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateAttendance.Location = new System.Drawing.Point(549, 106);
            this.btnUpdateAttendance.Name = "btnUpdateAttendance";
            this.btnUpdateAttendance.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateAttendance.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.btnUpdateAttendance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateAttendance.OnHoverImage = null;
            this.btnUpdateAttendance.OnPressedColor = System.Drawing.Color.Blue;
            this.btnUpdateAttendance.Radius = 10;
            this.btnUpdateAttendance.Size = new System.Drawing.Size(96, 32);
            this.btnUpdateAttendance.TabIndex = 5;
            this.btnUpdateAttendance.Text = "Update";
            this.btnUpdateAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdateAttendance.Click += new System.EventHandler(this.btnUpdateAttendance_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(657, 52);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "View Attendance";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Blue;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Blue;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.delete_24px;
            this.gunaPictureBox2.Location = new System.Drawing.Point(610, 11);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 17;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // dGvDisplayAttendance
            // 
            this.dGvDisplayAttendance.AllowUserToAddRows = false;
            this.dGvDisplayAttendance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvDisplayAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvDisplayAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvDisplayAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvDisplayAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvDisplayAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvDisplayAttendance.ColumnHeadersHeight = 25;
            this.dGvDisplayAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvDisplayAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvDisplayAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvDisplayAttendance.EnableHeadersVisualStyles = false;
            this.dGvDisplayAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvDisplayAttendance.Location = new System.Drawing.Point(0, 214);
            this.dGvDisplayAttendance.Name = "dGvDisplayAttendance";
            this.dGvDisplayAttendance.ReadOnly = true;
            this.dGvDisplayAttendance.RowHeadersVisible = false;
            this.dGvDisplayAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvDisplayAttendance.Size = new System.Drawing.Size(657, 230);
            this.dGvDisplayAttendance.TabIndex = 18;
            this.dGvDisplayAttendance.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvDisplayAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvDisplayAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvDisplayAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvDisplayAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvDisplayAttendance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGvDisplayAttendance.ThemeStyle.HeaderStyle.Height = 25;
            this.dGvDisplayAttendance.ThemeStyle.ReadOnly = true;
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.Height = 22;
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvDisplayAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvDisplayAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvDisplayAttendance_CellClick);
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
            this.dateOfAttendence.Location = new System.Drawing.Point(23, 108);
            this.dateOfAttendence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfAttendence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfAttendence.Name = "dateOfAttendence";
            this.dateOfAttendence.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateOfAttendence.OnHoverBorderColor = System.Drawing.Color.Red;
            this.dateOfAttendence.OnHoverForeColor = System.Drawing.Color.Black;
            this.dateOfAttendence.OnPressedColor = System.Drawing.Color.White;
            this.dateOfAttendence.OnPressedDepth = 2;
            this.dateOfAttendence.Radius = 5;
            this.dateOfAttendence.Size = new System.Drawing.Size(137, 30);
            this.dateOfAttendence.TabIndex = 62;
            this.dateOfAttendence.Text = "12/11/2022";
            this.dateOfAttendence.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            this.dateOfAttendence.ValueChanged += new System.EventHandler(this.dateOfAttendence_ValueChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(20, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 30);
            this.gunaLabel2.TabIndex = 61;
            this.gunaLabel2.Text = "Date:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(324, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 30);
            this.gunaLabel3.TabIndex = 61;
            this.gunaLabel3.Text = "Status:";
            // 
            // lblDisplayId
            // 
            this.lblDisplayId.BackColor = System.Drawing.Color.Black;
            this.lblDisplayId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayId.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayId.Location = new System.Drawing.Point(28, 60);
            this.lblDisplayId.Name = "lblDisplayId";
            this.lblDisplayId.Size = new System.Drawing.Size(22, 20);
            this.lblDisplayId.TabIndex = 61;
            this.lblDisplayId.Visible = false;
            // 
            // cBStatus
            // 
            this.cBStatus.BackColor = System.Drawing.Color.Transparent;
            this.cBStatus.BaseColor = System.Drawing.Color.White;
            this.cBStatus.BorderColor = System.Drawing.Color.Magenta;
            this.cBStatus.BorderSize = 3;
            this.cBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cBStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBStatus.ForeColor = System.Drawing.Color.Black;
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Items.AddRange(new object[] {
            "Select",
            "Present",
            "Absent"});
            this.cBStatus.Location = new System.Drawing.Point(328, 108);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cBStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cBStatus.Radius = 10;
            this.cBStatus.Size = new System.Drawing.Size(134, 30);
            this.cBStatus.StartIndex = 0;
            this.cBStatus.TabIndex = 64;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Magenta;
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(390, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(255, 31);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.TextOffsetX = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(306, 176);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(79, 30);
            this.gunaLabel4.TabIndex = 61;
            this.gunaLabel4.Text = "Search";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(172, 75);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(67, 30);
            this.gunaLabel5.TabIndex = 61;
            this.gunaLabel5.Text = "Class:";
            // 
            // cBClassname
            // 
            this.cBClassname.BackColor = System.Drawing.Color.Transparent;
            this.cBClassname.BaseColor = System.Drawing.Color.White;
            this.cBClassname.BorderColor = System.Drawing.Color.Magenta;
            this.cBClassname.BorderSize = 3;
            this.cBClassname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBClassname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBClassname.FocusedColor = System.Drawing.Color.Empty;
            this.cBClassname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBClassname.ForeColor = System.Drawing.Color.Black;
            this.cBClassname.FormattingEnabled = true;
            this.cBClassname.Location = new System.Drawing.Point(176, 108);
            this.cBClassname.Name = "cBClassname";
            this.cBClassname.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cBClassname.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cBClassname.Radius = 10;
            this.cBClassname.Size = new System.Drawing.Size(139, 30);
            this.cBClassname.TabIndex = 64;
            this.cBClassname.SelectedIndexChanged += new System.EventHandler(this.cBClassname_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.AnimationHoverSpeed = 0.07F;
            this.btnFilter.AnimationSpeed = 0.03F;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BaseColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderColor = System.Drawing.Color.Blue;
            this.btnFilter.BorderSize = 3;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilter.FocusedColor = System.Drawing.Color.Empty;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Image = null;
            this.btnFilter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFilter.Location = new System.Drawing.Point(468, 106);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnFilter.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.btnFilter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFilter.OnHoverImage = null;
            this.btnFilter.OnPressedColor = System.Drawing.Color.Blue;
            this.btnFilter.Radius = 10;
            this.btnFilter.Size = new System.Drawing.Size(75, 32);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Controls.Add(this.cBClassname);
            this.Controls.Add(this.cBStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dateOfAttendence);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblDisplayId);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dGvDisplayAttendance);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnUpdateAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvDisplayAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnUpdateAttendance;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaDataGridView dGvDisplayAttendance;
        private Guna.UI.WinForms.GunaDateTimePicker dateOfAttendence;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblDisplayId;
        private Guna.UI.WinForms.GunaComboBox cBStatus;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cBClassname;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnFilter;
    }
}