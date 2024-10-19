namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class Attendence
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
            this.dateAttendence = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cboxAttendence = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSaveAttendence = new Guna.UI.WinForms.GunaButton();
            this.btnEditAttendence = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearchStudentAttendence = new Guna.UI.WinForms.GunaTextBox();
            this.lblDisplayAttendenceId = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ComboBoxStuIdAttendence = new Guna.UI.WinForms.GunaComboBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // dateAttendence
            // 
            this.dateAttendence.BackColor = System.Drawing.Color.Transparent;
            this.dateAttendence.BaseColor = System.Drawing.Color.Blue;
            this.dateAttendence.BorderColor = System.Drawing.Color.White;
            this.dateAttendence.BorderSize = 3;
            this.dateAttendence.CustomFormat = null;
            this.dateAttendence.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateAttendence.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateAttendence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAttendence.ForeColor = System.Drawing.Color.White;
            this.dateAttendence.Location = new System.Drawing.Point(171, 125);
            this.dateAttendence.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateAttendence.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateAttendence.Name = "dateAttendence";
            this.dateAttendence.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateAttendence.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateAttendence.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateAttendence.OnPressedColor = System.Drawing.Color.Black;
            this.dateAttendence.Radius = 5;
            this.dateAttendence.Size = new System.Drawing.Size(215, 26);
            this.dateAttendence.TabIndex = 32;
            this.dateAttendence.Text = "Sunday, December 11, 2022";
            this.dateAttendence.Value = new System.DateTime(2022, 12, 11, 0, 48, 45, 641);
            // 
            // cboxAttendence
            // 
            this.cboxAttendence.BackColor = System.Drawing.Color.Transparent;
            this.cboxAttendence.BaseColor = System.Drawing.Color.Blue;
            this.cboxAttendence.BorderColor = System.Drawing.Color.White;
            this.cboxAttendence.BorderSize = 3;
            this.cboxAttendence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxAttendence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAttendence.FocusedColor = System.Drawing.Color.Empty;
            this.cboxAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAttendence.ForeColor = System.Drawing.Color.White;
            this.cboxAttendence.FormattingEnabled = true;
            this.cboxAttendence.Items.AddRange(new object[] {
            "Present",
            "Absence"});
            this.cboxAttendence.Location = new System.Drawing.Point(172, 81);
            this.cboxAttendence.Name = "cboxAttendence";
            this.cboxAttendence.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cboxAttendence.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cboxAttendence.Radius = 5;
            this.cboxAttendence.Size = new System.Drawing.Size(214, 30);
            this.cboxAttendence.TabIndex = 31;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(10, 79);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(140, 35);
            this.gunaLabel4.TabIndex = 29;
            this.gunaLabel4.Text = "Status";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(1, 119);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 26);
            this.gunaLabel5.TabIndex = 30;
            this.gunaLabel5.Text = "Date";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveAttendence
            // 
            this.btnSaveAttendence.AnimationHoverSpeed = 0.07F;
            this.btnSaveAttendence.AnimationSpeed = 0.03F;
            this.btnSaveAttendence.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAttendence.BaseColor = System.Drawing.Color.Green;
            this.btnSaveAttendence.BorderColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.BorderSize = 3;
            this.btnSaveAttendence.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveAttendence.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAttendence.ForeColor = System.Drawing.Color.White;
            this.btnSaveAttendence.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnSaveAttendence.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveAttendence.Location = new System.Drawing.Point(99, 157);
            this.btnSaveAttendence.Name = "btnSaveAttendence";
            this.btnSaveAttendence.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnSaveAttendence.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveAttendence.OnHoverImage = null;
            this.btnSaveAttendence.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveAttendence.Radius = 5;
            this.btnSaveAttendence.Size = new System.Drawing.Size(83, 18);
            this.btnSaveAttendence.TabIndex = 35;
            this.btnSaveAttendence.Text = "Save";
            this.btnSaveAttendence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditAttendence
            // 
            this.btnEditAttendence.AnimationHoverSpeed = 0.07F;
            this.btnEditAttendence.AnimationSpeed = 0.03F;
            this.btnEditAttendence.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAttendence.BaseColor = System.Drawing.Color.Green;
            this.btnEditAttendence.BorderColor = System.Drawing.Color.Black;
            this.btnEditAttendence.BorderSize = 3;
            this.btnEditAttendence.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditAttendence.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAttendence.ForeColor = System.Drawing.Color.White;
            this.btnEditAttendence.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnEditAttendence.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditAttendence.Location = new System.Drawing.Point(200, 157);
            this.btnEditAttendence.Name = "btnEditAttendence";
            this.btnEditAttendence.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnEditAttendence.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditAttendence.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditAttendence.OnHoverImage = null;
            this.btnEditAttendence.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditAttendence.Radius = 5;
            this.btnEditAttendence.Size = new System.Drawing.Size(83, 18);
            this.btnEditAttendence.TabIndex = 35;
            this.btnEditAttendence.Text = "Edit";
            this.btnEditAttendence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(49, 181);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(27, 26);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 36;
            this.gunaPictureBox2.TabStop = false;
            // 
            // txtSearchStudentAttendence
            // 
            this.txtSearchStudentAttendence.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchStudentAttendence.BaseColor = System.Drawing.Color.White;
            this.txtSearchStudentAttendence.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchStudentAttendence.BorderSize = 3;
            this.txtSearchStudentAttendence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStudentAttendence.FocusedBaseColor = System.Drawing.Color.Blue;
            this.txtSearchStudentAttendence.FocusedBorderColor = System.Drawing.Color.Magenta;
            this.txtSearchStudentAttendence.FocusedForeColor = System.Drawing.Color.White;
            this.txtSearchStudentAttendence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudentAttendence.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStudentAttendence.Location = new System.Drawing.Point(82, 181);
            this.txtSearchStudentAttendence.Name = "txtSearchStudentAttendence";
            this.txtSearchStudentAttendence.PasswordChar = '\0';
            this.txtSearchStudentAttendence.Radius = 5;
            this.txtSearchStudentAttendence.SelectedText = "";
            this.txtSearchStudentAttendence.Size = new System.Drawing.Size(302, 26);
            this.txtSearchStudentAttendence.TabIndex = 37;
            // 
            // lblDisplayAttendenceId
            // 
            this.lblDisplayAttendenceId.BackColor = System.Drawing.Color.White;
            this.lblDisplayAttendenceId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayAttendenceId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplayAttendenceId.Location = new System.Drawing.Point(46, 10);
            this.lblDisplayAttendenceId.Name = "lblDisplayAttendenceId";
            this.lblDisplayAttendenceId.Size = new System.Drawing.Size(37, 29);
            this.lblDisplayAttendenceId.TabIndex = 39;
            this.lblDisplayAttendenceId.Visible = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(33, 39);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 35);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Student Id";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxStuIdAttendence
            // 
            this.ComboBoxStuIdAttendence.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxStuIdAttendence.BaseColor = System.Drawing.Color.Blue;
            this.ComboBoxStuIdAttendence.BorderColor = System.Drawing.Color.White;
            this.ComboBoxStuIdAttendence.BorderSize = 3;
            this.ComboBoxStuIdAttendence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStuIdAttendence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStuIdAttendence.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxStuIdAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStuIdAttendence.ForeColor = System.Drawing.Color.White;
            this.ComboBoxStuIdAttendence.FormattingEnabled = true;
            this.ComboBoxStuIdAttendence.Items.AddRange(new object[] {
            "Present",
            "Absence"});
            this.ComboBoxStuIdAttendence.Location = new System.Drawing.Point(172, 39);
            this.ComboBoxStuIdAttendence.Name = "ComboBoxStuIdAttendence";
            this.ComboBoxStuIdAttendence.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.ComboBoxStuIdAttendence.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxStuIdAttendence.Radius = 5;
            this.ComboBoxStuIdAttendence.Size = new System.Drawing.Size(214, 30);
            this.ComboBoxStuIdAttendence.TabIndex = 31;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Green;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderSize = 3;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(301, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(83, 18);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(452, 362);
            this.Controls.Add(this.lblDisplayAttendenceId);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtSearchStudentAttendence);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditAttendence);
            this.Controls.Add(this.btnSaveAttendence);
            this.Controls.Add(this.dateAttendence);
            this.Controls.Add(this.ComboBoxStuIdAttendence);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cboxAttendence);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel5);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendence";
            this.Text = "Attendence";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDateTimePicker dateAttendence;
        private Guna.UI.WinForms.GunaComboBox cboxAttendence;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaButton btnSaveAttendence;
        private Guna.UI.WinForms.GunaButton btnEditAttendence;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox txtSearchStudentAttendence;
        private Guna.UI.WinForms.GunaLabel lblDisplayAttendenceId;
        private Guna.UI.WinForms.GunaComboBox ComboBoxStuIdAttendence;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnDelete;
    }
}