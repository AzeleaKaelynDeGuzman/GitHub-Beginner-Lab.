using Microsoft.Data.SqlClient;
using StudentProfile.Database;
using Model;
using System.Data;

namespace BusinessLogic.Repository
{
    public class RoomRepository
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        public bool AddRoom(Room room)
        {
            const string query =
            @"INSERT INTO dbo.Room (RoomNumber, RoomType, Price, Status)
              VALUES (@RoomNumber, @RoomType, @Price, @Status)";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = room.RoomNumber;
                cmd.Parameters.Add("@RoomType", SqlDbType.NVarChar, 50).Value = room.RoomType;

                var price = cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                price.Precision = 10;
                price.Scale = 2;
                price.Value = room.Price;

                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = room.Status;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetAllRooms()
        {
            const string query =
                "SELECT RoomId, RoomNumber, RoomType, Price, Status FROM dbo.Room";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}