using System.Data.SqlClient;

// Create a connection string for your database
string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

// INSERT
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string insertQuery = "INSERT INTO YourTable (Column1, Column2) VALUES (@value1, @value2)";
    SqlCommand command = new SqlCommand(insertQuery, connection);
    command.Parameters.AddWithValue("@value1", "Some value");
    command.Parameters.AddWithValue("@value2", 123);
    int rowsInserted = command.ExecuteNonQuery();
}

// UPDATE
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string updateQuery = "UPDATE YourTable SET Column1 = @value1 WHERE Column2 = @value2";
    SqlCommand command = new SqlCommand(updateQuery, connection);
    command.Parameters.AddWithValue("@value1", "Updated value");
    command.Parameters.AddWithValue("@value2", 123);
    int rowsUpdated = command.ExecuteNonQuery();
}

// DELETE
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string deleteQuery = "DELETE FROM YourTable WHERE Column1 = @value1";
    SqlCommand command = new SqlCommand(deleteQuery, connection);
    command.Parameters.AddWithValue("@value1", "Some value");
    int rowsDeleted = command.ExecuteNonQuery();
}

// SELECT
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string selectQuery = "SELECT * FROM YourTable WHERE Column1 = @value1";
    SqlCommand command = new SqlCommand(selectQuery, connection);
    command.Parameters.AddWithValue("@value1", "Some value");
    SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        // Access the data from the reader
        int id = reader.GetInt32(0);
        string column1 = reader.GetString(1);
        int column2 = reader.GetInt32(2);
    }
}
