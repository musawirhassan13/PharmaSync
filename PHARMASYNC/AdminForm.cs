using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PHARMASYNC
{
    public partial class AdminForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
        bool isEditMode = false;
        int userId = 0;
        public AdminForm()
        {
            InitializeComponent();
            LoadData();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadData(string searchTerm = "")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT USERID, ROLE, USERNAME, USERPASSWORD FROM LOGIN";

                if (!string.IsNullOrEmpty(searchTerm))
                    query += " WHERE USERNAME LIKE @search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                if (!string.IsNullOrEmpty(searchTerm))
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;



            }


        }


        private void ClearFields()
        {
            cmbRole.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            btnAddUser.Text = "Add User";
            isEditMode = false;
            userId = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        string.IsNullOrWhiteSpace(txtPassword.Text) ||
        string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query;

                if (isEditMode)
                    // include FULLNAME in update too
                    query = "UPDATE LOGIN SET ROLE=@r, FULLNAME=@n, USERNAME=@u, USERPASSWORD=@p WHERE USERID=@id";
                else
                    // include FULLNAME in insert
                    query = "INSERT INTO LOGIN (ROLE, FULLNAME, USERNAME, USERPASSWORD) VALUES (@r, @n, @u, @p)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@r", cmbRole.Text);
                cmd.Parameters.AddWithValue("@n", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                if (isEditMode)
                    cmd.Parameters.AddWithValue("@id", userId);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(isEditMode ? "User Updated Successfully!" : "User Added Successfully!");
                LoadData();
                ClearFields();
            }

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                userId = Convert.ToInt32(row.Cells["USERID"].Value);
                cmbRole.Text = row.Cells["ROLE"].Value.ToString();
                txtUsername.Text = row.Cells["USERNAME"].Value.ToString();


                tabControl1.SelectedTab = tabPage1;

                btnAddUser.Text = "Update User";
                isEditMode = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvUsers == null || dgvUsers.Rows.Count == 0)
            {
                MessageBox.Show("No users found in the list.");
                return;
            }


            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }


            DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];


            object idValue = selectedRow.Cells["USERID"].Value;
            object nameValue = selectedRow.Cells["USERNAME"].Value;

            if (idValue == null || nameValue == null || string.IsNullOrWhiteSpace(nameValue.ToString()))
            {
                MessageBox.Show("Invalid user data. Please select a valid row.");
                return;
            }

            int selectedID = Convert.ToInt32(idValue);
            string username = nameValue.ToString().Trim();


            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Main Admin account cannot be deleted!");
                return;
            }


            DialogResult dr = MessageBox.Show(
                $"Are you sure you want to delete '{username}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        string query = "DELETE FROM LOGIN WHERE USERID=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", selectedID);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rows > 0)
                            MessageBox.Show("User deleted successfully!");
                        else
                            MessageBox.Show("User not found in database!");
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user:\n" + ex.Message);
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadData(searchTerm);
        }



    }
}
