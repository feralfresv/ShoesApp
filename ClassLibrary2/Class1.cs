using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {

        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static void ReadOrderData(string connectionString)
        {
            string queryString =
                "SELECT *FROM dbo.Products;";
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}",
                            reader[0], reader[1]));
                    }
                }
            }
        }

        //void Initialization()
        //{
        //    // Create a dependency connection.
        //    SqlDependency.Start(connectionString, queueName);
        //}

        //void SomeMethod()
        //{
        //    // Assume connection is an open SqlConnection.

        //    // Create a new SqlCommand object.
        //    using (SqlCommand command = new SqlCommand(
        //        "SELECT ShipperID, CompanyName, Phone FROM dbo.Shippers",
        //        connection))
        //    {

        //        // Create a dependency and associate it with the SqlCommand.
        //        SqlDependency dependency = new SqlDependency(command);
        //        // Maintain the reference in a class member.

        //        // Subscribe to the SqlDependency event.
        //        dependency.OnChange += new
        //           OnChangeEventHandler(OnDependencyChange);

        //        // Execute the command.
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            // Process the DataReader.
        //        }
        //    }
        //}

        //// Handler method
        //void OnDependencyChange(object sender,
        //   SqlNotificationEventArgs e)
        //{
        //    // Handle the event (for example, invalidate this cache entry).
        //}

        //void Termination()
        //{
        //    // Release the dependency.
        //    SqlDependency.Stop(connectionString, queueName);
        //}
    }
}
