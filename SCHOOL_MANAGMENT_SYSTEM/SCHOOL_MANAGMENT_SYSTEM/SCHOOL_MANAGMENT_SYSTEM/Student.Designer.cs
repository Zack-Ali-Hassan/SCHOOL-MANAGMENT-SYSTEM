namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class Student
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
            this.cboxSexStudent = new Guna.UI.WinForms.GunaComboBox();
            this.lblDisplaySId = new Guna.UI.WinForms.GunaLabel();
            this.txtMobileStudent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtClassnameStudent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtLastNameStudent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtFirstNameStudent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtAddressStudent = new Guna.UI.WinForms.GunaTextBox();
            this.dGvStudent = new Guna.UI.WinForms.GunaDataGridView();
            this.txtSearchStudent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnUpdateStudent = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteStudent = new Guna.UI.WinForms.GunaButton();
            this.btnAddStudent = new Guna.UI.WinForms.GunaButton();
            this.dateOfBirthStudent = new Guna.UI.WinForms.GunaDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // cboxSexStudent
            // 
            this.cboxSexStudent.BackColor = System.Drawing.Color.Transparent;
            this.cboxSexStudent.BaseColor = System.Drawing.Color.Blue;
            this.cboxSexStudent.BorderColor = System.Drawing.Color.White;
            this.cboxSexStudent.BorderSize = 3;
            this.cboxSexStudent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSexStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexStudent.FocusedColor = System.Drawing.Color.Empty;
            this.cboxSexStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSexStudent.ForeColor = System.Drawing.Color.White;
            this.cboxSexStudent.FormattingEnabled = true;
            this.cboxSexStudent.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboxSexStudent.Location = new System.Drawing.Point(29, 111);
            this.cboxSexStudent.Name = "cboxSexStudent";
            this.cboxSexStudent.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cboxSexStudent.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cboxSexStudent.Radius = 5;
            this.cboxSexStudent.Size = new System.Drawing.Size(118, 30);
            this.cboxSexStudent.TabIndex = 21;
            // 
            // lblDisplaySId
            // 
            this.lblDisplaySId.BackColor = System.Drawing.Color.White;
            this.lblDisplaySId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplaySId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplaySId.Location = new System.Drawing.Point(21, 38);
            this.lblDisplaySId.Name = "lblDisplaySId";
            this.lblDisplaySId.Size = new System.Drawing.Size(14, 19);
            this.lblDisplaySId.TabIndex = 20;
            this.lblDisplaySId.Visible = false;
            // 
            // txtMobileStudent
            // 
            this.txtMobileStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtMobileStudent.BaseColor = System.Drawing.Color.Blue;
            this.txtMobileStudent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMobileStudent.BorderSize = 3;
            this.txtMobileStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileStudent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMobileStudent.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMobileStudent.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtMobileStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileStudent.ForeColor = System.Drawing.Color.White;
            this.txtMobileStudent.Location = new System.Drawing.Point(295, 115);
            this.txtMobileStudent.Name = "txtMobileStudent";
            this.txtMobileStudent.PasswordChar = '\0';
            this.txtMobileStudent.Radius = 5;
            this.txtMobileStudent.SelectedText = "";
            this.txtMobileStudent.Size = new System.Drawing.Size(118, 26);
            this.txtMobileStudent.TabIndex = 15;
            this.txtMobileStudent.TextOffsetX = 7;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(300, 84);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel7.TabIndex = 8;
            this.gunaLabel7.Text = "Mobile";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(34, 84);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Sex";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClassnameStudent
            // 
            this.txtClassnameStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtClassnameStudent.BaseColor = System.Drawing.Color.Blue;
            this.txtClassnameStudent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtClassnameStudent.BorderSize = 3;
            this.txtClassnameStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassnameStudent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClassnameStudent.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtClassnameStudent.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtClassnameStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassnameStudent.ForeColor = System.Drawing.Color.White;
            this.txtClassnameStudent.Location = new System.Drawing.Point(162, 111);
            this.txtClassnameStudent.Name = "txtClassnameStudent";
            this.txtClassnameStudent.PasswordChar = '\0';
            this.txtClassnameStudent.Radius = 5;
            this.txtClassnameStudent.SelectedText = "";
            this.txtClassnameStudent.Size = new System.Drawing.Size(118, 26);
            this.txtClassnameStudent.TabIndex = 16;
            this.txtClassnameStudent.TextOffsetX = 7;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(167, 84);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Class Name";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastNameStudent
            // 
            this.txtLastNameStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtLastNameStudent.BaseColor = System.Drawing.Color.Blue;
            this.txtLastNameStudent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtLastNameStudent.BorderSize = 3;
            this.txtLastNameStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameStudent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastNameStudent.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtLastNameStudent.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtLastNameStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameStudent.ForeColor = System.Drawing.Color.White;
            this.txtLastNameStudent.Location = new System.Drawing.Point(162, 63);
            this.txtLastNameStudent.Name = "txtLastNameStudent";
            this.txtLastNameStudent.PasswordChar = '\0';
            this.txtLastNameStudent.Radius = 5;
            this.txtLastNameStudent.SelectedText = "";
            this.txtLastNameStudent.Size = new System.Drawing.Size(118, 26);
            this.txtLastNameStudent.TabIndex = 17;
            this.txtLastNameStudent.TextOffsetX = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(171, 31);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Last Name";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(23, 135);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Date of birth";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstNameStudent
            // 
            this.txtFirstNameStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstNameStudent.BaseColor = System.Drawing.Color.Blue;
            this.txtFirstNameStudent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFirstNameStudent.BorderSize = 3;
            this.txtFirstNameStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstNameStudent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstNameStudent.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtFirstNameStudent.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtFirstNameStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameStudent.ForeColor = System.Drawing.Color.White;
            this.txtFirstNameStudent.Location = new System.Drawing.Point(29, 63);
            this.txtFirstNameStudent.Name = "txtFirstNameStudent";
            this.txtFirstNameStudent.PasswordChar = '\0';
            this.txtFirstNameStudent.Radius = 5;
            this.txtFirstNameStudent.SelectedText = "";
            this.txtFirstNameStudent.Size = new System.Drawing.Size(118, 26);
            this.txtFirstNameStudent.TabIndex = 19;
            this.txtFirstNameStudent.TextOffsetX = 7;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "First Name";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(303, 31);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel8.TabIndex = 12;
            this.gunaLabel8.Text = "Address";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddressStudent
            // 
            this.txtAddressStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtAddressStudent.BaseColor = System.Drawing.Color.Blue;
            this.txtAddressStudent.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtAddressStudent.BorderSize = 3;
            this.txtAddressStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressStudent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddressStudent.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtAddressStudent.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtAddressStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressStudent.ForeColor = System.Drawing.Color.White;
            this.txtAddressStudent.Location = new System.Drawing.Point(295, 64);
            this.txtAddressStudent.Name = "txtAddressStudent";
            this.txtAddressStudent.PasswordChar = '\0';
            this.txtAddressStudent.Radius = 5;
            this.txtAddressStudent.SelectedText = "";
            this.txtAddressStudent.Size = new System.Drawing.Size(118, 26);
            this.txtAddressStudent.TabIndex = 18;
            this.txtAddressStudent.TextOffsetX = 7;
            // 
            // dGvStudent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvStudent.BackgroundColor = System.Drawing.Color.Aqua;
            this.dGvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvStudent.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvStudent.EnableHeadersVisualStyles = false;
            this.dGvStudent.GridColor = System.Drawing.Color.Black;
            this.dGvStudent.Location = new System.Drawing.Point(0, 261);
            this.dGvStudent.Name = "dGvStudent";
            this.dGvStudent.RowHeadersVisible = false;
            this.dGvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvStudent.Size = new System.Drawing.Size(452, 101);
            this.dGvStudent.TabIndex = 27;
            this.dGvStudent.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvStudent.ThemeStyle.BackColor = System.Drawing.Color.Aqua;
            this.dGvStudent.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dGvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGvStudent.ThemeStyle.HeaderStyle.Height = 4;
            this.dGvStudent.ThemeStyle.ReadOnly = false;
            this.dGvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvStudent.ThemeStyle.RowsStyle.Height = 22;
            this.dGvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchStudent.BaseColor = System.Drawing.Color.White;
            this.txtSearchStudent.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchStudent.BorderSize = 3;
            this.txtSearchStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStudent.FocusedBaseColor = System.Drawing.Color.Blue;
            this.txtSearchStudent.FocusedBorderColor = System.Drawing.Color.Magenta;
            this.txtSearchStudent.FocusedForeColor = System.Drawing.Color.White;
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudent.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStudent.Location = new System.Drawing.Point(56, 196);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PasswordChar = '\0';
            this.txtSearchStudent.Radius = 5;
            this.txtSearchStudent.SelectedText = "";
            this.txtSearchStudent.Size = new System.Drawing.Size(111, 26);
            this.txtSearchStudent.TabIndex = 23;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(31, 198);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(21, 21);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 22;
            this.gunaPictureBox2.TabStop = false;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.AnimationHoverSpeed = 0.07F;
            this.btnUpdateStudent.AnimationSpeed = 0.03F;
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateStudent.BaseColor = System.Drawing.Color.Green;
            this.btnUpdateStudent.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.BorderSize = 3;
            this.btnUpdateStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Edit_Icon;
            this.btnUpdateStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateStudent.Location = new System.Drawing.Point(261, 204);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.OnHoverImage = null;
            this.btnUpdateStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.Radius = 5;
            this.btnUpdateStudent.Size = new System.Drawing.Size(83, 18);
            this.btnUpdateStudent.TabIndex = 24;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.AnimationHoverSpeed = 0.07F;
            this.btnDeleteStudent.AnimationSpeed = 0.03F;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteStudent.BaseColor = System.Drawing.Color.Green;
            this.btnDeleteStudent.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.BorderSize = 3;
            this.btnDeleteStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Delete_Icon;
            this.btnDeleteStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteStudent.Location = new System.Drawing.Point(350, 204);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDeleteStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.OnHoverImage = null;
            this.btnDeleteStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.Radius = 5;
            this.btnDeleteStudent.Size = new System.Drawing.Size(83, 18);
            this.btnDeleteStudent.TabIndex = 25;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AnimationHoverSpeed = 0.07F;
            this.btnAddStudent.AnimationSpeed = 0.03F;
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BaseColor = System.Drawing.Color.Green;
            this.btnAddStudent.BorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.BorderSize = 3;
            this.btnAddStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddStudent.Location = new System.Drawing.Point(172, 204);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAddStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddStudent.OnHoverImage = null;
            this.btnAddStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStudent.Radius = 5;
            this.btnAddStudent.Size = new System.Drawing.Size(83, 18);
            this.btnAddStudent.TabIndex = 26;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateOfBirthStudent
            // 
            this.dateOfBirthStudent.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthStudent.BaseColor = System.Drawing.Color.Blue;
            this.dateOfBirthStudent.BorderColor = System.Drawing.Color.White;
            this.dateOfBirthStudent.BorderSize = 3;
            this.dateOfBirthStudent.CustomFormat = null;
            this.dateOfBirthStudent.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfBirthStudent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateOfBirthStudent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateOfBirthStudent.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthStudent.Location = new System.Drawing.Point(29, 164);
            this.dateOfBirthStudent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthStudent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthStudent.Name = "dateOfBirthStudent";
            this.dateOfBirthStudent.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateOfBirthStudent.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateOfBirthStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateOfBirthStudent.OnPressedColor = System.Drawing.Color.Black;
            this.dateOfBirthStudent.Radius = 5;
            this.dateOfBirthStudent.Size = new System.Drawing.Size(190, 24);
            this.dateOfBirthStudent.TabIndex = 28;
            this.dateOfBirthStudent.Text = "Sunday, December 11, 2022";
            this.dateOfBirthStudent.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(452, 362);
            this.Controls.Add(this.dateOfBirthStudent);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.dGvStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.cboxSexStudent);
            this.Controls.Add(this.lblDisplaySId);
            this.Controls.Add(this.txtMobileStudent);
            this.Controls.Add(this.txtClassnameStudent);
            this.Controls.Add(this.txtLastNameStudent);
            this.Controls.Add(this.txtAddressStudent);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtFirstNameStudent);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dGvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaComboBox cboxSexStudent;
        private Guna.UI.WinForms.GunaLabel lblDisplaySId;
        private Guna.UI.WinForms.GunaTextBox txtMobileStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtClassnameStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtLastNameStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtFirstNameStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtAddressStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaDataGridView dGvStudent;
        private Guna.UI.WinForms.GunaButton btnUpdateStudent;
        private Guna.UI.WinForms.GunaButton btnDeleteStudent;
        private Guna.UI.WinForms.GunaButton btnAddStudent;
        private Guna.UI.WinForms.GunaTextBox txtSearchStudent;
        private Guna.UI.WinForms.GunaDateTimePicker dateOfBirthStudent;
    }
}