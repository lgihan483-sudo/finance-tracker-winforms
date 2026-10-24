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
    public partial class addincome : UserControl
    {
        string stringconnection = DatabaseConfig.ConnectionString;

        public addincome()
        {
            InitializeComponent();
            displaycategorylist();
            displayincomedata();
        }

        public void displayincomedata()
        {
            incomedata idata = new incomedata();
            List<incomedata> listdata = idata.incomelistdata();
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
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cmbicategory.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbicategory.Items.Add(reader["category"].ToString());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btniadd_Click(object sender, EventArgs e)
        {
            if (cmbicategory.SelectedIndex == -1 || txtiitem.Text == "" || txtiamount.Text == "" || txtidescription.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringconnection))
                {
                    connection.Open();
                    string insertdata = "INSERT INTO income (category, item, income, description, date_income, date_insert ) VALUES (@category, @item, @income, @description, @date_income, @date )";
                    using (SqlCommand cmd = new SqlCommand(insertdata, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", cmbicategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", txtiitem.Text);
                        cmd.Parameters.AddWithValue("@income", decimal.Parse(txtiamount.Text));
                        cmd.Parameters.AddWithValue("@description", txtidescription.Text);
                        cmd.Parameters.AddWithValue("@date_income", dateTimePicker1.Value.Date);

                        DateTime today = DateTime.Now.Date;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearfields();

                        MessageBox.Show("Income Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connection.Close();
                }
            }
            displayincomedata();
        }


        public void clearfields()
        {
            cmbicategory.SelectedIndex = -1;
            txtiitem.Clear();
            txtiamount.Clear();
            txtidescription.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btniclear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void btniupdate_Click(object sender, EventArgs e)
        {
           

            if (cmbicategory.SelectedIndex == -1 || txtiitem.Text == "" || txtiamount.Text == "" || txtidescription.Text == "")
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Update This Income ?", "Update Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringconnection))
                    {
                        connection.Open();


                        string updatedata = "UPDATE income SET category = @category , item = @item , income = @income , description = @description, date_income = @date_income , date_insert = @date WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updatedata, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getid);
                            cmd.Parameters.AddWithValue("@category", cmbicategory.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@item", txtiitem.Text);
                            cmd.Parameters.AddWithValue("@income", decimal.Parse(txtiamount.Text));
                            cmd.Parameters.AddWithValue("@description", txtidescription.Text);
                            cmd.Parameters.AddWithValue("@date_income", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                            cmd.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Income Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();


                    }
                }
                
            }
            displayincomedata();
        }

        public int getid = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getid = (int)row.Cells["ID"].Value;

                cmbicategory.SelectedItem = row.Cells["Category"].Value.ToString();
                txtiitem.Text = row.Cells["Item"].Value.ToString();
                txtiamount.Text = row.Cells["Income"].Value.ToString();
                txtidescription.Text = row.Cells["Description"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Dateincome"].Value);



            }
        }

        private void btnidelete_Click(object sender, EventArgs e)
        {
            if (cmbicategory.SelectedIndex == -1 || txtiitem.Text == "" || txtiamount.Text == "" || txtidescription.Text == "")
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Income ?", "Delete Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringconnection))
                    {
                        connection.Open();


                        string insertdata = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertdata, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getid);


                            cmd.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Income Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();
                    }      

                }
            }
            displayincomedata();
        }
    }
    
}
