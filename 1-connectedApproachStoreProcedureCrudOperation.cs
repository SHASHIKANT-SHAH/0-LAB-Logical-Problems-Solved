//In this example, we use the SqlConnection and SqlCommand classes to execute stored procedures. We specify the stored procedure name and type of command (CommandType.StoredProcedure), and add any required parameters using the Parameters.AddWithValue method. We then call ExecuteNonQuery method to execute the command and return the number of rows affected.
//NOTE->placeholders "YourInsertStoredProcedure", "YourSelectStoredProcedure", "YourUpdateStoredProcedure", and "YourDeleteStoredProcedure" to represent the actual names of the stored procedures you want to call.
//When you replace these placeholders with the actual names of your stored procedures, the code will call those stored procedures to perform the corresponding CRUD operations.
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True;";
            
            // CREATE
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("YourInsertStoredProcedure", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Parameter1", "Some value");
                command.Parameters.AddWithValue("@Parameter2", 123);
                connection.Open();
                int result = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + result);
            }
            
            // READ
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("YourSelectStoredProcedure", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Parameter1", "Some value");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Column1"].ToString() + " " + reader["Column2"].ToString());
                }
                reader.Close();
            }
            
            // UPDATE
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("YourUpdateStoredProcedure", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Parameter1", "Updated value");
                command.Parameters.AddWithValue("@Parameter2", 123);
                connection.Open();
                int result = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + result);
            }
            
            // DELETE
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("YourDeleteStoredProcedure", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Parameter1", "Some value");
                connection.Open();
                int result = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + result);
            }
        }
    }
}
