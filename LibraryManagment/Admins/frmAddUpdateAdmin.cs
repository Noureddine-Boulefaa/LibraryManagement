using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment_business;

namespace LibraryManagment.Admins
{
    public partial class frmAddUpdateAdmin : Form
    {
        enum enMode {enAddNewAdmin = 0,enUpdateAdmin = 1};

        private enMode _Mode = enMode.enAddNewAdmin;
        private int? _AdminID = null;
        private clsAdmin _admin;
        public frmAddUpdateAdmin()
        {
            InitializeComponent();
            _admin = new clsAdmin();
            _ResetDefualtValues();
        }
        public frmAddUpdateAdmin(int AdminID)
        {
            InitializeComponent();
            _Mode = enMode.enUpdateAdmin;
            _AdminID = AdminID; ;

        }
        private void _ResetDefualtValues()
        {
            if(_Mode == enMode.enAddNewAdmin)
            {
                lblTitle.Text = "Add New Admin";
                lblAdminIDValue.Text = "???";
                txtName.Text = "";
                txtUsername.Text = "";
                txtRole.Text = "";
                txtAddPassword.Text = "";
                txtAddConfirmPassword.Text = "";
                grbUpdateMode.Visible = false;
                
            }
            else
            {
                lblTitle.Text = "Update Admin";
                grbUpdateMode.Visible = true;
                grbAddMode.Visible = false;
                grbUpdateMode.Location = new Point(469, 96);
                _LoadData();
            }
        }

        private void _LoadData()
        {
            _admin = clsAdmin.FindByAdminID(_AdminID);
            if(_admin == null)
            {
                MessageBox.Show("No Admin With ID " + _AdminID, "Admin Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lblAdminIDValue.Text = _admin.AdminID.ToString();
            txtName.Text = _admin.Name;
            txtUsername.Text = _admin.Username;
            txtRole.Text = _admin.Role;
        }

        

        

        private void frmAddUpdateAdmin_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
        }

        private void checkResetPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkResetPassword.Checked != true)
            {
                lblUpdateCurrentPassword.Visible = false;
                lblUpdateNewPassword.Text = "Password";
                picUpdateCurrentPassword.Visible = false;
                txtUpdateCurrentPassword.Visible = false;
            }
            else
            {
                lblUpdateCurrentPassword.Visible = true;
                lblUpdateNewPassword.Text = "New Password";
                picUpdateCurrentPassword.Visible = true;
                txtUpdateCurrentPassword.Visible = true;
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if(string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void txtAddPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddPassword, "Add Password");
            }
            else
            {   e.Cancel = false;
                errorProvider1.SetError(txtAddPassword, null);
            }
        }

        private void txtAddConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddConfirmPassword, "Please Add Password First");
            }
            else if (string.IsNullOrEmpty(txtAddConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddConfirmPassword, "Please Confirm Password");
            }
            else if (txtAddConfirmPassword.Text.Trim() != txtAddPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddConfirmPassword, "The password and confirm password do not match");
            }
            else
            {
                errorProvider1.SetError(txtAddConfirmPassword,null);
                e.Cancel = false;
            }


        }

        private void txtUpdateCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUpdateCurrentPassword, "Please Enter The Current Password");
            }
            else if (txtUpdateCurrentPassword.Text.Trim() != _admin.PasswordHash)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUpdateCurrentPassword, "Please Enter The Current Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUpdateCurrentPassword,null);
                
            }


        }

        private void txtUpdateNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(checkResetPassword.Checked)
            {
                if (string.IsNullOrEmpty(txtUpdateNewPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUpdateNewPassword, "Please Enter The New Password");
                }
                else if(txtUpdateNewPassword.Text.Trim() == txtUpdateCurrentPassword.Text.Trim())
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUpdateNewPassword, "Please Enter An Other Password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUpdateNewPassword, null);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtUpdateNewPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUpdateNewPassword, "Add Your Password");
                }
                else if(txtUpdateNewPassword.Text.Trim() != _admin.PasswordHash)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUpdateNewPassword, "please enter Your Password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUpdateNewPassword, null);
                }
            }
            
        }

        private void txtUpdateConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddPassword, "Please Confirm Your Password");
            }
            else if (txtUpdateConfirmPassword.Text.Trim() != txtUpdateNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUpdateConfirmPassword, "Please Confirm Your Password");
            }
            else
            {   e.Cancel = false;
                errorProvider1.SetError(txtUpdateConfirmPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!_ValidateForm())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _admin.Name = txtName.Text;
            _admin.Username = txtUsername.Text;
            _admin.Role = txtRole.Text;
            _admin.PasswordHash = txtUpdateConfirmPassword.Text;
            if(_admin.Save())
            {
                lblAdminIDValue.Text = _admin.AdminID.ToString();
                txtName.Text = _admin.Name;
                txtUsername.Text = _admin.Username;
                txtRole.Text = _admin.Role;
                _Mode = enMode.enUpdateAdmin;
                lblTitle.Text = "Update Admin";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool _ValidateForm()
        {
            bool isValid = true;
            errorProvider1.Clear(); // مسح الأخطاء السابقة

            // الاسم
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name is required.");
                isValid = false;
            }

            // اسم المستخدم
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Username is required.");
                isValid = false;
            }

            // الدور
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                errorProvider1.SetError(txtRole, "Role is required.");
                isValid = false;
            }

            if (_Mode == enMode.enAddNewAdmin)
            {
                // كلمة المرور
                if (string.IsNullOrWhiteSpace(txtAddPassword.Text))
                {
                    errorProvider1.SetError(txtAddPassword, "Password is required.");
                    isValid = false;
                }

                // تأكيد كلمة المرور
                if (string.IsNullOrWhiteSpace(txtAddConfirmPassword.Text))
                {
                    errorProvider1.SetError(txtAddConfirmPassword, "Confirm your password.");
                    isValid = false;
                }
                else if (txtAddConfirmPassword.Text != txtAddPassword.Text)
                {
                    errorProvider1.SetError(txtAddConfirmPassword, "Passwords do not match.");
                    isValid = false;
                }
            }
            else if (_Mode == enMode.enUpdateAdmin)
            {
                // تحقق من كلمة المرور الحالية فقط إذا طلب إعادة التعيين
                if (checkResetPassword.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtUpdateCurrentPassword.Text))
                    {
                        errorProvider1.SetError(txtUpdateCurrentPassword, "Enter your current password.");
                        isValid = false;
                    }
                    else if (txtUpdateCurrentPassword.Text != _admin.PasswordHash)
                    {
                        errorProvider1.SetError(txtUpdateCurrentPassword, "Current password is incorrect.");
                        isValid = false;
                    }

                    // تحقق كلمة المرور الجديدة
                    if (string.IsNullOrWhiteSpace(txtUpdateNewPassword.Text))
                    {
                        errorProvider1.SetError(txtUpdateNewPassword, "New password is required.");
                        isValid = false;
                    }
                    else if (txtUpdateNewPassword.Text == txtUpdateCurrentPassword.Text)
                    {
                        errorProvider1.SetError(txtUpdateNewPassword, "New password must be different.");
                        isValid = false;
                    }

                    if (string.IsNullOrWhiteSpace(txtUpdateConfirmPassword.Text))
                    {
                        errorProvider1.SetError(txtUpdateConfirmPassword, "Please confirm the new password.");
                        isValid = false;
                    }
                    else if (txtUpdateConfirmPassword.Text != txtUpdateNewPassword.Text)
                    {
                        errorProvider1.SetError(txtUpdateConfirmPassword, "New passwords do not match.");
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

    }
}
