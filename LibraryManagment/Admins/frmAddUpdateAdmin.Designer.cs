namespace LibraryManagment.Admins
{
    partial class frmAddUpdateAdmin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbAddMode = new System.Windows.Forms.GroupBox();
            this.picAddConfirmPassword = new System.Windows.Forms.PictureBox();
            this.txtAddConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblAddConfirmPassword = new System.Windows.Forms.Label();
            this.picAddPassword = new System.Windows.Forms.PictureBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.grbUpdateMode = new System.Windows.Forms.GroupBox();
            this.checkResetPassword = new System.Windows.Forms.CheckBox();
            this.picUpdateConfirmPassword = new System.Windows.Forms.PictureBox();
            this.txtUpdateConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblUpdateConfirmPassword = new System.Windows.Forms.Label();
            this.picUpdateNewPassword = new System.Windows.Forms.PictureBox();
            this.txtUpdateNewPassword = new System.Windows.Forms.TextBox();
            this.lblUpdateNewPassword = new System.Windows.Forms.Label();
            this.picUpdateCurrentPassword = new System.Windows.Forms.PictureBox();
            this.txtUpdateCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblUpdateCurrentPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAdminIDValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbAddMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPassword)).BeginInit();
            this.grbUpdateMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(416, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin ID:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(136, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 26);
            this.txtName.TabIndex = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(136, 268);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(297, 26);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(136, 343);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(148, 26);
            this.txtRole.TabIndex = 11;
            this.txtRole.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(828, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManagment.Properties.Resources.user__2_;
            this.pictureBox4.Location = new System.Drawing.Point(106, 343);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryManagment.Properties.Resources.driver_license;
            this.pictureBox3.Location = new System.Drawing.Point(106, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagment.Properties.Resources.driver_license;
            this.pictureBox2.Location = new System.Drawing.Point(106, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagment.Properties.Resources.driver_license;
            this.pictureBox1.Location = new System.Drawing.Point(106, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grbAddMode
            // 
            this.grbAddMode.Controls.Add(this.picAddConfirmPassword);
            this.grbAddMode.Controls.Add(this.txtAddConfirmPassword);
            this.grbAddMode.Controls.Add(this.lblAddConfirmPassword);
            this.grbAddMode.Controls.Add(this.picAddPassword);
            this.grbAddMode.Controls.Add(this.txtAddPassword);
            this.grbAddMode.Controls.Add(this.lblAddPassword);
            this.grbAddMode.Location = new System.Drawing.Point(469, 96);
            this.grbAddMode.Name = "grbAddMode";
            this.grbAddMode.Size = new System.Drawing.Size(511, 141);
            this.grbAddMode.TabIndex = 29;
            this.grbAddMode.TabStop = false;
            // 
            // picAddConfirmPassword
            // 
            this.picAddConfirmPassword.Image = global::LibraryManagment.Properties.Resources.padlock__1_;
            this.picAddConfirmPassword.Location = new System.Drawing.Point(165, 97);
            this.picAddConfirmPassword.Name = "picAddConfirmPassword";
            this.picAddConfirmPassword.Size = new System.Drawing.Size(24, 24);
            this.picAddConfirmPassword.TabIndex = 34;
            this.picAddConfirmPassword.TabStop = false;
            // 
            // txtAddConfirmPassword
            // 
            this.txtAddConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddConfirmPassword.Location = new System.Drawing.Point(195, 97);
            this.txtAddConfirmPassword.Name = "txtAddConfirmPassword";
            this.txtAddConfirmPassword.PasswordChar = '*';
            this.txtAddConfirmPassword.Size = new System.Drawing.Size(307, 26);
            this.txtAddConfirmPassword.TabIndex = 33;
            this.txtAddConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddConfirmPassword_Validating);
            // 
            // lblAddConfirmPassword
            // 
            this.lblAddConfirmPassword.AutoSize = true;
            this.lblAddConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddConfirmPassword.Location = new System.Drawing.Point(20, 102);
            this.lblAddConfirmPassword.Name = "lblAddConfirmPassword";
            this.lblAddConfirmPassword.Size = new System.Drawing.Size(141, 20);
            this.lblAddConfirmPassword.TabIndex = 32;
            this.lblAddConfirmPassword.Text = "Confirm Password:";
            // 
            // picAddPassword
            // 
            this.picAddPassword.Image = global::LibraryManagment.Properties.Resources.padlock__1_;
            this.picAddPassword.Location = new System.Drawing.Point(165, 22);
            this.picAddPassword.Name = "picAddPassword";
            this.picAddPassword.Size = new System.Drawing.Size(24, 24);
            this.picAddPassword.TabIndex = 31;
            this.picAddPassword.TabStop = false;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPassword.Location = new System.Drawing.Point(195, 22);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(307, 26);
            this.txtAddPassword.TabIndex = 30;
            this.txtAddPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddPassword_Validating);
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPassword.Location = new System.Drawing.Point(20, 28);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(82, 20);
            this.lblAddPassword.TabIndex = 29;
            this.lblAddPassword.Text = "Password:";
            // 
            // grbUpdateMode
            // 
            this.grbUpdateMode.Controls.Add(this.checkResetPassword);
            this.grbUpdateMode.Controls.Add(this.picUpdateConfirmPassword);
            this.grbUpdateMode.Controls.Add(this.txtUpdateConfirmPassword);
            this.grbUpdateMode.Controls.Add(this.lblUpdateConfirmPassword);
            this.grbUpdateMode.Controls.Add(this.picUpdateNewPassword);
            this.grbUpdateMode.Controls.Add(this.txtUpdateNewPassword);
            this.grbUpdateMode.Controls.Add(this.lblUpdateNewPassword);
            this.grbUpdateMode.Controls.Add(this.picUpdateCurrentPassword);
            this.grbUpdateMode.Controls.Add(this.txtUpdateCurrentPassword);
            this.grbUpdateMode.Controls.Add(this.lblUpdateCurrentPassword);
            this.grbUpdateMode.Location = new System.Drawing.Point(469, 257);
            this.grbUpdateMode.Name = "grbUpdateMode";
            this.grbUpdateMode.Size = new System.Drawing.Size(511, 277);
            this.grbUpdateMode.TabIndex = 30;
            this.grbUpdateMode.TabStop = false;
            // 
            // checkResetPassword
            // 
            this.checkResetPassword.AutoSize = true;
            this.checkResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResetPassword.Location = new System.Drawing.Point(10, 34);
            this.checkResetPassword.Name = "checkResetPassword";
            this.checkResetPassword.Size = new System.Drawing.Size(143, 24);
            this.checkResetPassword.TabIndex = 31;
            this.checkResetPassword.Text = "Reset password";
            this.checkResetPassword.UseVisualStyleBackColor = true;
            this.checkResetPassword.CheckedChanged += new System.EventHandler(this.checkResetPassword_CheckedChanged);
            // 
            // picUpdateConfirmPassword
            // 
            this.picUpdateConfirmPassword.Image = global::LibraryManagment.Properties.Resources.padlock__1_;
            this.picUpdateConfirmPassword.Location = new System.Drawing.Point(151, 228);
            this.picUpdateConfirmPassword.Name = "picUpdateConfirmPassword";
            this.picUpdateConfirmPassword.Size = new System.Drawing.Size(24, 24);
            this.picUpdateConfirmPassword.TabIndex = 30;
            this.picUpdateConfirmPassword.TabStop = false;
            // 
            // txtUpdateConfirmPassword
            // 
            this.txtUpdateConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateConfirmPassword.Location = new System.Drawing.Point(181, 228);
            this.txtUpdateConfirmPassword.Name = "txtUpdateConfirmPassword";
            this.txtUpdateConfirmPassword.PasswordChar = '*';
            this.txtUpdateConfirmPassword.Size = new System.Drawing.Size(307, 26);
            this.txtUpdateConfirmPassword.TabIndex = 29;
            this.txtUpdateConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateConfirmPassword_Validating);
            // 
            // lblUpdateConfirmPassword
            // 
            this.lblUpdateConfirmPassword.AutoSize = true;
            this.lblUpdateConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateConfirmPassword.Location = new System.Drawing.Point(6, 233);
            this.lblUpdateConfirmPassword.Name = "lblUpdateConfirmPassword";
            this.lblUpdateConfirmPassword.Size = new System.Drawing.Size(141, 20);
            this.lblUpdateConfirmPassword.TabIndex = 28;
            this.lblUpdateConfirmPassword.Text = "Confirm Password:";
            // 
            // picUpdateNewPassword
            // 
            this.picUpdateNewPassword.Image = global::LibraryManagment.Properties.Resources.padlock__1_;
            this.picUpdateNewPassword.Location = new System.Drawing.Point(151, 150);
            this.picUpdateNewPassword.Name = "picUpdateNewPassword";
            this.picUpdateNewPassword.Size = new System.Drawing.Size(24, 24);
            this.picUpdateNewPassword.TabIndex = 27;
            this.picUpdateNewPassword.TabStop = false;
            // 
            // txtUpdateNewPassword
            // 
            this.txtUpdateNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateNewPassword.Location = new System.Drawing.Point(181, 150);
            this.txtUpdateNewPassword.Name = "txtUpdateNewPassword";
            this.txtUpdateNewPassword.PasswordChar = '*';
            this.txtUpdateNewPassword.Size = new System.Drawing.Size(307, 26);
            this.txtUpdateNewPassword.TabIndex = 26;
            this.txtUpdateNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateNewPassword_Validating);
            // 
            // lblUpdateNewPassword
            // 
            this.lblUpdateNewPassword.AutoSize = true;
            this.lblUpdateNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateNewPassword.Location = new System.Drawing.Point(6, 156);
            this.lblUpdateNewPassword.Name = "lblUpdateNewPassword";
            this.lblUpdateNewPassword.Size = new System.Drawing.Size(82, 20);
            this.lblUpdateNewPassword.TabIndex = 25;
            this.lblUpdateNewPassword.Text = "Password:";
            // 
            // picUpdateCurrentPassword
            // 
            this.picUpdateCurrentPassword.Image = global::LibraryManagment.Properties.Resources.padlock__1_;
            this.picUpdateCurrentPassword.Location = new System.Drawing.Point(151, 83);
            this.picUpdateCurrentPassword.Name = "picUpdateCurrentPassword";
            this.picUpdateCurrentPassword.Size = new System.Drawing.Size(24, 24);
            this.picUpdateCurrentPassword.TabIndex = 24;
            this.picUpdateCurrentPassword.TabStop = false;
            this.picUpdateCurrentPassword.Visible = false;
            // 
            // txtUpdateCurrentPassword
            // 
            this.txtUpdateCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCurrentPassword.Location = new System.Drawing.Point(181, 83);
            this.txtUpdateCurrentPassword.Name = "txtUpdateCurrentPassword";
            this.txtUpdateCurrentPassword.PasswordChar = '*';
            this.txtUpdateCurrentPassword.Size = new System.Drawing.Size(307, 26);
            this.txtUpdateCurrentPassword.TabIndex = 23;
            this.txtUpdateCurrentPassword.Visible = false;
            this.txtUpdateCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdateCurrentPassword_Validating);
            // 
            // lblUpdateCurrentPassword
            // 
            this.lblUpdateCurrentPassword.AutoSize = true;
            this.lblUpdateCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCurrentPassword.Location = new System.Drawing.Point(6, 86);
            this.lblUpdateCurrentPassword.Name = "lblUpdateCurrentPassword";
            this.lblUpdateCurrentPassword.Size = new System.Drawing.Size(139, 20);
            this.lblUpdateCurrentPassword.TabIndex = 22;
            this.lblUpdateCurrentPassword.Text = "Current Password:";
            this.lblUpdateCurrentPassword.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAdminIDValue
            // 
            this.lblAdminIDValue.AutoSize = true;
            this.lblAdminIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminIDValue.Location = new System.Drawing.Point(136, 122);
            this.lblAdminIDValue.Name = "lblAdminIDValue";
            this.lblAdminIDValue.Size = new System.Drawing.Size(36, 20);
            this.lblAdminIDValue.TabIndex = 31;
            this.lblAdminIDValue.Text = "???";
            // 
            // frmAddUpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.lblAdminIDValue);
            this.Controls.Add(this.grbUpdateMode);
            this.Controls.Add(this.grbAddMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddUpdateAdmin";
            this.Text = "frmAddUpdateAdmin";
            this.Load += new System.EventHandler(this.frmAddUpdateAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbAddMode.ResumeLayout(false);
            this.grbAddMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPassword)).EndInit();
            this.grbUpdateMode.ResumeLayout(false);
            this.grbUpdateMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbAddMode;
        private System.Windows.Forms.PictureBox picAddConfirmPassword;
        private System.Windows.Forms.TextBox txtAddConfirmPassword;
        private System.Windows.Forms.Label lblAddConfirmPassword;
        private System.Windows.Forms.PictureBox picAddPassword;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.GroupBox grbUpdateMode;
        private System.Windows.Forms.CheckBox checkResetPassword;
        private System.Windows.Forms.PictureBox picUpdateConfirmPassword;
        private System.Windows.Forms.TextBox txtUpdateConfirmPassword;
        private System.Windows.Forms.Label lblUpdateConfirmPassword;
        private System.Windows.Forms.PictureBox picUpdateNewPassword;
        private System.Windows.Forms.TextBox txtUpdateNewPassword;
        private System.Windows.Forms.Label lblUpdateNewPassword;
        private System.Windows.Forms.PictureBox picUpdateCurrentPassword;
        private System.Windows.Forms.TextBox txtUpdateCurrentPassword;
        private System.Windows.Forms.Label lblUpdateCurrentPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAdminIDValue;
    }
}