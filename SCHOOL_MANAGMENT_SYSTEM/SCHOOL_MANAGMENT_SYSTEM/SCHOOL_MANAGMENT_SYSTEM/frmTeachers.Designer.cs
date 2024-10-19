namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class frmTeachers
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
            this.dateOfBirthTeacher = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cboxSexTeacher = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtSalaryTeacher = new Guna.UI.WinForms.GunaTextBox();
            this.txtSearchTeacher = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtLastNameTeacher = new Guna.UI.WinForms.GunaTextBox();
            this.txtMobileTeacher = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtFirstNameTeacher = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ComboBoxSubjects = new Guna.UI.WinForms.GunaComboBox();
            this.btnUpdateTeacher = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteTeacher = new Guna.UI.WinForms.GunaButton();
            this.btnAddTeacher = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblDisplayTId = new Guna.UI.WinForms.GunaLabel();
            this.dGvTeacher = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfBirthTeacher
            // 
            this.dateOfBirthTeacher.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthTeacher.BaseColor = System.Drawing.Color.White;
            this.dateOfBirthTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.dateOfBirthTeacher.BorderSize = 3;
            this.dateOfBirthTeacher.CustomFormat = null;
            this.dateOfBirthTeacher.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfBirthTeacher.FocusedColor = System.Drawing.Color.Red;
            this.dateOfBirthTeacher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTeacher.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthTeacher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthTeacher.Location = new System.Drawing.Point(29, 164);
            this.dateOfBirthTeacher.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthTeacher.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthTeacher.Name = "dateOfBirthTeacher";
            this.dateOfBirthTeacher.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateOfBirthTeacher.OnHoverBorderColor = System.Drawing.Color.Red;
            this.dateOfBirthTeacher.OnHoverForeColor = System.Drawing.Color.Black;
            this.dateOfBirthTeacher.OnPressedColor = System.Drawing.Color.White;
            this.dateOfBirthTeacher.Radius = 5;
            this.dateOfBirthTeacher.Size = new System.Drawing.Size(190, 24);
            this.dateOfBirthTeacher.TabIndex = 6;
            this.dateOfBirthTeacher.Text = "12/11/2022";
            this.dateOfBirthTeacher.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(23, 135);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(139, 35);
            this.gunaLabel5.TabIndex = 67;
            this.gunaLabel5.Text = "Date of birth";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // cboxSexTeacher
            // 
            this.cboxSexTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cboxSexTeacher.BaseColor = System.Drawing.Color.White;
            this.cboxSexTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.cboxSexTeacher.BorderSize = 3;
            this.cboxSexTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSexTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexTeacher.FocusedColor = System.Drawing.Color.Empty;
            this.cboxSexTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSexTeacher.ForeColor = System.Drawing.Color.Black;
            this.cboxSexTeacher.FormattingEnabled = true;
            this.cboxSexTeacher.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.cboxSexTeacher.Location = new System.Drawing.Point(29, 111);
            this.cboxSexTeacher.Name = "cboxSexTeacher";
            this.cboxSexTeacher.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cboxSexTeacher.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cboxSexTeacher.Radius = 5;
            this.cboxSexTeacher.Size = new System.Drawing.Size(118, 30);
            this.cboxSexTeacher.StartIndex = 0;
            this.cboxSexTeacher.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(34, 84);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel4.TabIndex = 65;
            this.gunaLabel4.Text = "Sex";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // txtSalaryTeacher
            // 
            this.txtSalaryTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtSalaryTeacher.BaseColor = System.Drawing.Color.White;
            this.txtSalaryTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.txtSalaryTeacher.BorderSize = 3;
            this.txtSalaryTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalaryTeacher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalaryTeacher.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSalaryTeacher.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtSalaryTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtSalaryTeacher.Location = new System.Drawing.Point(295, 115);
            this.txtSalaryTeacher.MaxLength = 4;
            this.txtSalaryTeacher.Name = "txtSalaryTeacher";
            this.txtSalaryTeacher.PasswordChar = '\0';
            this.txtSalaryTeacher.Radius = 5;
            this.txtSalaryTeacher.SelectedText = "";
            this.txtSalaryTeacher.Size = new System.Drawing.Size(118, 26);
            this.txtSalaryTeacher.TabIndex = 5;
            this.txtSalaryTeacher.TextOffsetX = 5;
            this.txtSalaryTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryTeacher_KeyPress);
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchTeacher.BaseColor = System.Drawing.Color.White;
            this.txtSearchTeacher.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchTeacher.BorderSize = 3;
            this.txtSearchTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTeacher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchTeacher.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSearchTeacher.FocusedForeColor = System.Drawing.Color.Black;
            this.txtSearchTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtSearchTeacher.Location = new System.Drawing.Point(56, 196);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.PasswordChar = '\0';
            this.txtSearchTeacher.Radius = 5;
            this.txtSearchTeacher.SelectedText = "";
            this.txtSearchTeacher.Size = new System.Drawing.Size(111, 26);
            this.txtSearchTeacher.TabIndex = 7;
            this.txtSearchTeacher.TextOffsetX = 5;
            this.txtSearchTeacher.TextChanged += new System.EventHandler(this.txtSearchTeacher_TextChanged);
            this.txtSearchTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTeacher_KeyPress);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(300, 84);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel7.TabIndex = 49;
            this.gunaLabel7.Text = "Salary";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel7.Click += new System.EventHandler(this.gunaLabel7_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(167, 84);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(113, 37);
            this.gunaLabel6.TabIndex = 50;
            this.gunaLabel6.Text = "Subject Name";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel6.Click += new System.EventHandler(this.gunaLabel6_Click);
            // 
            // txtLastNameTeacher
            // 
            this.txtLastNameTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtLastNameTeacher.BaseColor = System.Drawing.Color.White;
            this.txtLastNameTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.txtLastNameTeacher.BorderSize = 3;
            this.txtLastNameTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameTeacher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLastNameTeacher.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtLastNameTeacher.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtLastNameTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtLastNameTeacher.Location = new System.Drawing.Point(162, 63);
            this.txtLastNameTeacher.Name = "txtLastNameTeacher";
            this.txtLastNameTeacher.PasswordChar = '\0';
            this.txtLastNameTeacher.Radius = 5;
            this.txtLastNameTeacher.SelectedText = "";
            this.txtLastNameTeacher.Size = new System.Drawing.Size(118, 26);
            this.txtLastNameTeacher.TabIndex = 1;
            this.txtLastNameTeacher.TextOffsetX = 5;
            this.txtLastNameTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastNameTeacher_KeyPress);
            // 
            // txtMobileTeacher
            // 
            this.txtMobileTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtMobileTeacher.BaseColor = System.Drawing.Color.White;
            this.txtMobileTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.txtMobileTeacher.BorderSize = 3;
            this.txtMobileTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobileTeacher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMobileTeacher.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMobileTeacher.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtMobileTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtMobileTeacher.Location = new System.Drawing.Point(295, 64);
            this.txtMobileTeacher.MaxLength = 9;
            this.txtMobileTeacher.Name = "txtMobileTeacher";
            this.txtMobileTeacher.PasswordChar = '\0';
            this.txtMobileTeacher.Radius = 5;
            this.txtMobileTeacher.SelectedText = "";
            this.txtMobileTeacher.Size = new System.Drawing.Size(118, 26);
            this.txtMobileTeacher.TabIndex = 2;
            this.txtMobileTeacher.TextOffsetX = 5;
            this.txtMobileTeacher.TextChanged += new System.EventHandler(this.txtMobileTeacher_TextChanged);
            this.txtMobileTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileTeacher_KeyPress);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(303, 31);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(90, 38);
            this.gunaLabel8.TabIndex = 52;
            this.gunaLabel8.Text = "Mobile";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel8.Click += new System.EventHandler(this.gunaLabel8_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(171, 31);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel3.TabIndex = 51;
            this.gunaLabel3.Text = "Last Name";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // txtFirstNameTeacher
            // 
            this.txtFirstNameTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstNameTeacher.BaseColor = System.Drawing.Color.White;
            this.txtFirstNameTeacher.BorderColor = System.Drawing.Color.Magenta;
            this.txtFirstNameTeacher.BorderSize = 3;
            this.txtFirstNameTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstNameTeacher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFirstNameTeacher.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtFirstNameTeacher.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtFirstNameTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtFirstNameTeacher.Location = new System.Drawing.Point(29, 63);
            this.txtFirstNameTeacher.Name = "txtFirstNameTeacher";
            this.txtFirstNameTeacher.PasswordChar = '\0';
            this.txtFirstNameTeacher.Radius = 5;
            this.txtFirstNameTeacher.SelectedText = "";
            this.txtFirstNameTeacher.Size = new System.Drawing.Size(118, 26);
            this.txtFirstNameTeacher.TabIndex = 0;
            this.txtFirstNameTeacher.TextOffsetX = 5;
            this.txtFirstNameTeacher.TextChanged += new System.EventHandler(this.txtFirstNameTeacher_TextChanged);
            this.txtFirstNameTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNameTeacher_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 38);
            this.gunaLabel2.TabIndex = 53;
            this.gunaLabel2.Text = "First Name";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // ComboBoxSubjects
            // 
            this.ComboBoxSubjects.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSubjects.BaseColor = System.Drawing.Color.White;
            this.ComboBoxSubjects.BorderColor = System.Drawing.Color.Magenta;
            this.ComboBoxSubjects.BorderSize = 3;
            this.ComboBoxSubjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubjects.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxSubjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubjects.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSubjects.FormattingEnabled = true;
            this.ComboBoxSubjects.Items.AddRange(new object[] {
            "Select"});
            this.ComboBoxSubjects.Location = new System.Drawing.Point(162, 111);
            this.ComboBoxSubjects.Name = "ComboBoxSubjects";
            this.ComboBoxSubjects.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.ComboBoxSubjects.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxSubjects.Radius = 5;
            this.ComboBoxSubjects.Size = new System.Drawing.Size(118, 30);
            this.ComboBoxSubjects.StartIndex = 0;
            this.ComboBoxSubjects.TabIndex = 4;
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.AnimationHoverSpeed = 0.07F;
            this.btnUpdateTeacher.AnimationSpeed = 0.03F;
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTeacher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateTeacher.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateTeacher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateTeacher.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeacher.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTeacher.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Edit_Icon;
            this.btnUpdateTeacher.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateTeacher.Location = new System.Drawing.Point(261, 204);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateTeacher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateTeacher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateTeacher.OnHoverImage = null;
            this.btnUpdateTeacher.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateTeacher.Radius = 5;
            this.btnUpdateTeacher.Size = new System.Drawing.Size(83, 18);
            this.btnUpdateTeacher.TabIndex = 9;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.AnimationHoverSpeed = 0.07F;
            this.btnDeleteTeacher.AnimationSpeed = 0.03F;
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTeacher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteTeacher.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteTeacher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteTeacher.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Delete_Icon;
            this.btnDeleteTeacher.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteTeacher.Location = new System.Drawing.Point(350, 204);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDeleteTeacher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteTeacher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.OnHoverImage = null;
            this.btnDeleteTeacher.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteTeacher.Radius = 5;
            this.btnDeleteTeacher.Size = new System.Drawing.Size(83, 18);
            this.btnDeleteTeacher.TabIndex = 10;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.AnimationHoverSpeed = 0.07F;
            this.btnAddTeacher.AnimationSpeed = 0.03F;
            this.btnAddTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddTeacher.BorderColor = System.Drawing.Color.Black;
            this.btnAddTeacher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddTeacher.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnAddTeacher.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddTeacher.Location = new System.Drawing.Point(172, 204);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAddTeacher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddTeacher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.OnHoverImage = null;
            this.btnAddTeacher.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddTeacher.Radius = 5;
            this.btnAddTeacher.Size = new System.Drawing.Size(83, 18);
            this.btnAddTeacher.TabIndex = 8;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
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
            this.gunaPictureBox2.TabIndex = 69;
            this.gunaPictureBox2.TabStop = false;
            // 
            // lblDisplayTId
            // 
            this.lblDisplayTId.BackColor = System.Drawing.Color.Black;
            this.lblDisplayTId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayTId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplayTId.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTId.Location = new System.Drawing.Point(26, 12);
            this.lblDisplayTId.Name = "lblDisplayTId";
            this.lblDisplayTId.Size = new System.Drawing.Size(14, 19);
            this.lblDisplayTId.TabIndex = 70;
            this.lblDisplayTId.Visible = false;
            // 
            // dGvTeacher
            // 
            this.dGvTeacher.AllowUserToAddRows = false;
            this.dGvTeacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvTeacher.BackgroundColor = System.Drawing.Color.White;
            this.dGvTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvTeacher.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvTeacher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvTeacher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvTeacher.EnableHeadersVisualStyles = false;
            this.dGvTeacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvTeacher.Location = new System.Drawing.Point(0, 273);
            this.dGvTeacher.Name = "dGvTeacher";
            this.dGvTeacher.ReadOnly = true;
            this.dGvTeacher.RowHeadersVisible = false;
            this.dGvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvTeacher.Size = new System.Drawing.Size(452, 89);
            this.dGvTeacher.TabIndex = 71;
            this.dGvTeacher.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvTeacher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvTeacher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGvTeacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvTeacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGvTeacher.ThemeStyle.HeaderStyle.Height = 25;
            this.dGvTeacher.ThemeStyle.ReadOnly = true;
            this.dGvTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvTeacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvTeacher.ThemeStyle.RowsStyle.Height = 22;
            this.dGvTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvTeacher_CellClick_1);
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dGvTeacher);
            this.Controls.Add(this.lblDisplayTId);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.dateOfBirthTeacher);
            this.Controls.Add(this.ComboBoxSubjects);
            this.Controls.Add(this.cboxSexTeacher);
            this.Controls.Add(this.txtSalaryTeacher);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtSearchTeacher);
            this.Controls.Add(this.txtLastNameTeacher);
            this.Controls.Add(this.txtMobileTeacher);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtFirstNameTeacher);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Name = "frmTeachers";
            this.Size = new System.Drawing.Size(452, 362);
            this.Load += new System.EventHandler(this.frmTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker dateOfBirthTeacher;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cboxSexTeacher;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtSalaryTeacher;
        private Guna.UI.WinForms.GunaButton btnUpdateTeacher;
        private Guna.UI.WinForms.GunaButton btnDeleteTeacher;
        private Guna.UI.WinForms.GunaButton btnAddTeacher;
        private Guna.UI.WinForms.GunaTextBox txtSearchTeacher;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtLastNameTeacher;
        private Guna.UI.WinForms.GunaTextBox txtMobileTeacher;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtFirstNameTeacher;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox ComboBoxSubjects;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel lblDisplayTId;
        private Guna.UI.WinForms.GunaDataGridView dGvTeacher;
    }
}
