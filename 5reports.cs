using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmzz
{
    public partial class _5reports : UserControl
    {
        string stringconnection = DatabaseConfig.ConnectionString;

        public _5reports()
        {
            InitializeComponent();
        }


        public void searchDataByFlexibleDate()
        {
            string searchInput = txtrdate.Text.Trim();

            if (cmbrtype.SelectedItem == null || string.IsNullOrEmpty(searchInput))
            {
                MessageBox.Show("Please select Type and enter Date/Year!");
                return;
            }

            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                try
                {
                    connect.Open();
                    string query = "";
                    string type = cmbrtype.SelectedItem.ToString();

                    if (type == "Income")
                    {

                        query = "SELECT category, income, date_income FROM income WHERE CAST(date_income AS VARCHAR) LIKE @search";
                    }
                    else
                    {

                        query = "SELECT category, expense, date_expense FROM expenses WHERE CAST(date_expense AS VARCHAR) LIKE @search";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@search", searchInput + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit ?", "Exit Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //do nothing
            }
        }




        private void btniclear_Click(object sender, EventArgs e)
        {
            txtrdate.Clear();
            cmbrtype.SelectedIndex = -1;
            dataGridView1.DataSource = null;

        }

        private void btnrsearch_Click(object sender, EventArgs e)
        {
            searchDataByFlexibleDate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



