using (var context = new YourDbContext())
{
    // INSERT
    var insertQuery = "INSERT INTO YourTable (Column1, Column2) VALUES (@value1, @value2)";
    var value1 = "Some value";
    var value2 = 123;
    context.Database.ExecuteSqlCommand(insertQuery, new SqlParameter("@value1", value1), new SqlParameter("@value2", value2));

    // UPDATE
    var updateQuery = "UPDATE YourTable SET Column1 = @value1 WHERE Column2 = @value2";
    var updatedValue1 = "Updated value";
    var updatedValue2 = 123;
    context.Database.ExecuteSqlCommand(updateQuery, new SqlParameter("@value1", updatedValue1), new SqlParameter("@value2", updatedValue2));

    // DELETE
    var deleteQuery = "DELETE FROM YourTable WHERE Column1 = @value1";
    var valueToDelete = "Some value";
    context.Database.ExecuteSqlCommand(deleteQuery, new SqlParameter("@value1", valueToDelete));

    // SELECT
    var selectQuery = "SELECT * FROM YourTable WHERE Column1 = @value1";
    var valueToSelect = "Some value";
    var result = context.Database.SqlQuery<YourTable>(selectQuery, new SqlParameter("@value1", valueToSelect)).ToList();
}

Note that YourDbContext is the name of your database context class, and YourTable is the name of the table in your database. You will also need to add the System.Data.SqlClient namespace to use the SqlParameter class.
