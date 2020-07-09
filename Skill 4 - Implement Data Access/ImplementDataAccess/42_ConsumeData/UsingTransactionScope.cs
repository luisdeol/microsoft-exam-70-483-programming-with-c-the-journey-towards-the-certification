using System.Data.SqlClient;
using System.Transactions;

namespace _42_ConsumeData
{
    public static class UsingTransactionScope
    {
        public static void GetExample()
        {
            const string connectionString = "Server=LAPTOP-201QPF8A\\SQLEXPRESS;Database=EcommerceDb;Trusted_Connection=true";

            const string productDescription = "Product 4";
            const int productQuantity = 400;
            const decimal productPrice = 400.0m;

            using (var transactionScope = new TransactionScope())
            {
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    const string insertionQuery = "INSERT INTO Product VALUES (@description, @quantity, @price)";

                    // Setting and running INSERT command
                    var sqlCommand = new SqlCommand(insertionQuery, sqlConnection);

                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("description", productDescription);
                    sqlCommand.Parameters.AddWithValue("quantity", productQuantity);
                    sqlCommand.Parameters.AddWithValue("price", productPrice);

                    sqlCommand.ExecuteNonQuery();

                    transactionScope.Complete(); // If you comment this line, you will notice that the insertion is actually not completed.
                }
            }
        }
    }
}
