using System.Data.SqlClient;

namespace _42_ConsumeData
{
    public static class InsertUpdateDeleteSqlCommand
    {
        public static void GetExample()
        {
            const string connectionString = "Server=LAPTOP-201QPF8A\\SQLEXPRESS;Database=EcommerceDb;Trusted_Connection=true";

            const string productDescription = "Product 4";
            const int productQuantity = 400;
            const decimal productPrice = 400.0m;

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                const string insertionQuery = "INSERT INTO Product VALUES (@description, @quantity, @price)";
                const string updateQuery = "UPDATE Product SET Price = 4 WHERE Description = @description";
                const string deletionQuery = "DELETE FROM Product WHERE Description = @description";

                // Setting and running INSERT command
                var sqlCommand = new SqlCommand(insertionQuery, sqlConnection);

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("description", productDescription);
                sqlCommand.Parameters.AddWithValue("quantity", productQuantity);
                sqlCommand.Parameters.AddWithValue("price", productPrice);

                sqlCommand.ExecuteNonQuery();

                // Setting and running UPDATE command
                sqlCommand.CommandText = updateQuery;

                sqlCommand.ExecuteNonQuery();

                // Setting and running DELETE command
                sqlCommand.CommandText = deletionQuery;

                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
