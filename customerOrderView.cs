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
    public partial class customerOrderView : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waqas laptops\\Documents\\cms.mdf\";Integrated Security=True;Connect Timeout=30");
        public customerOrderView()
        {
            InitializeComponent();
            DisplayMenuItems();
            DisplayCart();
            DisplayPrice();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMenuItems()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM CustomerMenuView1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    customerMenuView.DataSource = dt;
                    connection.Close();

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


        private void addToCart_Click(object sender, EventArgs e)
        {
            int selectedItemID = (int)itemChosen.Value;
            if (selectedItemID <= 0)
            {
                MessageBox.Show("Please select a valid item.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = CalculateTotalPrice(selectedItemID);
            string paymentMethod = getPayment.Text;
            int customerID = (int)getCustomerID.Value;

            try
            {
                connection.Open();
                string insertOrderQuery = "INSERT INTO Orders (CustomerID, Date, TotalPrice, Payment) VALUES (@CustomerID, @Date, @TotalPrice, @PaymentMethod); SELECT SCOPE_IDENTITY();";
                SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection);
                orderCommand.Parameters.AddWithValue("@CustomerID", customerID);
                orderCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                orderCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                orderCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                // Retrieve the OrderID
                int orderID = Convert.ToInt32(orderCommand.ExecuteScalar());

                // Retrieve payment amount from the textbox
                decimal paymentAmount = 100;

                // Insert into Payments table
                string insertPaymentQuery = "INSERT INTO Payments (OrderID, Amount, PaymentMethod, Date) VALUES (@OrderID, @Amount, @PaymentMethod, @Date)";
                SqlCommand paymentCommand = new SqlCommand(insertPaymentQuery, connection);
                paymentCommand.Parameters.AddWithValue("@OrderID", orderID);
                paymentCommand.Parameters.AddWithValue("@Amount", paymentAmount);
                paymentCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                paymentCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                paymentCommand.ExecuteNonQuery();

                string itemName = "";

                // Insert into Cart table with OrderID
                string insertCartQuery = "INSERT INTO Cart (OrderID, ItemID, CustomerID,Name, Price) VALUES (@OrderID, @ItemID, @CustomerID, @Name, @Price)";
                SqlCommand cartCommand = new SqlCommand(insertCartQuery, connection);  
                cartCommand.Parameters.AddWithValue("@OrderID", orderID);
                cartCommand.Parameters.AddWithValue("@ItemID", selectedItemID);
                cartCommand.Parameters.AddWithValue("@CustomerID", customerID);
                cartCommand.Parameters.AddWithValue("@Name", itemName);
                cartCommand.Parameters.AddWithValue("@Price", totalPrice);
                cartCommand.ExecuteNonQuery();

                MessageBox.Show("Item added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                DisplayCart();
                DisplayPrice();
                //GetItemName(selectedItemID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private decimal CalculateTotalPrice(int itemID)
        {
            decimal totalPrice = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\waqas laptops\\Documents\\cms.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    string query = "SELECT Price FROM MenuItems WHERE ItemID = @ItemID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ItemID", itemID);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        totalPrice = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalPrice;
        }


        public string GetItemName(int itemId)
        {
            string itemName = "";

            try
            {
                connection.Open();

                string selectQuery = "SELECT Name FROM MenuItems WHERE ItemID = @ItemId";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", itemId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            itemName = reader["Name"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving item name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                   connection.Close();
                
            }

            return itemName;
        }





        private void removeFromCart_Click(object sender, EventArgs e)
        {
            int selectedItemID = (int)itemChosen.Value;
            try
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Cart WHERE ItemID = @ItemID";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@ItemID", selectedItemID); 
                command.ExecuteNonQuery();
                MessageBox.Show("Item removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void getPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void DisplayCart()
        {
            
            //int customerID = (int)getCustomerID.Value;

            int customerID = 1; 

            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ItemID, Name FROM Cart WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cart.DataSource = dt;
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

        private void DisplayPrice()
        {
            int customerID = 1; 

            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT SUM(Price) AS TotalPrice FROM Cart WHERE CustomerID = @CustomerID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    priceGrid.DataSource = dt;
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


        private void customerOrderView_Load(object sender, EventArgs e)
        {

        }

        private void priceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
