using System;
using System.Data.SqlClient;

namespace _42_ConsumeData
{
    public static class RetrievingData
    {
        public static void GetExample()
        {
            const string connectionString = "Server=LAPTOP-201QPF8A\\SQLEXPRESS;Database=EcommerceDb;Trusted_Connection=true";

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                const string query = "SELECT Id, Description, Quantity, Price FROM Product";

                var sqlCommand = new SqlCommand(query, sqlConnection);

                var sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var id = sqlDataReader["Id"]; // sqlDataReader.GetInt32(0);
                    var description = sqlDataReader["Description"]; // sqlDataReader.GetString(1);
                    var quantity = sqlDataReader["Quantity"]; // sqlDataReader.GetInt32(2);
                    var price = sqlDataReader["Price"]; // sqlDataReader.GetDecimal(3);

                    Console.WriteLine(
                        $"Id: {id}, " +
                        $"Description: {description}, " +
                        $"Quantity: {quantity}, " +
                        $"Price: {price}");
                }

                sqlDataReader.Close();
            }
        }
    }
}
