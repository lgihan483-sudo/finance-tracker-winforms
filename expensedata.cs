using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    internal class expensedata
    {
        string stringconnection = DatabaseConfig.ConnectionString;
        public int ID { set; get; }

        public string category { set; get; }

        public string item { set; get; }

        public string expense { set; get; }

        public string description { set; get; }

        public string date_expense { set; get; }


        public List<expensedata> expenselistdata()
        {
            List<expensedata> listdata = new List<expensedata>();

            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string selectdata = "SELECT * FROM expenses";


                using (SqlCommand command = new SqlCommand(selectdata, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            expensedata edata = new expensedata();

                            edata.ID = (int)reader["ID"];
                            edata.category = reader["category"].ToString();
                            edata.item = reader["item"].ToString();
                            edata.expense = reader["expense"].ToString();
                            edata.description = reader["description"].ToString();
                            edata.date_expense = ((DateTime)reader["date_expense"]).ToString("MM/dd/yyyy");


                            listdata.Add(edata);
                        }
                    }
                }
                return listdata;
            }
        }
    }
}
