using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class Rooms
    {    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roomid { get; set; }
        [ForeignKey("Hotel")]

        //adding rooms as forigenKey

        [Required]
        public int hotelid { get; set; }
        [Required]
        public string? type { get; set; }
        public bool availability { get; set; }
        


    }
}
