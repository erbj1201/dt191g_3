//Include
using System.ComponentModel.DataAnnotations;

//namespace
namespace BookDirectory.Models;

//Book class
public class Book
{
    //Properties
    public int Id { get; set; }

    //Required
    [Required(ErrorMessage = "Fyll i bokens namn")]
    //Change display name
    [Display(Name = "Namn:")]
    public string? Name { get; set; }

    //Required
    [Required(ErrorMessage = "Fyll i publiceringsår")]
    //Change display name
    [Display(Name = "Publiceringsår:")]
    public string? ReleaseYear { get; set; }
    public int? AuthorId { get; set; }

    //Change display name
    [Display(Name = "Författare:")]
    public Author? Author { get; set; }
}
