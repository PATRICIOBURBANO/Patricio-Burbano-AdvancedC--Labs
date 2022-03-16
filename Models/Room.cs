using System.ComponentModel.DataAnnotations;

namespace HotelAnnotations.Models
{
    public class Room
    {

        [Key]
        public int RoomNumber { get; set; }

        public int Capacity { get; set; }

        [EnumDataType(typeof(Section))]
        public object Section { get; set; }    

    }
    public enum Section
    {
        First,
        Second,
        Third
    }

}
