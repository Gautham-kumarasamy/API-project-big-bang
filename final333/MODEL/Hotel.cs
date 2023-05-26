using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hotelid { get; set; }
        public string? Customername { get; set; }
        public string? Customeraddress { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }

         public List<Rooms> Room { get; set; }
    }
}
