using Telluria.Utils.Crud.Entities;

namespace GraphQL.Example.Domain.Entities
{
  public class Publisher : BaseEntity
  {
    public Publisher() { }

    public Publisher(string name, ICollection<Book> books)
    {
      Name = name;
      Books = books;
    }

    public string? Name { get; set; }
    public virtual ICollection<Book>? Books { get; set; }
  }
}
