using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Books
{
  public class BookType : ObjectGraphType<Book>
  {
    public BookType()
    {
      Name = "Book";
      Description = "Book Type";
    }
  }
}
