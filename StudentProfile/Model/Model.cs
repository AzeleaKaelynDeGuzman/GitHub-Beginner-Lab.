namespace Model
{
    public class Room
    {
        public int RoomNumber { get; set; }

        public string RoomType { get; set; } = "";

        public decimal Price { get; set; }

        public string Status { get; set; } = "";
    }
}