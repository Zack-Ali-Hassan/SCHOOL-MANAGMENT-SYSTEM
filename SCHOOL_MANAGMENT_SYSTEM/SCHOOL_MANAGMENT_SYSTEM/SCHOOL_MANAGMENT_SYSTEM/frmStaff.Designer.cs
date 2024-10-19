namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class frmStaff
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
            this.lblDisplayStaffId = new Guna.UI.WinForms.GunaLabel();
            this.txtAddressStaff = new Guna.UI.WinForms.GunaTextBox();
            this.txtSalaryStaff = new Guna.UI.WinForms.GunaTextBox();
            this.cboxSexStaff = new Guna.UI.WinForms.GunaComboBox();
            this.txtLastNameStaff = new Guna.UI.WinForms.GunaTextBox();
            this.txtMobileStaff = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtFirstNameStaff = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnUpdateStaff = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteStaff = new Guna.UI.WinForms.GunaButton();
            this.btnAddStaff = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearchStaff = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dGvStaff = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayStaffId
            // 
            this.lblDisplayStaffId.BackColor = System.Drawing.Color.Black;
            this.lblDisplayStaffId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayStaffId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplayStaffId.ForeColor = System.Drawing.Color.White;
            this.lblDisplayStaffId.Location = new System.Drawing.Point(26, 9);
            this.lblDisplayStaffId.Name = "lblDisplayStaffId";
            this.lblDisplayStaffId.Size = new System.Drawing.Size(14, 19);
            this.lblDisplayStaffId.TabIndex = 98;
            this.lblDisplayStaffId.Visible = false;
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtAddressStaff.BaseColor = System.Drawing.Color.White;
            this.txtAddressStaff.BorderColor = System.Drawing.Color.Magenta;
            this.txtAddressStaff.BorderSize = 3;
            this.txtAddressStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddressStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtAddressStaff.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtAddressStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressStaff.ForeColor = System.Drawing.Color.Black;
            this.txtAddressStaff.Location = new System.Drawing.Point(296, 112);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.PasswordChar = '\0';
            this.txtAddressStaff.Radius = 5;
            this.txtAddressStaff.SelectedText = "";
            this.txtAddressStaff.Size = new System.Drawing.Size(118, 26);
            this.txtAddressStaff.TabIndex = 5;
            this.txtAddressStaff.TextOffsetX = 5;
            this.txtAddressStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressStaff_KeyPress);
            // 
            // txtSalaryStaff
            // 
            this.txtSalaryStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtSalaryStaff.BaseColor = System.Drawing.Color.White;
            this.txtSalaryStaff.BorderColor = System.Drawing.Color.Magenta;
            this.txtSalaryStaff.BorderSize = 3;
            this.txtSalaryStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalaryStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalaryStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSalaryStaff.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtSalaryStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryStaff.ForeColor = System.Drawing.Color.Black;
            this.txtSalaryStaff.Location = new System.Drawing.Point(163, 112);
            this.txtSalaryStaff.MaxLength = 4;
            this.txtSalaryStaff.Name = "txtSalaryStaff";
            this.txtSalaryStaff.PasswordChar = '\0';
            this.txtSalaryStaff.Radius = 5;
            this.txtSalaryStaff.SelectedText = "";
            this.txtSalaryStaff.Size = new System.Drawing.Size(118, 26);
            this.txtSalaryStaff.TabIndex = 4;
            this.txtSalaryStaff.TextOffsetX = 5;
            this.txtSalaryStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryStaff_KeyPress);
            // 
            // cboxSexStaff
            // 
            this.cboxSexStaff.BackColor = System.Drawing.Color.Transparent;
            this.cboxSexStaff.BaseColor = System.Drawing.Color.White;
            this.cboxSexStaff.BorderColor = System.Drawing.Color.Magenta;
            this.cboxSexStaff.BorderSize = 3;
            this.cboxSexStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSexStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexStaff.FocusedColor = System.Drawing.Color.Empty;
            this.cboxSexStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSexStaff.ForeColor = System.Drawing.Color.Black;
            this.cboxSexStaff.FormattingEnabled = true;
            this.cboxSexStaff.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.cboxSexStaff.Location = new System.Drawing.Point(30, 108);
            this.cboxSexStaff.Name = "cboxSexStaff";
            this.cboxSexStaff.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cboxSexStaff.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cboxSexStaff.Radius = 5;
            this.cboxSexStaff.Size = new System.Drawing.Size(118, 30);
            this.cboxSexStaff.StartIndex = 0;
            this.cboxSexStaff.TabIndex = 3;
            // 
            // txtLastNameStaff
            // 
            this.txtLastNameStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtLastNameStaff.BaseColor = System.Drawing.Color.White;
            this.txtLastNameStaff.BorderColor = System.Drawing.Color.Magenta;
            this.txtLastNameStaff.BorderSize = 3;
            this.txtLastNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastNameStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtLastNameStaff.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtLastNameStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameStaff.ForeColor = System.Drawing.Color.Black;
            this.txtLastNameStaff.Location = new System.Drawing.Point(163, 56);
            this.txtLastNameStaff.Name = "txtLastNameStaff";
            this.txtLastNameStaff.PasswordChar = '\0';
            this.txtLastNameStaff.Radius = 5;
            this.txtLastNameStaff.SelectedText = "";
            this.txtLastNameStaff.Size = new System.Drawing.Size(118, 26);
            this.txtLastNameStaff.TabIndex = 1;
            this.txtLastNameStaff.TextOffsetX = 5;
            this.txtLastNameStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastNameStaff_KeyPress);
            // 
            // txtMobileStaff
            // 
            this.txtMobileStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtMobileStaff.BaseColor = System.Drawing.Color.White;
            this.txtMobileStaff.BorderColor = System.Drawing.Color.Magenta;
            this.txtMobileStaff.BorderSize = 3;
            this.txtMobileStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMobileStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMobileStaff.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtMobileStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileStaff.ForeColor = System.Drawing.Color.Black;
            this.txtMobileStaff.Location = new System.Drawing.Point(296, 57);
            this.txtMobileStaff.MaxLength = 9;
            this.txtMobileStaff.Name = "txtMobileStaff";
            this.txtMobileStaff.PasswordChar = '\0';
            this.txtMobileStaff.Radius = 5;
            this.txtMobileStaff.SelectedText = "";
            this.txtMobileStaff.Size = new System.Drawing.Size(118, 26);
            this.txtMobileStaff.TabIndex = 2;
            this.txtMobileStaff.TextOffsetX = 5;
            this.txtMobileStaff.TextChanged += new System.EventHandler(this.txtMobileStaff_TextChanged);
            this.txtMobileStaff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobileStaff_KeyDown);
            this.txtMobileStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileStaff_KeyPress);
            this.txtMobileStaff.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMobileStaff_KeyUp);
            this.txtMobileStaff.MouseLeave += new System.EventHandler(this.txtMobileStaff_MouseLeave);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(304, 24);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(90, 38);
            this.gunaLabel8.TabIndex = 87;
            this.gunaLabel8.Text = "Mobile";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(172, 24);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel3.TabIndex = 86;
            this.gunaLabel3.Text = "Last Name";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstNameStaff
            // 
            this.txtFirstNameStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstNameStaff.BaseColor = System.Drawing.Color.White;
            this.txtFirstNameStaff.BorderColor = System.Drawing.Color.Magenta;
            this.txtFirstNameStaff.BorderSize = 3;
            this.txtFirstNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstNameStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstNameStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtFirstNameStaff.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtFirstNameStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameStaff.ForeColor = System.Drawing.Color.Black;
            this.txtFirstNameStaff.Location = new System.Drawing.Point(30, 56);
            this.txtFirstNameStaff.Name = "txtFirstNameStaff";
            this.txtFirstNameStaff.PasswordChar = '\0';
            this.txtFirstNameStaff.Radius = 5;
            this.txtFirstNameStaff.SelectedText = "";
            this.txtFirstNameStaff.Size = new System.Drawing.Size(118, 26);
            this.txtFirstNameStaff.TabIndex = 0;
            this.txtFirstNameStaff.TextOffsetX = 5;
            this.txtFirstNameStaff.TextChanged += new System.EventHandler(this.txtFirstNameStaff_TextChanged);
            this.txtFirstNameStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNameStaff_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(35, 24);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel2.TabIndex = 88;
            this.gunaLabel2.Text = "First Name";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.AnimationHoverSpeed = 0.07F;
            this.btnUpdateStaff.AnimationSpeed = 0.03F;
            this.btnUpdateStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateStaff.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStaff.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Edit_Icon;
            this.btnUpdateStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateStaff.Location = new System.Drawing.Point(266, 153);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateStaff.OnHoverImage = null;
            this.btnUpdateStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateStaff.Radius = 8;
            this.btnUpdateStaff.Size = new System.Drawing.Size(63, 24);
            this.btnUpdateStaff.TabIndex = 7;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.AnimationHoverSpeed = 0.07F;
            this.btnDeleteStaff.AnimationSpeed = 0.03F;
            this.btnDeleteStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteStaff.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Delete_Icon;
            this.btnDeleteStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteStaff.Location = new System.Drawing.Point(351, 153);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDeleteStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.OnHoverImage = null;
            this.btnDeleteStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteStaff.Radius = 8;
            this.btnDeleteStaff.Size = new System.Drawing.Size(63, 24);
            this.btnDeleteStaff.TabIndex = 8;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.AnimationHoverSpeed = 0.07F;
            this.btnAddStaff.AnimationSpeed = 0.03F;
            this.btnAddStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddStaff.BorderColor = System.Drawing.Color.Black;
            this.btnAddStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnAddStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddStaff.Location = new System.Drawing.Point(178, 153);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAddStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddStaff.OnHoverImage = null;
            this.btnAddStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStaff.Radius = 8;
            this.btnAddStaff.Size = new System.Drawing.Size(63, 24);
            this.btnAddStaff.TabIndex = 6;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(30, 153);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(21, 21);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 80;
            this.gunaPictureBox2.TabStop = false;
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchStaff.BaseColor = System.Drawing.Color.White;
            this.txtSearchStaff.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchStaff.BorderSize = 3;
            this.txtSearchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStaff.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchStaff.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSearchStaff.FocusedForeColor = System.Drawing.Color.Black;
            this.txtSearchStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaff.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStaff.Location = new System.Drawing.Point(54, 150);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.PasswordChar = '\0';
            this.txtSearchStaff.Radius = 5;
            this.txtSearchStaff.SelectedText = "";
            this.txtSearchStaff.Size = new System.Drawing.Size(107, 26);
            this.txtSearchStaff.TabIndex = 9;
            this.txtSearchStaff.TextOffsetX = 5;
            this.txtSearchStaff.TextChanged += new System.EventHandler(this.txtSearchStaff_TextChanged);
            this.txtSearchStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchStaff_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(301, 81);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel6.TabIndex = 94;
            this.gunaLabel6.Text = "Address";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(168, 81);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel1.TabIndex = 95;
            this.gunaLabel1.Text = "Salary";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(35, 81);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel4.TabIndex = 92;
            this.gunaLabel4.Text = "Sex";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGvStaff
            // 
            this.dGvStaff.AllowUserToAddRows = false;
            this.dGvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dGvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvStaff.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvStaff.EnableHeadersVisualStyles = false;
            this.dGvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvStaff.Location = new System.Drawing.Point(0, 227);
            this.dGvStaff.Name = "dGvStaff";
            this.dGvStaff.ReadOnly = true;
            this.dGvStaff.RowHeadersVisible = false;
            this.dGvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvStaff.Size = new System.Drawing.Size(460, 135);
            this.dGvStaff.TabIndex = 99;
            this.dGvStaff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGvStaff.ThemeStyle.HeaderStyle.Height = 25;
            this.dGvStaff.ThemeStyle.ReadOnly = true;
            this.dGvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvStaff.ThemeStyle.RowsStyle.Height = 22;
            this.dGvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvStaff_CellClick_1);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dGvStaff);
            this.Controls.Add(this.lblDisplayStaffId);
            this.Controls.Add(this.txtAddressStaff);
            this.Controls.Add(this.txtSalaryStaff);
            this.Controls.Add(this.cboxSexStaff);
            this.Controls.Add(this.txtLastNameStaff);
            this.Controls.Add(this.txtMobileStaff);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtFirstNameStaff);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Name = "frmStaff";
            this.Size = new System.Drawing.Size(460, 362);
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblDisplayStaffId;
        private Guna.UI.WinForms.GunaTextBox txtAddressStaff;
        private Guna.UI.WinForms.GunaTextBox txtSalaryStaff;
        private Guna.UI.WinForms.GunaComboBox cboxSexStaff;
        private Guna.UI.WinForms.GunaTextBox txtLastNameStaff;
        private Guna.UI.WinForms.GunaTextBox txtMobileStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtFirstNameStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnUpdateStaff;
        private Guna.UI.WinForms.GunaButton btnDeleteStaff;
        private Guna.UI.WinForms.GunaButton btnAddStaff;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox txtSearchStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dGvStaff;

    }
}
