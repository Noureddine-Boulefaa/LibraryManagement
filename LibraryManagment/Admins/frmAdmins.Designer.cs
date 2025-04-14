namespace LibraryManagment.Admins
{
    partial class frmAdmins
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
            this.ManageAdmins = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowAdminInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.picAdmins = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageAdmins
            // 
            this.ManageAdmins.AutoSize = true;
            this.ManageAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAdmins.Location = new System.Drawing.Point(350, 25);
            this.ManageAdmins.Name = "ManageAdmins";
            this.ManageAdmins.Size = new System.Drawing.Size(262, 37);
            this.ManageAdmins.TabIndex = 0;
            this.ManageAdmins.Text = "Manage Admins";
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAdmins.Location = new System.Drawing.Point(12, 273);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(960, 317);
            this.dgvAdmins.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAdminInfo,
            this.AddNewAdmin,
            this.UpdateAdmin,
            this.DeleteAdmin});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // ShowAdminInfo
            // 
            this.ShowAdminInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowAdminInfo.Image = global::LibraryManagment.Properties.Resources.show;
            this.ShowAdminInfo.Name = "ShowAdminInfo";
            this.ShowAdminInfo.Size = new System.Drawing.Size(166, 22);
            this.ShowAdminInfo.Text = "Show Admin Info";
            // 
            // AddNewAdmin
            // 
            this.AddNewAdmin.Image = global::LibraryManagment.Properties.Resources.add;
            this.AddNewAdmin.Name = "AddNewAdmin";
            this.AddNewAdmin.Size = new System.Drawing.Size(180, 22);
            this.AddNewAdmin.Text = "Add New Admin";
            this.AddNewAdmin.Click += new System.EventHandler(this.AddNewAdmin_Click);
            // 
            // UpdateAdmin
            // 
            this.UpdateAdmin.Image = global::LibraryManagment.Properties.Resources.refresh;
            this.UpdateAdmin.Name = "UpdateAdmin";
            this.UpdateAdmin.Size = new System.Drawing.Size(180, 22);
            this.UpdateAdmin.Text = "Update Admin";
            this.UpdateAdmin.Click += new System.EventHandler(this.UpdateAdmin_Click);
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.Image = global::LibraryManagment.Properties.Resources.delete;
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(166, 22);
            this.DeleteAdmin.Text = "Delete Admin";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(829, 212);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(143, 50);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New Admin";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(12, 239);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(85, 20);
            this.lblFilterBy.TabIndex = 3;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "AdminID",
            "Name",
            "Username"});
            this.cmbFilterBy.Location = new System.Drawing.Point(103, 236);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(169, 28);
            this.cmbFilterBy.TabIndex = 4;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(278, 236);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(243, 26);
            this.txtFilterValue.TabIndex = 5;
            // 
            // picAdmins
            // 
            this.picAdmins.Image = global::LibraryManagment.Properties.Resources.Admins;
            this.picAdmins.Location = new System.Drawing.Point(411, 77);
            this.picAdmins.Name = "picAdmins";
            this.picAdmins.Size = new System.Drawing.Size(128, 128);
            this.picAdmins.TabIndex = 6;
            this.picAdmins.TabStop = false;
            // 
            // frmAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.picAdmins);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvAdmins);
            this.Controls.Add(this.ManageAdmins);
            this.Name = "frmAdmins";
            this.Text = "frmAdmins";
            this.Load += new System.EventHandler(this.frmAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageAdmins;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.PictureBox picAdmins;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddNewAdmin;
        private System.Windows.Forms.ToolStripMenuItem ShowAdminInfo;
        private System.Windows.Forms.ToolStripMenuItem UpdateAdmin;
        private System.Windows.Forms.ToolStripMenuItem DeleteAdmin;
    }
}