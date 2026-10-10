using BusinessLogic.Controller;
using Model;

namespace StudentRoom.App
{
    public partial class Form1 : Form
    {
        private RoomController controller = new RoomController();
        public Form1()
        {
            InitializeComponent();

        }
        private void LoadRooms()
        {
            dgvRooms.DataSource = controller.GetRooms();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Occupied");
            cbStatus.Items.Add("Maintenance");

            cbRoomType.Items.Add("Single");
            cbRoomType.Items.Add("Double");
            cbRoomType.Items.Add("Suite");

            LoadRooms();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();

                room.RoomNumber = int.Parse(txtRoomNumber.Text);

                room.RoomType = cbRoomType.Text;

                room.Price = decimal.Parse(txtPrice.Text);

                room.Status = cbStatus.Text;

                string result = RoomController.CreateRoom(room);

                MessageBox.Show(result);

                LoadRooms();

                txtRoomNumber.Clear();
                txtPrice.Clear();

                cbRoomType.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
