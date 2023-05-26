using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roomid { get; set; }

        public Hotel? hotelid { get; set; }
        public string? roomnumber { get; set; }
        public string? type { get; set; }
        public int capacity { get; set; }
        public bool availability { get; set; }
        // Other room properties


    }
}
