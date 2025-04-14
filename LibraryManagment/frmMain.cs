using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LibraryManagment.Admins;

namespace LibraryManagment
{
    public partial class frmMain : Form
    {
        private string backgroundColorString;
        private string textColorString;
        private string buttonColorString;


        private Color backgroundColor;
        private Color textColor;
        private Color buttonColor;
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
            backgroundColorString = ConfigurationManager.AppSettings["BackgroundColor"];
            textColorString = ConfigurationManager.AppSettings["TextColor"];
            buttonColorString = ConfigurationManager.AppSettings["ButtonColor"];

            
            backgroundColor = ColorTranslator.FromHtml(backgroundColorString);
            buttonColor = ColorTranslator.FromHtml(buttonColorString);
            
            this.BackColor = backgroundColor;
            this.ForeColor = textColor;
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmins frm = new frmAdmins();
            frm.ShowDialog();
        }
    }
}
