namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class frmSubject
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
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearchSubject = new Guna.UI.WinForms.GunaTextBox();
            this.txtSubjectName = new Guna.UI.WinForms.GunaTextBox();
            this.btnDeleteSubject = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateSubject = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddSubject = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cboxClassnameSubject = new Guna.UI.WinForms.GunaComboBox();
            this.lblDisplaySId = new Guna.UI.WinForms.GunaLabel();
            this.dGvSubject = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(40, 109);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(27, 26);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 22;
            this.gunaPictureBox2.TabStop = false;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchSubject.BaseColor = System.Drawing.Color.White;
            this.txtSearchSubject.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchSubject.BorderSize = 3;
            this.txtSearchSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSubject.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchSubject.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSearchSubject.FocusedForeColor = System.Drawing.Color.Black;
            this.txtSearchSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSubject.ForeColor = System.Drawing.Color.Black;
            this.txtSearchSubject.Location = new System.Drawing.Point(73, 109);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.PasswordChar = '\0';
            this.txtSearchSubject.Radius = 5;
            this.txtSearchSubject.SelectedText = "";
            this.txtSearchSubject.Size = new System.Drawing.Size(97, 26);
            this.txtSearchSubject.TabIndex = 5;
            this.txtSearchSubject.TextOffsetX = 5;
            this.txtSearchSubject.TextChanged += new System.EventHandler(this.txtSearchSubject_TextChanged);
            this.txtSearchSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSubject_KeyPress);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.txtSubjectName.BaseColor = System.Drawing.Color.White;
            this.txtSubjectName.BorderColor = System.Drawing.Color.Magenta;
            this.txtSubjectName.BorderSize = 3;
            this.txtSubjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubjectName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSubjectName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtSubjectName.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtSubjectName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.ForeColor = System.Drawing.Color.Black;
            this.txtSubjectName.Location = new System.Drawing.Point(191, 36);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.PasswordChar = '\0';
            this.txtSubjectName.Radius = 5;
            this.txtSubjectName.SelectedText = "";
            this.txtSubjectName.Size = new System.Drawing.Size(193, 26);
            this.txtSubjectName.TabIndex = 0;
            this.txtSubjectName.TextOffsetX = 5;
            this.txtSubjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubjectName_KeyPress);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.AnimationHoverSpeed = 0.07F;
            this.btnDeleteSubject.AnimationSpeed = 0.03F;
            this.btnDeleteSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSubject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteSubject.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteSubject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteSubject.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSubject.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnDeleteSubject.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteSubject.Location = new System.Drawing.Point(320, 111);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDeleteSubject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteSubject.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteSubject.OnHoverImage = null;
            this.btnDeleteSubject.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteSubject.Radius = 7;
            this.btnDeleteSubject.Size = new System.Drawing.Size(63, 24);
            this.btnDeleteSubject.TabIndex = 4;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.AnimationHoverSpeed = 0.07F;
            this.btnUpdateSubject.AnimationSpeed = 0.03F;
            this.btnUpdateSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateSubject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateSubject.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateSubject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateSubject.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubject.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSubject.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnUpdateSubject.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateSubject.Location = new System.Drawing.Point(248, 111);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateSubject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateSubject.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateSubject.OnHoverImage = null;
            this.btnUpdateSubject.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateSubject.Radius = 7;
            this.btnUpdateSubject.Size = new System.Drawing.Size(63, 24);
            this.btnUpdateSubject.TabIndex = 3;
            this.btnUpdateSubject.Text = "Update";
            this.btnUpdateSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(35, 73);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(125, 30);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "Class Name";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.AnimationHoverSpeed = 0.07F;
            this.btnAddSubject.AnimationSpeed = 0.03F;
            this.btnAddSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddSubject.BorderColor = System.Drawing.Color.Black;
            this.btnAddSubject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSubject.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnAddSubject.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddSubject.Location = new System.Drawing.Point(176, 111);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAddSubject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSubject.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddSubject.OnHoverImage = null;
            this.btnAddSubject.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSubject.Radius = 7;
            this.btnAddSubject.Size = new System.Drawing.Size(63, 24);
            this.btnAddSubject.TabIndex = 2;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(35, 32);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(150, 30);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Subject Name";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxClassnameSubject
            // 
            this.cboxClassnameSubject.BackColor = System.Drawing.Color.Transparent;
            this.cboxClassnameSubject.BaseColor = System.Drawing.Color.White;
            this.cboxClassnameSubject.BorderColor = System.Drawing.Color.Magenta;
            this.cboxClassnameSubject.BorderSize = 3;
            this.cboxClassnameSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxClassnameSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClassnameSubject.FocusedColor = System.Drawing.Color.Empty;
            this.cboxClassnameSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxClassnameSubject.ForeColor = System.Drawing.Color.Black;
            this.cboxClassnameSubject.FormattingEnabled = true;
            this.cboxClassnameSubject.Items.AddRange(new object[] {
            "Select"});
            this.cboxClassnameSubject.Location = new System.Drawing.Point(191, 73);
            this.cboxClassnameSubject.Name = "cboxClassnameSubject";
            this.cboxClassnameSubject.OnHoverItemBaseColor = System.Drawing.Color.Magenta;
            this.cboxClassnameSubject.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cboxClassnameSubject.Radius = 5;
            this.cboxClassnameSubject.Size = new System.Drawing.Size(192, 30);
            this.cboxClassnameSubject.StartIndex = 0;
            this.cboxClassnameSubject.TabIndex = 1;
            this.cboxClassnameSubject.SelectedIndexChanged += new System.EventHandler(this.cboxClassnameSubject_SelectedIndexChanged);
            // 
            // lblDisplaySId
            // 
            this.lblDisplaySId.BackColor = System.Drawing.Color.Black;
            this.lblDisplaySId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplaySId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplaySId.ForeColor = System.Drawing.Color.White;
            this.lblDisplaySId.Location = new System.Drawing.Point(70, 13);
            this.lblDisplaySId.Name = "lblDisplaySId";
            this.lblDisplaySId.Size = new System.Drawing.Size(32, 19);
            this.lblDisplaySId.TabIndex = 96;
            this.lblDisplaySId.Visible = false;
            // 
            // dGvSubject
            // 
            this.dGvSubject.AllowUserToAddRows = false;
            this.dGvSubject.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvSubject.BackgroundColor = System.Drawing.Color.White;
            this.dGvSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvSubject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvSubject.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvSubject.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvSubject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvSubject.EnableHeadersVisualStyles = false;
            this.dGvSubject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvSubject.Location = new System.Drawing.Point(0, 203);
            this.dGvSubject.Name = "dGvSubject";
            this.dGvSubject.ReadOnly = true;
            this.dGvSubject.RowHeadersVisible = false;
            this.dGvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvSubject.Size = new System.Drawing.Size(452, 159);
            this.dGvSubject.TabIndex = 97;
            this.dGvSubject.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvSubject.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvSubject.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvSubject.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvSubject.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvSubject.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvSubject.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGvSubject.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvSubject.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvSubject.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvSubject.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvSubject.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvSubject.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGvSubject.ThemeStyle.HeaderStyle.Height = 25;
            this.dGvSubject.ThemeStyle.ReadOnly = true;
            this.dGvSubject.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvSubject.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvSubject.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvSubject.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvSubject.ThemeStyle.RowsStyle.Height = 22;
            this.dGvSubject.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvSubject.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvSubject_CellClick);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dGvSubject);
            this.Controls.Add(this.lblDisplaySId);
            this.Controls.Add(this.cboxClassnameSubject);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtSearchSubject);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "frmSubject";
            this.Size = new System.Drawing.Size(452, 362);
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox txtSearchSubject;
        private Guna.UI.WinForms.GunaTextBox txtSubjectName;
        private Guna.UI.WinForms.GunaButton btnDeleteSubject;
        private Guna.UI.WinForms.GunaButton btnUpdateSubject;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnAddSubject;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cboxClassnameSubject;
        private Guna.UI.WinForms.GunaLabel lblDisplaySId;
        private Guna.UI.WinForms.GunaDataGridView dGvSubject;
    }
}
