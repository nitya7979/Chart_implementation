using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LineChart_Implementation.Models
{
    public static class DataProviderService
    {

        public static List<GoogleChartData> GetGoogleChartDatas()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            
            List<GoogleChartData> googleChartDatas = new List<GoogleChartData>();

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select  *from GoogleChartData", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        var googlecharobj = new GoogleChartData();

                          
                        //googlecharobj.SLID = reader["SLID"].ToString();
                        googlecharobj.Year = Convert.ToInt32(reader["Year"]); 
                        googlecharobj.Electronics = Convert.ToInt32(reader["Electronics"]);
                        googlecharobj.BookAndMedia = Convert.ToInt32(reader["BookAndMedia"]); 
                        googlecharobj.HomeAndKitchen = Convert.ToInt32(reader["HomeAndKitchen"]);

                        //Add the DataRow to the DataTable
                        googleChartDatas.Add(googlecharobj);
                    }
                   
                }
            }

            return googleChartDatas;
        }
}
}