using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final333.MODEL
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        // Other customer properties

        
    }
}
