using LibraryManagment.Global_Classes;
using LibraryManagment_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Silver);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";
            if(clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                txtUserName.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsAdmin Admin = clsAdmin.FindByUsernameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());

            if(Admin != null)
            {
                if(chkRememberMe.Checked == true)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                clsGlobal.CurrentAdmin = Admin;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
