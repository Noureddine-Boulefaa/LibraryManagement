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
    public partial class frmAdmins : Form
    {
        private static DataTable _dtAllAdmins;
        public frmAdmins()
        {
            InitializeComponent();
        }

        private void frmAdmins_Load(object sender, EventArgs e)
        {
            _dtAllAdmins = clsAdmin.GetAllAdmins();
            dgvAdmins.DataSource = _dtAllAdmins;
            cmbFilterBy.SelectedIndex = 0;

            dgvAdmins.Columns[0].HeaderText = "Admin ID";
            dgvAdmins.Columns[0].Width = 240;

            dgvAdmins.Columns[1].HeaderText = "Name";
            dgvAdmins.Columns[1].Width = 240;


            dgvAdmins.Columns[2].HeaderText = "Username";
            dgvAdmins.Columns[2].Width = 240;

            dgvAdmins.Columns[3].HeaderText = "Role";
            dgvAdmins.Columns[3].Width = 240;
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text != "None")
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
            else
                txtFilterValue.Visible=false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateAdmin frm = new frmAddUpdateAdmin();
            frm.ShowDialog();
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            frmAddUpdateAdmin frm = new frmAddUpdateAdmin();
            frm.ShowDialog();
        }

        private void UpdateAdmin_Click(object sender, EventArgs e)
        {
            
            frmAddUpdateAdmin frm = new frmAddUpdateAdmin((int)dgvAdmins.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
