using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;            
using System.Data;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static PHARMASYNC.MainForm;


namespace PHARMASYNC
{
    public partial class MainForm : Form
    {
        bool isEditMode = false;
        string cs = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
        DataTable dtSale = new DataTable();
        int selectedID = -1;
        string selectedName = "";
        decimal selectedRate = 0;
        private string currentRole;


        public MainForm(string role)
        {
            InitializeComponent();
            currentRole = role;


        }
       


        public void LoadInventory()
        {

            using (SqlConnection con = new SqlConnection(cs))
            {

                string query = "SELECT * FROM PRODUCT";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("COMPANY"))
                    dataGridView1.Columns["COMPANY"].Visible = false;

                if (dataGridView1.Columns.Contains("catID"))
                    dataGridView1.Columns["catID"].Visible = false;
            }

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproductname.Text) ||
                string.IsNullOrWhiteSpace(producttype.Text) ||
                string.IsNullOrWhiteSpace(productsalyerate.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                if (isEditMode == false)
                {
                    // 🔹 ADD MODE
                    string insertQuery = "INSERT INTO PRODUCT (NAME, TYPE, QUANTITY, BATCH_NO, SALE_RATE, PURCHASE_RATE, EXPIRY_DATE) VALUES (@NAME, @TYPE, @QUANTITY, @BATCH_NO, @SALE_RATE, @PURCHASE_RATE, @EXPIRY_DATE)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);

                    cmd.Parameters.AddWithValue("@NAME", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@TYPE", producttype.Text);
                    cmd.Parameters.AddWithValue("@QUANTITY", productquantity.Value);
                    cmd.Parameters.AddWithValue("@BATCH_NO", prodcutbatchno.Text);
                    cmd.Parameters.AddWithValue("@SALE_RATE", productsalyerate.Text);
                    cmd.Parameters.AddWithValue("@PURCHASE_RATE", productpurchase.Text);
                    cmd.Parameters.AddWithValue("@EXPIRY_DATE", productexpiry.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                }
                else
                {
                    // 🔹 UPDATE MODE
                    string updateQuery = "UPDATE PRODUCT SET NAME=@NAME, TYPE=@TYPE, QUANTITY=@QUANTITY, BATCH_NO=@BATCH_NO, SALE_RATE=@SALE_RATE, PURCHASE_RATE=@PURCHASE_RATE, EXPIRY_DATE=@EXPIRY_DATE WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);

                    cmd.Parameters.AddWithValue("@NAME", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@TYPE", producttype.Text);
                    cmd.Parameters.AddWithValue("@QUANTITY", productquantity.Value);
                    cmd.Parameters.AddWithValue("@BATCH_NO", prodcutbatchno.Text);
                    cmd.Parameters.AddWithValue("@SALE_RATE", productsalyerate.Text);
                    cmd.Parameters.AddWithValue("@PURCHASE_RATE", productpurchase.Text);
                    cmd.Parameters.AddWithValue("@EXPIRY_DATE", productexpiry.Value);
                    cmd.Parameters.AddWithValue("@ID", productid.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Product updated successfully!");
                    else
                        MessageBox.Show("No record found to update!");
                }

                LoadInventory(); // Medicines ko load krega inventry mn
                ClearFields();   // clear krega after add/update 
            }
        }
        
        private void ClearFields()
        {
            txtproductname.Clear();
            producttype.Text = "";
            productquantity.Value = 0;
            prodcutbatchno.Clear();
            productsalyerate.Clear();
            productpurchase.Clear();
            productexpiry.Value = DateTime.Now;
            productid.Clear();
            isEditMode = false;
            button1.Text = "Add";
        }

        private void Product_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "DELETE FROM PRODUCT WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", productid.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Product deleted successfully!");
                        //  Yeh line shamil kren: Data delete hone ke baad grid ko refresh kr dega.
                        LoadInventory();
                        ClearFields(); // Aur fields ko bhi clear kr dein.
                    }
                    else
                    {
                        MessageBox.Show("No product found with this ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(medicinename.Text))
            {
                LoadInventory();
            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM PRODUCT WHERE NAME LIKE @NAME";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NAME", "%" + medicinename.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                productid.Text = row.Cells["ID"].Value.ToString();
                txtproductname.Text = row.Cells["NAME"].Value.ToString();
                producttype.Text = row.Cells["TYPE"].Value.ToString();
                productquantity.Value = Convert.ToDecimal(row.Cells["QUANTITY"].Value);
                prodcutbatchno.Text = row.Cells["BATCH_NO"].Value.ToString();
                productpurchase.Text = row.Cells["PURCHASE_RATE"].Value.ToString();
                productsalyerate.Text = row.Cells["SALE_RATE"].Value.ToString();
                productexpiry.Value = Convert.ToDateTime(row.Cells["EXPIRY_DATE"].Value);


                isEditMode = true;
                button1.Text = "Update";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"{Session.CurrentUserName}";
            button1.Text = "Add";
            LoadInventory();       // for stock section
            LoadProductNames();    // for autocomplete
            LoadSalesGrid();
            
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
            timer1.Interval = 1000; // 1 second
            timer1.Start();

            dtSale.Columns.Add("ID", typeof(int));
            dtSale.Columns.Add("NAME", typeof(string));
            dtSale.Columns.Add("SALE_RATE", typeof(decimal));
            dtSale.Columns.Add("QUANTITY", typeof(int));
            dtSale.Columns.Add("TOTAL", typeof(decimal));


            dataGridView3.DataSource = dtSale;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                // show admin tab
                tabPage5.Visible = true;

                // load AdminForm inside tabPage5
                AdminForm adminForm = new AdminForm();
                adminForm.TopLevel = false;
                adminForm.FormBorderStyle = FormBorderStyle.None;
                adminForm.Dock = DockStyle.Fill;

                tabPage5.Controls.Clear();  // clear old content if any
                tabPage5.Controls.Add(adminForm);
                adminForm.Show();
            }
            else
            {
                // hide admin tab for normal users
                tabPage5.Parent = null; // 
                tabPage2.Parent = null;
            }

        }

        private void medicinename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Use e.RowIndex for safety
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Use proper casting and null checks for safety
                selectedID = Convert.ToInt32(row.Cells["ID"].Value);
                selectedName = row.Cells["NAME"].Value?.ToString() ?? string.Empty;
                selectedRate = Convert.ToDecimal(row.Cells["SALE_RATE"].Value);

                
                


            }
        }
        private void LoadSalesGrid()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, NAME, SALE_RATE, QUANTITY,TYPE FROM PRODUCT", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void LoadProductNames()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT NAME FROM PRODUCT", con);
                SqlDataReader reader = cmd.ExecuteReader();

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    collection.Add(reader["NAME"]?.ToString() ?? string.Empty);
                }

                name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                name.AutoCompleteSource = AutoCompleteSource.CustomSource;
                name.AutoCompleteCustomSource = collection;

                reader.Close();
                con.Close();
            }
        }



        private void searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "SELECT ID, NAME, SALE_RATE, QUANTITY, TYPE FROM PRODUCT WHERE NAME LIKE @name + '%'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@name", name.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }


        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                LoadSalesGrid();
            }
        }




        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            int qtyToSell = (int)quantity.Value;
            if (qtyToSell <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            // Step 1: DataBase se current stock check kren
            int currentStock = 0;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string stockQuery = "SELECT QUANTITY FROM PRODUCT WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(stockQuery, con);
                cmd.Parameters.AddWithValue("@ID", selectedID);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Convert to integer (agar database mein QUANTITY int hai)
                    currentStock = Convert.ToInt32(result);
                }
            }

            // Check if item already exists in sales grid
            DataRow? existingRow = dtSale.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("ID") == selectedID);

            int newTotalQty = qtyToSell;
            if (existingRow != null)
            {
                int currentQtyInSale = existingRow.Field<int>("QUANTITY");
                newTotalQty += currentQtyInSale;
            }

            // Step 2: Stock Check: Agar bechi jane wali total quantity, stock se zyada ho to roken
            if (newTotalQty > currentStock)
            {
                MessageBox.Show($"Insufficient stock! Available quantity for '{selectedName}' is: {currentStock}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            decimal total = selectedRate * qtyToSell;



            if (existingRow != null)
            {
                existingRow["QUANTITY"] = newTotalQty;
                existingRow["TOTAL"] = selectedRate * newTotalQty;
            }
            else
            {
                dtSale.Rows.Add(selectedID, selectedName, selectedRate, qtyToSell, total);
            }



            dataGridView3.Refresh();
            quantity.Value = 0;
        }
        private void ClearSaleGrid()
        {
            dtSale.Rows.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                int selectedIndex = dataGridView3.CurrentRow.Index;
                dtSale.Rows.RemoveAt(selectedIndex);
                dataGridView3.Refresh();
            }
            else
            {
                MessageBox.Show("Select an item to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dtSale.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear all items?",
                                                      "Confirm",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dtSale.Rows.Clear();
                    dataGridView3.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Sale grid is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dtSale.Rows.Count == 0)
            {
                MessageBox.Show("No items selected for sale.");
                return;
            }

            string custID = txtCustomerID.Text;

            if (string.IsNullOrWhiteSpace(custID))
            {
                custID = "CUST-" + DateTime.Now.ToString("yyMMddHHmmss");
            }

            try
            {
                //  STEP 1 — UPDATE STOCK
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    foreach (DataRow row in dtSale.Rows)
                    {
                        int productID = Convert.ToInt32(row["ID"]);
                        int qtySold = Convert.ToInt32(row["QUANTITY"]);

                        string updateStockQuery =
                        @"UPDATE PRODUCT 
                  SET QUANTITY = QUANTITY - @qty 
                  WHERE ID = @id";

                        SqlCommand cmd = new SqlCommand(updateStockQuery, con);
                        cmd.Parameters.AddWithValue("@qty", qtySold);
                        cmd.Parameters.AddWithValue("@id", productID);
                        cmd.ExecuteNonQuery();
                    }
                }

                //  STEP 2 — CREATE INVOICE FORM
                InvoiceForm invoice = new InvoiceForm(
                    dtSale,
                    custID,
                    txtCustomerName.Text,
                    txtPhone.Text,
                    txtAddress.Text,
                    numericUpDown1.Value,
                    Session.CurrentUserID
                );

                //  STEP 3 — SHOW INVOICE
                invoice.ShowDialog();

                //  STEP 4 — REFRESH ALL GRIDS
                LoadInventory();
                LoadStockData();
                LoadSalesGrid();
                ClearSaleGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while completing sale: " + ex.Message);
            }
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void ViewStockForm_Load(object sender, EventArgs e)
        {
            LoadStockData();
            dataGridView5.ReadOnly = true;
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadStockData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "SELECT ID, NAME, SALE_RATE, QUANTITY, TYPE FROM PRODUCT";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
            }
        }



        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "SELECT ID, NAME, SALE_RATE, QUANTITY, TYPE FROM PRODUCT WHERE NAME LIKE @name + '%'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@name", viewtxt.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView5.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void viewtxt_TextChanged(object sender, EventArgs e)
        {
            // Agar search box khali ho jaye to poora stock data load kr do.
            if (viewtxt.Text.Trim() == string.Empty)
            {
                LoadStockData();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to logout?",
       "Confirm Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {

                FormLogin login = new FormLogin();
                login.Show();

                // Close or hide this main form
                this.Hide();
                MessageBox.Show("You have successfully logged out!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


