using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
    public partial class frmLogin : Form
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
        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            pictureBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 30, 30));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 25, 25));
            btnSignUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp.Width, btnSignUp.Height, 25, 25));
            btnExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 25, 25));
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmAuth frmAuth = new frmAuth();
            frmAuth.Show();
            this.Hide();
        }
    }
}
