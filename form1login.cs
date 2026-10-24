using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace cmzz
{
    public partial class form1login : Form
    {
        public form1login()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            form2register newform = new form2register();
            newform.StartPosition = FormStartPosition.CenterParent;
            newform.ShowDialog();
            this.Hide();



        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 100).Value = txtname.Text;
                        cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 100).Value = txtpw.Text;

                        int count = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

                        if (count > 0)
                        {


                            this.Hide();

                            form3dashbord dashboard = new form3dashbord();
                            dashboard.Show();
                        }
                        else
                        {

                            MessageBox.Show("Incorrect username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            txtpw.PasswordChar = '\0'; 
            }
            else
            {
             txtpw.PasswordChar = '*';
             }
        }
    }
}
