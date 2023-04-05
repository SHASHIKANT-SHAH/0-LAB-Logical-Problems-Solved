//query operation
//In this example, YourDbContext is the name of your database context class and YourEntity is the name of the entity class that corresponds to the table that the stored procedure is querying. YourStoredProcedure is the name of the stored procedure that you want to execute.
using (var context = new YourDbContext())
{
    var result = context.Database.SqlQuery<YourEntity>("exec YourStoredProcedure").ToList();
}


//insert operaton
//In this example, InsertNewRecord is the name of the stored procedure that inserts a new record into a table. The @Name and @Email parameters correspond to the columns in the table. The SqlParameter class is used to create the parameters that are passed to the stored procedure. The ExecuteSqlCommand method is used to execute the stored procedure. The result variable contains the number of rows affected by the operation.
using (var context = new YourDbContext())
{
    var nameParam = new SqlParameter("@Name", "John Doe");
    var emailParam = new SqlParameter("@Email", "johndoe@example.com");
    
    var result = context.Database.ExecuteSqlCommand("exec InsertNewRecord @Name, @Email", nameParam, emailParam);
}

//update operation
//Assuming we have a stored procedure named UpdateProduct that accepts two parameters @productId and @productName, and updates the product with the given productId to have the given productName.
using (var context = new MyDbContext())
{
    var productIdParam = new SqlParameter("@productId", 1);
    var productNameParam = new SqlParameter("@productName", "New Product Name");

    context.Database.ExecuteSqlCommand("EXEC UpdateProduct @productId, @productName", productIdParam, productNameParam);
}

//delete operation
//Assuming we have a stored procedure named DeleteProduct that accepts one parameter @productId, and deletes the product with the given productId.
//Note that in both cases we are using the ExecuteSqlCommand method to execute the stored procedure, passing in the necessary parameters as SqlParameter objects.
using (var context = new MyDbContext())
{
    var productIdParam = new SqlParameter("@productId", 1);

    context.Database.ExecuteSqlCommand("EXEC DeleteProduct @productId", productIdParam);
}
