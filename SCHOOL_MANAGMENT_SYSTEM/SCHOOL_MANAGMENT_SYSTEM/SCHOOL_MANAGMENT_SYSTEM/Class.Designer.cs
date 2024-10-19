namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class Class
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
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtClassName = new Guna.UI.WinForms.GunaTextBox();
            this.txtSearchClass = new Guna.UI.WinForms.GunaTextBox();
            this.dGvClass = new Guna.UI.WinForms.GunaDataGridView();
            this.lblDisplayCId = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDeleteClass = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateClass = new Guna.UI.WinForms.GunaButton();
            this.btnAddClass = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(35, 64);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(125, 30);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Class Name";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.Transparent;
            this.txtClassName.BaseColor = System.Drawing.Color.Blue;
            this.txtClassName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtClassName.BorderSize = 3;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtClassName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtClassName.FocusedForeColor = System.Drawing.Color.Blue;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClassName.ForeColor = System.Drawing.Color.White;
            this.txtClassName.Location = new System.Drawing.Point(176, 69);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.Radius = 5;
            this.txtClassName.SelectedText = "";
            this.txtClassName.Size = new System.Drawing.Size(227, 26);
            this.txtClassName.TabIndex = 3;
            this.txtClassName.TextOffsetX = 5;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchClass.BaseColor = System.Drawing.Color.White;
            this.txtSearchClass.BorderColor = System.Drawing.Color.Blue;
            this.txtSearchClass.BorderSize = 3;
            this.txtSearchClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClass.FocusedBaseColor = System.Drawing.Color.Blue;
            this.txtSearchClass.FocusedBorderColor = System.Drawing.Color.Magenta;
            this.txtSearchClass.FocusedForeColor = System.Drawing.Color.White;
            this.txtSearchClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClass.ForeColor = System.Drawing.Color.Black;
            this.txtSearchClass.Location = new System.Drawing.Point(209, 197);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.PasswordChar = '\0';
            this.txtSearchClass.Radius = 5;
            this.txtSearchClass.SelectedText = "";
            this.txtSearchClass.Size = new System.Drawing.Size(193, 26);
            this.txtSearchClass.TabIndex = 5;
            this.txtSearchClass.TextOffsetX = 5;
            // 
            // dGvClass
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvClass.BackgroundColor = System.Drawing.Color.Aqua;
            this.dGvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvClass.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGvClass.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGvClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGvClass.EnableHeadersVisualStyles = false;
            this.dGvClass.GridColor = System.Drawing.Color.Black;
            this.dGvClass.Location = new System.Drawing.Point(0, 248);
            this.dGvClass.Name = "dGvClass";
            this.dGvClass.RowHeadersVisible = false;
            this.dGvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvClass.Size = new System.Drawing.Size(452, 114);
            this.dGvClass.TabIndex = 6;
            this.dGvClass.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dGvClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGvClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGvClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGvClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGvClass.ThemeStyle.BackColor = System.Drawing.Color.Aqua;
            this.dGvClass.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dGvClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGvClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGvClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGvClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGvClass.ThemeStyle.HeaderStyle.Height = 4;
            this.dGvClass.ThemeStyle.ReadOnly = false;
            this.dGvClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGvClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGvClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dGvClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGvClass.ThemeStyle.RowsStyle.Height = 22;
            this.dGvClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGvClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblDisplayCId
            // 
            this.lblDisplayCId.BackColor = System.Drawing.Color.White;
            this.lblDisplayCId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayCId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisplayCId.Location = new System.Drawing.Point(22, 71);
            this.lblDisplayCId.Name = "lblDisplayCId";
            this.lblDisplayCId.Size = new System.Drawing.Size(14, 19);
            this.lblDisplayCId.TabIndex = 21;
            this.lblDisplayCId.Visible = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(176, 197);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(27, 26);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 4;
            this.gunaPictureBox2.TabStop = false;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.AnimationHoverSpeed = 0.07F;
            this.btnDeleteClass.AnimationSpeed = 0.03F;
            this.btnDeleteClass.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClass.BaseColor = System.Drawing.Color.Green;
            this.btnDeleteClass.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteClass.BorderSize = 3;
            this.btnDeleteClass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteClass.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClass.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnDeleteClass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteClass.Location = new System.Drawing.Point(315, 140);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnDeleteClass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteClass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteClass.OnHoverImage = null;
            this.btnDeleteClass.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteClass.Radius = 5;
            this.btnDeleteClass.Size = new System.Drawing.Size(83, 18);
            this.btnDeleteClass.TabIndex = 2;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.AnimationHoverSpeed = 0.07F;
            this.btnUpdateClass.AnimationSpeed = 0.03F;
            this.btnUpdateClass.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClass.BaseColor = System.Drawing.Color.Green;
            this.btnUpdateClass.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateClass.BorderSize = 3;
            this.btnUpdateClass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateClass.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClass.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnUpdateClass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateClass.Location = new System.Drawing.Point(175, 140);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnUpdateClass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateClass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateClass.OnHoverImage = null;
            this.btnUpdateClass.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateClass.Radius = 5;
            this.btnUpdateClass.Size = new System.Drawing.Size(83, 18);
            this.btnUpdateClass.TabIndex = 2;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddClass
            // 
            this.btnAddClass.AnimationHoverSpeed = 0.07F;
            this.btnAddClass.AnimationSpeed = 0.03F;
            this.btnAddClass.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClass.BaseColor = System.Drawing.Color.Green;
            this.btnAddClass.BorderColor = System.Drawing.Color.Black;
            this.btnAddClass.BorderSize = 3;
            this.btnAddClass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddClass.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.add;
            this.btnAddClass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddClass.Location = new System.Drawing.Point(35, 140);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAddClass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddClass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddClass.OnHoverImage = null;
            this.btnAddClass.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddClass.Radius = 5;
            this.btnAddClass.Size = new System.Drawing.Size(83, 18);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(452, 362);
            this.Controls.Add(this.lblDisplayCId);
            this.Controls.Add(this.dGvClass);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtSearchClass);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class";
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.dGvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txtClassName;
        private Guna.UI.WinForms.GunaButton btnAddClass;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnDeleteClass;
        private Guna.UI.WinForms.GunaButton btnUpdateClass;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox txtSearchClass;
        private Guna.UI.WinForms.GunaDataGridView dGvClass;
        private Guna.UI.WinForms.GunaLabel lblDisplayCId;
    }
}