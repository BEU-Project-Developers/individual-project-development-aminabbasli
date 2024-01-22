// I created this Functions class to encapsulate set of some methods for interacting with a SQL Server database in my project.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // this namespace is part of ADO.NET includes classes for working with SQL Server Databases- SqlConnection  / SqlCommand and etc
using System.Data;           // This namespace contains core classes for ADO.NET, includes classes like DataSet, DataTable, and others that are used for managing and working with in-memory data.
using Microsoft.SqlServer.Server;
using System.Collections;

namespace BUS_RESERVATION_SYSTEM
{
    class Functions
    {
        private string connectionString; // will hold the connection string with database

        public Functions()
        {   // The constructor initializes the connectionString field. This field contains the connection string necessary to connect to the SQL Server database. 
            connectionString = @"Data Source=DESKTOP-AQ8T057\SQLEXPRESS;Initial Catalog=BusResManSystemDb;Integrated Security=True";
        }

        public DataTable GetData(string Query)   //Purpose of GetData(): Retrieves data from the database and returns it as a DataTable.
        {
            // Creates a new DataTable (dt) to store the result.
            // Opens a connection to the database using a SqlConnection.
            // Uses a SqlDataAdapter to fill the DataTable with the result of the query.
            // Returns the filled DataTable:

            DataTable dt = new DataTable(); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter Sda = new SqlDataAdapter(Query, connection))
                {
                    Sda.Fill(dt);
                }
            }
            return dt;
        }

        public int SetData(string Query) 
        {
            if (string.IsNullOrEmpty(Query))  // Handle or log the error /to prevent SQl injection
            {
               
                return 0;
            }

            int count;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))  //The using statement ensures that the SqlConnection is properly disposed of after the block is executed.
                {
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }


        // Because I used list of parameters in Trips.cs/ Busses.cs/ Passengers.cs/ Drivers.cs:
        public int SetData(string query, List<object> parameters)   // Overloaded SetData() method allows for parameterized queries by accepting a list of parameters
        {
            using (SqlConnection connection = new SqlConnection(connectionString))  // creates a new connection
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) //ensures proper disposal of the SqlCommand object after the block is executed.
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        command.Parameters.AddWithValue("@p" + i, parameters[i]); //For each parameter, a new parameter is added to the SqlCommand 
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }
    }

}