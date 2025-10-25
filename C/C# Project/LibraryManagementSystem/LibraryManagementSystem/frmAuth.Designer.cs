namespace LibraryManagementSystem
{
    partial class frmAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuth));
            panel1 = new Panel();
            btnBack = new Button();
            btnCancel = new Button();
            btnSubmit = new Button();
            btnClean = new Button();
            btnvi = new Button();
            btnNovi = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnClean);
            panel1.Controls.Add(btnvi);
            panel1.Controls.Add(btnNovi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 579);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(8, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.TabIndex = 24;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.ForestGreen;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(91, 422);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(262, 40);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGreen;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(91, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(262, 40);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClean
            // 
            btnClean.BackgroundImage = (Image)resources.GetObject("btnClean.BackgroundImage");
            btnClean.BackgroundImageLayout = ImageLayout.Stretch;
            btnClean.Location = new Point(329, 326);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(19, 20);
            btnClean.TabIndex = 21;
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnvi
            // 
            btnvi.BackgroundImage = (Image)resources.GetObject("btnvi.BackgroundImage");
            btnvi.BackgroundImageLayout = ImageLayout.Stretch;
            btnvi.Location = new Point(329, 294);
            btnvi.Name = "btnvi";
            btnvi.Size = new Size(19, 20);
            btnvi.TabIndex = 20;
            btnvi.UseVisualStyleBackColor = true;
            btnvi.Click += btnvi_Click;
            // 
            // btnNovi
            // 
            btnNovi.BackgroundImage = (Image)resources.GetObject("btnNovi.BackgroundImage");
            btnNovi.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovi.Location = new Point(330, 294);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(18, 20);
            btnNovi.TabIndex = 19;
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 266);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 212);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 17;
            label3.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(89, 291);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 26);
            txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(91, 237);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 26);
            txtUserName.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmAuth
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(469, 603);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAuth";
            Load += frmAuth_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnClean;
        private Button btnvi;
        private Button btnNovi;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnCancel;
        private Button btnSubmit;
        private Button btnBack;
    }
}