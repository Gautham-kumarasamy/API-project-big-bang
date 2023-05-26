using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int customerid { get; set; }

        //customer id as primary key
        [Required]
        public string? name { get; set; }
        [Required]  
        public string? email { get; set; }
        [Required]  
        public string? password { get; set; }
        // Other customer properties

        
    }
}
