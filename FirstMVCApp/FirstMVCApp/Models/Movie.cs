using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstMVCApp.Models;


public class Movie
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string Title { get; set; }

    [MaxLength(100)]
    public string Language { get; set; }

    [MaxLength(255)]
    public string Hero { get; set; }

    [MaxLength(255)]
    public string Director { get; set; }

    [MaxLength(255)]
    public string MusicDirector { get; set; }

    public DateTime ReleaseDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Cost { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Collection { get; set; }

    [MaxLength(255)]
    public string Review { get; set; }
}
