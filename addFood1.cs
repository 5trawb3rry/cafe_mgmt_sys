using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbproject
{
    public partial class addFood1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waqas laptops\\Documents\\cms.mdf\";Integrated Security=True;Connect Timeout=30");
        public addFood1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(addFoodName.Text) ||
                string.IsNullOrWhiteSpace(addFoodDesc.Text) ||
                string.IsNullOrWhiteSpace(addFoodCategory.Text) ||
                addFoodQuantity.Value == 0 ||
                addFoodPrice1.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("All fields must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO MenuItems (Name, Description, Price, Category, Quantity) " +
                                       "VALUES (@Name, @Description, @Price, @Category, @Quantity)";

                        using (SqlCommand sqlcmd = new SqlCommand(query, connection))
                        {
                            sqlcmd.Parameters.AddWithValue("@Name", addFoodName.Text);
                            sqlcmd.Parameters.AddWithValue("@Description", addFoodDesc.Text);
                            sqlcmd.Parameters.AddWithValue("@Price", addFoodPrice1.Value);
                            sqlcmd.Parameters.AddWithValue("@Category", addFoodCategory.Text);
                            sqlcmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(addFoodQuantity.Value));

                            int rowsAffected = sqlcmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add food item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void clearFields()
        {
            addFoodName.Text = "";
            addFoodDesc.Text = "";
            addFoodCategory.Text = "";

        }

        private void goToAdmin_Click(object sender, EventArgs e)
        {
            AdminTools at = new AdminTools();
            at.Show();
            this.Hide();
        }

        private void addFood1_Load(object sender, EventArgs e)
        {

        }
    }
}
