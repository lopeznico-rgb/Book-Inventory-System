using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmSignUp : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nButtomRect,
           int nWidthEllipse,
           int nHeightEllipse

           );
        public frmSignUp()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 25, 25));
            btnExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 25, 25));
            btnBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 25, 25));
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin Back = new frmLogin();
            Back.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnvi.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnvi_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnNovi.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            txtUserName.Focus();
        }
    }
}
