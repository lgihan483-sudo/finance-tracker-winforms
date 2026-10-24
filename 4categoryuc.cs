using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace cmzz
{
    public partial class category : UserControl
    {
        string stringconnection = DatabaseConfig.ConnectionString;


        public category()
        {
            InitializeComponent();
            displaycategorylist();

        }

        public void displaycategorylist()
        {
            categorydata cdata = new categorydata();
            List<categorydata> listdata = cdata.categorylistdata();

            dataGridView1.DataSource = listdata;
        }



        private void button4_Click(object sender, EventArgs e)
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

        private void btncadd_Click(object sender, EventArgs e)
        {
            if (cmbccategory.Text == "" || cmbctype.SelectedIndex == -1 || cmbcstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill All The Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringconnection))
                {
                    connect.Open();

                    string insertdata = "INSERT INTO categories (category, type, status, date_insert)" +
                                        "VALUES (@category, @type, @status, @date)";

                    using (SqlCommand command = new SqlCommand(insertdata, connect))
                    {
                        command.Parameters.AddWithValue("@category", cmbccategory.Text);
                        command.Parameters.AddWithValue("@type", cmbctype.Text);
                        command.Parameters.AddWithValue("@status", cmbcstatus.Text);


                        DateTime today = DateTime.Now;
                        command.Parameters.AddWithValue("@date", today);

                        command.ExecuteNonQuery();
                        clearfields();

                        MessageBox.Show("Category Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();

                }
            }
            displaycategorylist();

        }
        private int getid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getid = Convert.ToInt32(row.Cells[0].Value);
                cmbccategory.Text = row.Cells[1].Value.ToString();
                cmbctype.SelectedItem = row.Cells[2].Value.ToString();
                cmbcstatus.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            if (cmbccategory.Text == "" || cmbctype.SelectedIndex == -1 || cmbcstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID: " + getid + "?",
                                    "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    using (SqlConnection connect = new SqlConnection(stringconnection))
                    {
                        connect.Open();

                        string updatedata = "UPDATE categories SET category = @category, type = @type, status = @status WHERE id = @id ";

                        using (SqlCommand command = new SqlCommand(updatedata, connect))
                        {
                            command.Parameters.AddWithValue("@id", getid);
                            command.Parameters.AddWithValue("@category", cmbccategory.Text);
                            command.Parameters.AddWithValue("@type", cmbctype.Text);
                            command.Parameters.AddWithValue("@status", cmbcstatus.Text);

                            command.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }



                }
            }
            displaycategorylist();
        }

        public void clearfields()
        {
            cmbccategory.Text = "";
            cmbcstatus.SelectedIndex = -1;
            cmbctype.SelectedIndex = -1;



        }

        private void btncclear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            if (cmbccategory.Text == "" || cmbctype.SelectedIndex == -1 || cmbcstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Items First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ID: " + getid + "?",
                                    "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    using (SqlConnection connect = new SqlConnection(stringconnection))
                    {
                        connect.Open();

                        string updatedata = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand command = new SqlCommand(updatedata, connect))
                        {
                            command.Parameters.AddWithValue("@id", getid);

                            command.ExecuteNonQuery();
                            clearfields();

                            MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }

                }
            }
            displaycategorylist();
        }
    }
}
