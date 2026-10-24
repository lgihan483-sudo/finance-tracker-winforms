using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    public partial class form2register : Form
    {
        SqlConnection connect = new SqlConnection(DatabaseConfig.ConnectionString);
        public form2register()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregsignin_Click(object sender, EventArgs e)
        {
            if (txtregname.Text == "" || txtregcpw.Text == "" || txtregpw.Text == "")
            {
                MessageBox.Show("Please fill all blanks", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check  passwords match
            if (txtregpw.Text != txtregcpw.Text)
            {
                MessageBox.Show("Password doesn't match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = GetConnection())
            {
                try
                {
                    connect.Open();

                    // Check  the username already exists using ExecuteScalar
                    string selectusername = "SELECT COUNT(*) FROM users WHERE username = @username";

                    using (SqlCommand checkUser = new SqlCommand(selectusername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", txtregname.Text.Trim());

                        int userCount = (int)checkUser.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Register the new user
                            string insertData = "INSERT INTO users (username, password, data_create) VALUES (@username, @password, GETDATE())";

                            using (SqlCommand insertuser = new SqlCommand(insertData, connect))
                            {
                                insertuser.Parameters.AddWithValue("@username", txtregname.Text.Trim());
                                insertuser.Parameters.AddWithValue("@password", txtregpw.Text.Trim());

                                //date_create, but GETDATE in SQL is simple here.
                               

                                insertuser.ExecuteNonQuery();
                                MessageBox.Show("Registration Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //clear fields
                                txtregname.Text = "";
                                txtregpw.Text = "";
                                txtregcpw.Text = "";
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1login newForm = new form1login();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            this.Hide();
        }

       
        private SqlConnection GetConnection()
        {
        
            return new SqlConnection(DatabaseConfig.ConnectionString);
        }
    }
}
