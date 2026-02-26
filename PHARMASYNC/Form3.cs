using Microsoft.Data.SqlClient;
using System.Configuration;

namespace PHARMASYNC
{
    public partial class FormLogin : Form

    {
        string cs = ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString;
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // fetch both ROLE and FULLNAME
                string query = "SELECT  USERID, ROLE, FULLNAME FROM LOGIN WHERE USERNAME=@u AND USERPASSWORD=@p";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.CurrentUserID = reader["USERID"].ToString();
                    string role = reader["ROLE"].ToString().Trim();
                    string fullname = reader["FULLNAME"].ToString().Trim();


                    Session.CurrentUserName = fullname;
                    Session.CurrentUserRole = role;


                    MainForm dashboard = new MainForm(role);
                    dashboard.Show();

                    //MessageBox.Show("Logged in as: " + fullname, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                con.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
