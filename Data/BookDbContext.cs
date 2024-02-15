
//Include
using BookDirectory.Models;
using Microsoft.EntityFrameworkCore; 
//Namespace
namespace BookDirectory.Data; 
//Class
public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions <BookDbContext> options) : base (options) {}

    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books {get; set;}
}