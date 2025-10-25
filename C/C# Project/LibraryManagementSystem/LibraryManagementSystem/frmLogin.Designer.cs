namespace LibraryManagementSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            btnExit = new Button();
            label5 = new Label();
            btnNovi = new Button();
            panel1 = new Panel();
            btnClean = new Button();
            btnvi = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(103, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 44);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 148);
            label2.Name = "label2";
            label2.Size = new Size(262, 22);
            label2.TabIndex = 2;
            label2.Text = "Library Management System";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(27, 219);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 26);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(27, 273);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 26);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 194);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 248);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(27, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.ForestGreen;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(27, 388);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(262, 40);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LimeGreen;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(27, 434);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(262, 40);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.139131F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 503);
            label5.Name = "label5";
            label5.Size = new Size(203, 16);
            label5.TabIndex = 10;
            label5.Text = "Library Management System";
            // 
            // btnNovi
            // 
            btnNovi.BackgroundImage = (Image)resources.GetObject("btnNovi.BackgroundImage");
            btnNovi.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovi.Location = new Point(269, 276);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(18, 20);
            btnNovi.TabIndex = 11;
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnClean);
            panel1.Controls.Add(btnvi);
            panel1.Controls.Add(btnNovi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(395, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 540);
            panel1.TabIndex = 0;
            // 
            // btnClean
            // 
            btnClean.BackgroundImage = (Image)resources.GetObject("btnClean.BackgroundImage");
            btnClean.BackgroundImageLayout = ImageLayout.Stretch;
            btnClean.Location = new Point(268, 311);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(19, 20);
            btnClean.TabIndex = 14;
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnvi
            // 
            btnvi.BackgroundImage = (Image)resources.GetObject("btnvi.BackgroundImage");
            btnvi.BackgroundImageLayout = ImageLayout.Stretch;
            btnvi.Location = new Point(268, 276);
            btnvi.Name = "btnvi";
            btnvi.Size = new Size(19, 20);
            btnvi.TabIndex = 12;
            btnvi.UseVisualStyleBackColor = true;
            btnvi.Click += btnvi_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 540);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(330, 369);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(16, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 130);
            panel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 56);
            label6.Name = "label6";
            label6.Size = new Size(309, 20);
            label6.TabIndex = 0;
            label6.Text = "\"Gateway to Knowledge and Wisdom\"";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(722, 564);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Button btnLogin;
        private Button btnSignUp;
        private Button btnExit;
        private Label label5;
        private Button btnNovi;
        private Panel panel1;
        private Button btnvi;
        private Button btnClean;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox2;
    }
}
