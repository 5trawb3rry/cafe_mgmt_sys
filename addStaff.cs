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
    public partial class addStaff : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waqas laptops\\Documents\\cms.mdf\";Integrated Security=True;Connect Timeout=30");
        public addStaff()
        {
            InitializeComponent();
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }

        public bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(addStaffName.Text) ||
                string.IsNullOrWhiteSpace(addStaffRole.Text) ||
                addShift.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void add_Click(object sender, EventArgs e)
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
                        string insertion = "INSERT INTO Staff(Name, Role, Shifthour) VALUES (@name, @role, @shiftHours)";

                        using (SqlCommand sqlcmd = new SqlCommand(insertion, connection))
                        {
                            sqlcmd.Parameters.AddWithValue("@name", addStaffName.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@role", addStaffRole.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@shiftHours", (int)addShift.Value);

                            sqlcmd.ExecuteNonQuery();
                            MessageBox.Show("Staff added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void goToAdmin_Click(object sender, EventArgs e)
        {
            AdminTools adt = new AdminTools();
            adt.Show();
            this.Hide();
        }
    }
}
