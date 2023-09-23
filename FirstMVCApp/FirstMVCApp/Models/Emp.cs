using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models

{
    public class Emp
    {
        [Key]
        public int eno { get; set; }        //field name and column name in Table need not to be same.

        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20 chars")]
        public string name { get; set; }

        [Required]
        [Range(1000,500000)]
        public Decimal salary { get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="City must be between 3 and 20 chars")]
        public string city {  get; set; }

    }
}
