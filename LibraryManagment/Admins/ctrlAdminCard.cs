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

namespace LibraryManagment.Admins
{
    public partial class ctrlAdminCard : UserControl
    {
        private clsAdmin _Admin;
        private int? _AdminID = null;
        public int? AdminID
        {
            get { return _AdminID; }
        }

        public ctrlAdminCard()
        {
            InitializeComponent();
        }

        public void LoadAdminInfo(int AdminID)
        {
            _Admin = clsAdmin.FindByAdminID(AdminID);
            if(_Admin == null)
            {
                _ResetAdminInfo();
                MessageBox.Show("No Admin with AdminID = " + AdminID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillAdminInfo();
        }

        private void _FillAdminInfo()
        {
            lblAdminIDValue.Text = _Admin.AdminID.ToString();
            lblNameValue.Text = _Admin.Name;
            lblUsernameValue.Text = _Admin.Username;
            lblRoleValue.Text = _Admin.Role;
        }
        private void _ResetAdminInfo()
        {
            lblAdminIDValue.Text = "???";
            lblNameValue.Text = "???";
            lblUsernameValue.Text = "???";
            lblRoleValue.Text = "???";
        }
    }
}
