using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;








namespace Books_inventory_monitoring_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 🔒 Disable editing and adding in DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "BookName", "Genre", "Authors", "Publishers", "BookDate", "Quantity" });
            comboBox1.SelectedIndex = 0;
            LoadBookData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookIms;Integrated Security=True"))
            {
                con.Open();

                // 🧩 1️⃣ Check if the book already exists
                string checkQuery = @"SELECT Quantity FROM Booktab 
                              WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());

                    object result = checkCmd.ExecuteScalar();

                    if (result != null) // Book already exists
                    {
                        int existingQuantity = Convert.ToInt32(result);

                        DialogResult addMore = MessageBox.Show(
                            "Book is already here. Do you want to add another one?",
                            "Duplicate Book Found",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (addMore == DialogResult.Yes)
                        {
                            // ✅ 2️⃣ Add the new quantity to the existing one
                            int addQty;
                            if (!int.TryParse(textBox7.Text, out addQty))
                            {
                                MessageBox.Show("Invalid quantity entered. Please input a valid number.", "Error");
                                return;
                            }

                            int newQuantity = existingQuantity + addQty;

                            string updateQtyQuery = @"UPDATE Booktab 
                                              SET Quantity=@Quantity 
                                              WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                            using (SqlCommand updateCmd = new SqlCommand(updateQtyQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", newQuantity);
                                updateCmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());
                                updateCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Quantity updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // ❌ If user clicks No, clear the textboxes
                            ClearTextBoxes();
                            return;
                        }

                        // Refresh grid and clear fields
                        LoadBookData();
                        ClearTextBoxes();
                        return;
                    }
                }

                // 🧩 3️⃣ If book does NOT exist, insert new record
                SqlCommand cnn = new SqlCommand(
                    "INSERT INTO Booktab (BookName, Genre, Authors, Publishers, BookDate, Quantity) " +
                    "VALUES (@BookName, @Genre, @Authors, @Publishers, @BookDate, @Quantity)", con);

                cnn.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                cnn.Parameters.AddWithValue("@Genre", textBox6.Text.Trim());
                cnn.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                cnn.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());

                // 🧩 Validate BookDate
                if (!DateTime.TryParse(textBox5.Text, out DateTime bookDate))
                {
                    MessageBox.Show("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
                    return;
                }
                cnn.Parameters.AddWithValue("@BookDate", bookDate);

                // 🧩 Validate Quantity
                if (!int.TryParse(textBox7.Text, out int qty))
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }
                cnn.Parameters.AddWithValue("@Quantity", qty);

                cnn.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
                LoadBookData();
            }
        }



        private void SearchBookData()
        {
            using (SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookIms;Integrated Security=True"))
            {
                con.Open();

                string filterColumn = comboBox1.Text;
                string searchValue = textBox4.Text.Trim();

                if (string.IsNullOrEmpty(searchValue))
                {
                    LoadBookData();
                    return;
                }

                string query = $"SELECT * FROM Booktab WHERE {filterColumn} LIKE @SearchValue";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadBookData()
        {
            using (SqlConnection con = new SqlConnection(
             @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookIms;Integrated Security=True"))
            {
                con.Open();

                SqlCommand cnn = new SqlCommand("Select * From Booktab", con);

                SqlDataAdapter da = new SqlDataAdapter(cnn);

                DataTable table = new DataTable();

                da.Fill(table);

                dataGridView1.DataSource = table;



            }
        }
        // 🔹 CLEAR ALL TEXTBOXES AFTER UPDATE/DELETE
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox4.Clear();
            textBox7.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookIms;Integrated Security=True"))
            {
                con.Open();

                string query = @"UPDATE Booktab
                SET Genre=@Genre, Authors=@Authors, Publishers=@Publishers, BookDate=@BookDate, Quantity=@Quantity
                WHERE BookName=@BookName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Genre", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Authors", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Publishers", textBox3.Text);
                    cmd.Parameters.AddWithValue("@BookDate", DateTime.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox7.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Book Updated Successfully!");
                    else
                        MessageBox.Show("No matching book found to update.");
                }

                ClearTextBoxes();
                LoadBookData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 🔒 Basic validation
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookIms;Integrated Security=True"))
            {
                con.Open();

                // 🧩 1️⃣ Get the existing quantity for the selected book
                string checkQuery = @"SELECT Quantity FROM Booktab 
                              WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                int currentQty = 0;
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());

                    object result = checkCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("No matching book found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    currentQty = Convert.ToInt32(result);
                }

                // 🧩 2️⃣ Check if quantity is greater than 1
                if (currentQty > 1)
                {
                    DialogResult deleteByQty = MessageBox.Show(
                        "This book has multiple copies. Do you want to delete the quantity entered in the textbox?",
                        "Delete By Quantity",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (deleteByQty == DialogResult.Yes)
                    {
                        // Parse the user-entered quantity
                        if (!int.TryParse(textBox7.Text, out int deleteQty) || deleteQty <= 0)
                        {
                            MessageBox.Show("Please enter a valid quantity to delete.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int newQty = currentQty - deleteQty;

                        if (newQty < 0)
                        {
                            MessageBox.Show("There are not enough books to delete that amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (newQty == 0)
                        {
                            // ✅ Delete the entire record if 0 left
                            string deleteQuery = @"DELETE FROM Booktab 
                                           WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                            using (SqlCommand delCmd = new SqlCommand(deleteQuery, con))
                            {
                                delCmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                                delCmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                                delCmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());
                                delCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("All copies deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // ✅ Update the new reduced quantity
                            string updateQuery = @"UPDATE Booktab 
                                           SET Quantity=@Quantity 
                                           WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", newQty);
                                updateCmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());
                                updateCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show($"Quantity updated successfully! Remaining: {newQty}", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadBookData();
                        ClearTextBoxes();
                        return;
                    }
                    else
                    {
                        // ❌ If user cancels
                        ClearTextBoxes();
                        return;
                    }
                }

                // 🧩 3️⃣ If only 1 quantity, delete directly
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this book?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string query = @"DELETE FROM Booktab 
                             WHERE BookName=@BookName AND Authors=@Authors AND Publishers=@Publishers";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Authors", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Publishers", textBox3.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookData();
                    ClearTextBoxes();
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchBookData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["BookName"].Value.ToString();
                textBox6.Text = row.Cells["Genre"].Value.ToString();
                textBox2.Text = row.Cells["Authors"].Value.ToString();
                textBox3.Text = row.Cells["Publishers"].Value.ToString();
                textBox5.Text = row.Cells["BookDate"].Value.ToString();
                textBox7.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}