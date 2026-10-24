using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    internal class incomedata
    {
        string stringconnection = DatabaseConfig.ConnectionString;
        public int ID { set; get; }

        public string category { set; get; }

        public string item { set; get; }

        public string income { set; get; }

        public string description { set; get; }

        public string dateincome { set; get; }


        public List<incomedata> incomelistdata()
        {
            List<incomedata> listdata = new List<incomedata>();

            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string selectdata = "SELECT * FROM income";


                using (SqlCommand command = new SqlCommand(selectdata, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            incomedata idata = new incomedata();

                            idata.ID = (int)reader["ID"];
                            idata.category = reader["category"].ToString();
                            idata.item = reader["item"].ToString();
                            idata.income = reader["income"].ToString();
                            idata.description = reader["description"].ToString();
                            idata.dateincome = ((DateTime)reader["date_income"]).ToString("MM/dd/yyyy");


                            listdata.Add(idata);
                        }
                    }
                }
                return listdata;
            }
        }
    }
}
