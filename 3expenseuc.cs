using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    public partial class addexpense : UserControl
    {

        string stringconnection = DatabaseConfig.ConnectionString;


        public addexpense()
        {
            InitializeComponent();
            displayexpensedata();
            displaycategorylist();
        }

        public void displayexpensedata()
        {
            expensedata edata = new expensedata();
            List<expensedata> listdata = edata.expenselistdata();
            dataGridView1.DataSource = listdata;
        }



        public void displaycategorylist()
        {
            using SqlConnection connect = new SqlConnection(stringconnection);
            {
                connect.Open();

                string selectdata = "SELECT category , type, status FROM categories WHERE type = @type AND status = @status";


                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expense");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cmbecategory.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbecategory.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
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

        private void btenadd_Click(object sender, EventArgs e)
        {
            if (cmbecategory.SelectedIndex == -1 || cmbetype.Text == "" || txteamount.Text == "" || txtedescription.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringconnection))
                {
                    connection.Open();
                    string insertdata = "INSERT INTO expenses (category , item , expense , description , date_expense , date_insert ) VALUES (@category, @item, @expense , @description , @date_expense , @date )";
                    using (SqlCommand cmd = new SqlCommand(insertdata, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", cmbecategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", cmbetype.Text);
                        cmd.Parameters.AddWithValue("@expense", decimal.Parse(txteamount.Text, System.Globalization.CultureInfo.InvariantCulture));
                        cmd.Parameters.AddWithValue("@description", txtedescription.Text);
                        cmd.Parameters.AddWithValue("@date_expense", dateTimePicker1.Value.Date);

                        DateTime today = DateTime.Now.Date;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearfields();

                        MessageBox.Show("Expense Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connection.Close();
                }
            }
            displayexpensedata();
        }

        public void clearfields()
        {
            {
                cmbecategory.SelectedIndex = -1;
                cmbetype.Text = "";
                txteamount.Text = "";
                txtedescription.Text = "";
                dateTimePicker1.Value = DateTime.Now;

            }
        }

        private void btneclear_Click(object sender, EventArgs e)
        {
            {
                clearfields();
            }
        }

        private void btneupdate_Click(object sender, EventArgs e)
        {

            if (cmbecategory.SelectedIndex == -1 || cmbetype.Text == "" || txteamount.Text == "" || txtedescription.Text == "")
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Update This Expense ?", "Update Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringconnection))
                    {
                        connection.Open();

                        string updatedata = "UPDATE expenses SET category = @category , item = @item , expense = @expense , description = @description, date_expense = @date_expense , date_insert = @date WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updatedata, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getid);

                            cmd.Parameters.AddWithValue("@category", cmbecategory.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@item", cmbetype.Text);

                            cmd.Parameters.AddWithValue("@expense", decimal.Parse(txteamount.Text, System.Globalization.CultureInfo.InvariantCulture));

                            cmd.Parameters.AddWithValue("@description", txtedescription.Text);
                            cmd.Parameters.AddWithValue("@date_expense", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                            cmd.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Expense Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();
                    }
                }
            }
            displayexpensedata();
            {

            }
        }

        private int getid = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getid = (int)row.Cells["ID"].Value;

                cmbecategory.SelectedItem = row.Cells["Category"].Value.ToString();
                cmbetype.Text = row.Cells["Item"].Value.ToString();
                txteamount.Text = row.Cells["Expense"].Value.ToString();
                txtedescription.Text = row.Cells["Description"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["date_expense"].Value);



            }
        }

        private void btnedelete_Click(object sender, EventArgs e)
        {
            if (cmbecategory.SelectedIndex == -1 || cmbetype.Text == "" || txteamount.Text == "" || txtedescription.Text == "")
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Expense ?", "Delete Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringconnection))
                    {
                        connection.Open();

                        string deletedata = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deletedata, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getid);

                            cmd.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Expense Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();
                    }
                }
            }
            displayexpensedata();
        }
    }

}
