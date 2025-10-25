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
    public partial class frmAuth : Form
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
        public frmAuth()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 90, 90));
            btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 25, 25));
            btnCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 25, 25));
        }

        private void btnvi_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnNovi.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnvi.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmAuth_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Auth" && txtPassword.Text == "auth123")
            {
                frmSignUp frmSignUp = new frmSignUp();
                frmSignUp.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or Password you Entered is Incorrect, Try Again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin Back = new frmLogin();
            Back.Show();
        }
    }
}
