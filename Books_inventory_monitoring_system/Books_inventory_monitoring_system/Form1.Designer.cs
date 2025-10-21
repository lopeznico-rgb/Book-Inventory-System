namespace Books_inventory_monitoring_system
{
    partial class Form1
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
            button1 = new Button();
            panel1 = new Panel();
            textBox7 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 630);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 394);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(160, 322);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(302, 27);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 329);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Quantity: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(160, 95);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(302, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 102);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Genre:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(160, 267);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(302, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 274);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 218);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Publishers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 160);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Authors:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Book_Name: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(608, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 687);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(245, 630);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(412, 630);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(283, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(281, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(24, 118);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1582, 853);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Book Inventory Monitoring System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private Label label6;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Button button4;
        private TextBox textBox7;
        private Label label4;
    }
}
