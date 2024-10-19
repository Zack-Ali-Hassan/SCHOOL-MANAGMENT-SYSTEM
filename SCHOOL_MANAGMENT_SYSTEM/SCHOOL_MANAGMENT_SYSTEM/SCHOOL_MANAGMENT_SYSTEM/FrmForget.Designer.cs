namespace SCHOOL_MANAGMENT_SYSTEM
{
    partial class FrmForget
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtConfirmNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsernameOrMobile = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Blue;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(377, 52);
            this.gunaPanel1.TabIndex = 13;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Blue;
            this.gunaPictureBox2.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.delete_24px;
            this.gunaPictureBox2.Location = new System.Drawing.Point(333, 14);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 16;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(377, 52);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Forget Password";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtConfirmNewPassword.BorderColor = System.Drawing.Color.Blue;
            this.txtConfirmNewPassword.BorderSize = 3;
            this.txtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirmNewPassword.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtConfirmNewPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(24, 285);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '\0';
            this.txtConfirmNewPassword.Radius = 15;
            this.txtConfirmNewPassword.SelectedText = "";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(334, 38);
            this.txtConfirmNewPassword.TabIndex = 2;
            this.txtConfirmNewPassword.TextOffsetX = 8;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderColor = System.Drawing.Color.Blue;
            this.txtNewPassword.BorderSize = 3;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPassword.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtNewPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(24, 198);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.Radius = 15;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(334, 38);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextOffsetX = 8;
            // 
            // txtUsernameOrMobile
            // 
            this.txtUsernameOrMobile.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameOrMobile.BaseColor = System.Drawing.Color.White;
            this.txtUsernameOrMobile.BorderColor = System.Drawing.Color.Blue;
            this.txtUsernameOrMobile.BorderSize = 3;
            this.txtUsernameOrMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameOrMobile.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsernameOrMobile.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtUsernameOrMobile.FocusedForeColor = System.Drawing.Color.Black;
            this.txtUsernameOrMobile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtUsernameOrMobile.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameOrMobile.Location = new System.Drawing.Point(24, 111);
            this.txtUsernameOrMobile.Name = "txtUsernameOrMobile";
            this.txtUsernameOrMobile.PasswordChar = '\0';
            this.txtUsernameOrMobile.Radius = 15;
            this.txtUsernameOrMobile.SelectedText = "";
            this.txtUsernameOrMobile.Size = new System.Drawing.Size(334, 38);
            this.txtUsernameOrMobile.TabIndex = 0;
            this.txtUsernameOrMobile.TextOffsetX = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm New Passsword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(106, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username/Mobile";
            // 
            // btnCreate
            // 
            this.btnCreate.AnimationHoverSpeed = 0.07F;
            this.btnCreate.AnimationSpeed = 0.03F;
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BaseColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderColor = System.Drawing.Color.Blue;
            this.btnCreate.BorderSize = 3;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreate.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.Edit_Icon3;
            this.btnCreate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCreate.Location = new System.Drawing.Point(190, 352);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnCreate.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.btnCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCreate.OnHoverImage = null;
            this.btnCreate.OnPressedColor = System.Drawing.Color.Blue;
            this.btnCreate.Radius = 15;
            this.btnCreate.Size = new System.Drawing.Size(160, 42);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Blue;
            this.btnBack.BorderSize = 3;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::SCHOOL_MANAGMENT_SYSTEM.Properties.Resources.exit4;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(24, 352);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Blue;
            this.btnBack.Radius = 15;
            this.btnBack.Size = new System.Drawing.Size(160, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 405);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtUsernameOrMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForget";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnCreate;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox txtConfirmNewPassword;
        public Guna.UI.WinForms.GunaTextBox txtNewPassword;
        public Guna.UI.WinForms.GunaTextBox txtUsernameOrMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
    }
}