using Microsoft.Data.SqlClient;

namespace StudentProfile.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            @"Data Source=KIYO\SQLEXPRESS;Initial Catalog=Room;Integrated Security=True;Trust Server Certificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}