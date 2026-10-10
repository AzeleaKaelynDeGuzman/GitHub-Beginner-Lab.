using BusinessLogic.Repository;
using Model;
using System.Data;

namespace BusinessLogic.Controller
{
    public class RoomController
    {
        private static RoomRepository repository = new RoomRepository();

        public static string CreateRoom(Room room)
        {
            if (room.RoomNumber <= 0)
                return "Invalid Room Number";

            if (string.IsNullOrWhiteSpace(room.RoomType))
                return "Select Room Type";

            if (room.Price <= 0)
                return "Invalid Price";

            if (string.IsNullOrWhiteSpace(room.Status))
                return "Select Status";

            bool success = repository.AddRoom(room);

            return success
                ? "Room Added Successfully"
                : "Failed To Add Room";
        }

        public DataTable GetRooms()
        {
            return repository.GetAllRooms();
        }
    }
}