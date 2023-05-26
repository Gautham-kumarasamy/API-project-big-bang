using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int hotelid { get; set; }
        [Required]  
        public string? Customername { get; set; }
        [Required]  
        public string? Customeraddress { get; set; }
        public string? city { get; set; }
        [Required]  
        public string? country { get; set; }


         public List<Rooms> Room { get; set; }
    }
}
