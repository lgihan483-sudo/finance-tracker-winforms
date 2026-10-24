using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cmzz
{
    internal class categorydata
    {
        string stringconnection = DatabaseConfig.ConnectionString;

        public int ID { get; set; } //0

        public string Category { get; set; } //1

        public string Type { get; set; } //2

        public string Status { get; set; } //3

        public DateTime Date_Insert { get; set; } //4

        public List<categorydata> categorylistdata()
        {
            List<categorydata> listdata = new List<categorydata>();

            using (SqlConnection connect = new SqlConnection(stringconnection))
            {
                connect.Open();

                string selectquery = "SELECT * FROM categories";

                using (SqlCommand command = new SqlCommand(selectquery, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            categorydata cdata = new categorydata();

                            cdata.ID = Convert.ToInt32(reader["id"]);
                            cdata.Category = reader["category"].ToString();
                            cdata.Type = reader["type"].ToString();
                            cdata.Status = reader["status"].ToString();
                            cdata.Date_Insert = Convert.ToDateTime(reader["date_insert"]);


                            listdata.Add(cdata);
                        }
                    }
                }
            }
            return listdata;
        }





    }
}
