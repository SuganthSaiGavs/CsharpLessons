using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEfApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]  //maps doctorno with column in the database, if not given it takes the same name as the field name.
        public int Id { get; set; }

        [Required]      //Which means not null
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 and 20 characters ")]
        public string Name { get; set; }=string.Empty;

        [Required]
        public string Speciality { get; set; } = string.Empty;

        [Required]
        public DateTime DateofBirth { get; set; }

        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees {  get; set; }

        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal PhoneNumber {  get; set; }
    }
}
