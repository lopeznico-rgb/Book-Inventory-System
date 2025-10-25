namespace LibraryManagementSystem
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            panel1 = new Panel();
            btnClean = new Button();
            btnvi = new Button();
            btnNovi = new Button();
            btnBack = new Button();
            btnExit = new Button();
            btnSubmit = new Button();
            cmbRole = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnClean);
            panel1.Controls.Add(btnvi);
            panel1.Controls.Add(btnNovi);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 510);
            panel1.TabIndex = 0;
            // 
            // btnClean
            // 
            btnClean.BackgroundImage = (Image)resources.GetObject("btnClean.BackgroundImage");
            btnClean.BackgroundImageLayout = ImageLayout.Stretch;
            btnClean.Location = new Point(277, 374);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(19, 20);
            btnClean.TabIndex = 28;
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnvi
            // 
            btnvi.BackgroundImage = (Image)resources.GetObject("btnvi.BackgroundImage");
            btnvi.BackgroundImageLayout = ImageLayout.Stretch;
            btnvi.Location = new Point(278, 282);
            btnvi.Name = "btnvi";
            btnvi.Size = new Size(19, 20);
            btnvi.TabIndex = 27;
            btnvi.UseVisualStyleBackColor = true;
            btnvi.Click += btnvi_Click;
            // 
            // btnNovi
            // 
            btnNovi.BackgroundImage = (Image)resources.GetObject("btnNovi.BackgroundImage");
            btnNovi.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovi.Location = new Point(278, 282);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(18, 20);
            btnNovi.TabIndex = 26;
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // btnBack
            // 
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(3, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.TabIndex = 25;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.ForestGreen;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(38, 448);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(262, 40);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGreen;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(38, 402);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(262, 40);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "student" });
            cmbRole.Location = new Point(38, 338);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(262, 28);
            cmbRole.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 313);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 9;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 254);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(38, 279);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 26);
            txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 195);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(38, 220);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 26);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(38, 161);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 26);
            txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 99);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(355, 534);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignUp";
            Load += frmSignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private ComboBox cmbRole;
        private Label label5;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Button btnExit;
        private Button btnBack;
        private Button btnNovi;
        private Button btnvi;
        private Button btnClean;
    }
}