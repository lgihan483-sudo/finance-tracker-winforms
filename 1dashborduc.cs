using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    public partial class Dashbord : UserControl
    {
        string stringconnection = DatabaseConfig.ConnectionString;

        public Dashbord()
        {
            InitializeComponent();
            incometodayincome();
            incomethismonthincome();
            incomethisyearincome();
            expensetodayexpense();
            expensethismonthexpense();
            expensethisyearexpense();
            calculateMonthlyBalance();
            
        }


        //income
        public void incometodayincome()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string query = "SELECT ISNULL(SUM(CAST(income AS DECIMAL(18, 2))), 0) FROM income WHERE date_income = @date_in";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now;

                    cmd.Parameters.AddWithValue("@date_in", today.Date);

                    decimal todayIncome = Convert.ToDecimal(cmd.ExecuteScalar());

                    dincome.Text = "Rs " + todayIncome.ToString("0.00");
                }
            }
        }


        public void incomethismonthincome()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string query = "SELECT ISNULL(SUM(CAST(income AS DECIMAL(18, 2))), 0) FROM income WHERE date_income >= @firstday AND date_income < @tomorrow";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now;

                    DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);

                    DateTime tomorrow = today.Date.AddDays(1);

                    cmd.Parameters.AddWithValue("@firstday", firstDayOfMonth.Date);

                    cmd.Parameters.AddWithValue("@tomorrow", tomorrow);

                    decimal monthIncome = Convert.ToDecimal(cmd.ExecuteScalar());

                    mincome.Text = "Rs " + monthIncome.ToString("0.00");
                }
            }
        }


        public void incomethisyearincome()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string query = "SELECT ISNULL(SUM(CAST(income AS DECIMAL(18, 2))), 0) FROM income WHERE date_income >= @firstdayOfYear AND date_income < @tomorrow";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now;

                    DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);

                    DateTime tomorrow = today.Date.AddDays(1);

                    cmd.Parameters.AddWithValue("@firstdayOfYear", firstDayOfYear.Date);

                    cmd.Parameters.AddWithValue("@tomorrow", tomorrow);

                    decimal yearIncome = Convert.ToDecimal(cmd.ExecuteScalar());

                    yincome.Text = "Rs " + yearIncome.ToString("0.00");
                }
            }
        }

        //expense

        public void expensetodayexpense()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string query = "SELECT ISNULL(SUM(CAST(expense AS DECIMAL(18, 2))), 0) FROM expenses WHERE date_expense >= @today AND date_expense < @tomorrow";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now.Date;

                    DateTime tomorrow = today.AddDays(1);


                    cmd.Parameters.AddWithValue("@today", today);

                    cmd.Parameters.AddWithValue("@tomorrow", tomorrow);

                    decimal todayExpense = Convert.ToDecimal(cmd.ExecuteScalar());

                    dexp.Text = "Rs " + todayExpense.ToString("0.00");
                }
            }
        }


        public void expensethismonthexpense()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();


                string query = "SELECT ISNULL(SUM(CAST(expense AS DECIMAL(18, 2))), 0) FROM expenses WHERE date_expense >= @firstday AND date_expense < @tomorrow";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now;

                    DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);

                    DateTime tomorrow = today.Date.AddDays(1);

                    cmd.Parameters.AddWithValue("@firstday", firstDayOfMonth.Date);

                    cmd.Parameters.AddWithValue("@tomorrow", tomorrow);

                    decimal monthExpense = Convert.ToDecimal(cmd.ExecuteScalar());

                    mexp.Text = "Rs " + monthExpense.ToString("0.00");
                }
            }
        }



        public void expensethisyearexpense()
        {
            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string query = "SELECT ISNULL(SUM(CAST(expense AS DECIMAL(18, 2))), 0) FROM expenses WHERE date_expense >= @firstdayOfYear AND date_expense < @tomorrow";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Now;

                    DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);

                    DateTime tomorrow = today.Date.AddDays(1);

                    cmd.Parameters.AddWithValue("@firstdayOfYear", firstDayOfYear.Date);

                    cmd.Parameters.AddWithValue("@tomorrow", tomorrow);

                    decimal yearExpense = Convert.ToDecimal(cmd.ExecuteScalar());

                    yexp.Text = "Rs " + yearExpense.ToString("0.00");
                }
            }
        }


        


        public void calculateMonthlyBalance()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(stringconnection))
                {
                    connect.Open();

                    DateTime today = DateTime.Now;
                    DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime tomorrow = today.Date.AddDays(1);

                    string incomeQuery = "SELECT ISNULL(SUM(CAST(income AS DECIMAL(18, 2))), 0) FROM income WHERE date_income >= @firstday AND date_income < @tomorrow";
                    decimal totalIncome = 0;
                    using (SqlCommand cmdIn = new SqlCommand(incomeQuery, connect))
                    {
                        cmdIn.Parameters.AddWithValue("@firstday", firstDayOfMonth.Date);
                        cmdIn.Parameters.AddWithValue("@tomorrow", tomorrow);
                        totalIncome = Convert.ToDecimal(cmdIn.ExecuteScalar());
                    }

                    string expenseQuery = "SELECT ISNULL(SUM(CAST(expense AS DECIMAL(18, 2))), 0) FROM expenses WHERE date_expense >= @firstday AND date_expense < @tomorrow";
                    decimal totalExpense = 0;
                    using (SqlCommand cmdOut = new SqlCommand(expenseQuery, connect))
                    {
                        cmdOut.Parameters.AddWithValue("@firstday", firstDayOfMonth.Date);
                        cmdOut.Parameters.AddWithValue("@tomorrow", tomorrow);
                        totalExpense = Convert.ToDecimal(cmdOut.ExecuteScalar());
                    }

                    decimal balance = totalIncome - totalExpense;

                    if (balance >= 0)
                    {
                        tincome.Text = "Rs." + balance.ToString("0.00");
                        tincome.ForeColor = Color.Green;
                    }
                    else
                    {
                        tincome.Text = "Rs." + Math.Abs(balance).ToString("0.00");
                        tincome.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dincome_Click(object sender, EventArgs e)
        {

        }
    }
}
