using System.Windows.Forms;

namespace ReservationLibrary
{
    public class SeatPictureBox : PictureBox
    {
        public string Row { get; set; }
        public int Number { get; set; }
        public string Seat => $"{Row}{Number}";
        public bool Available { get; set; }
    }
}