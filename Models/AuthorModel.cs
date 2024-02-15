//Include
using System.ComponentModel.DataAnnotations;

//Namespace
namespace BookDirectory.Models;

//Author class
public class Author
{
    //Properties
    public int Id { get; set; }

    //Change display name
    [Display(Name = "Författarnamn:")]
    //Required
    [Required(ErrorMessage = "Fyll i författarnamn")]
    public string? Name { get; set; }

    public List<Book>? Books { get; set; }
}
