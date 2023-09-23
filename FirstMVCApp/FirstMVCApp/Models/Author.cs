using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourAppNamespace.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

       
        [StringLength(200)] // Assuming a maximum length of 200 for the name. Adjust as needed.
        public string AuthorName { get; set; }

        
        public DateTime DateOfBirth { get; set; }

        public int NoOfBooksPublished { get; set; }

        [StringLength(200)] // Assuming a maximum length of 200 for the royalty company. Adjust as needed.
        public string RoyaltyCompany { get; set; }
    }
}
