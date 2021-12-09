using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.Domain.DTOs.Books
{
  public class BookCreateInputTypeDTO : InputObjectGraphType<Book>
  {
    public BookCreateInputTypeDTO()
    {
      Name = "BookCreateInputDTO";
      Description = "Book Create Input Type DTO";
      Field(x => x.Title, nullable: false).Description("Book Title");
      Field(x => x.Author, nullable: false).Description("Book Author");
      Field(x => x.ISBN, nullable: false).Description("Book ISBN");
      Field(x => x.Language, nullable: false).Description("Book Language");
      Field(x => x.Pages, nullable: false).Description("Book Pages");
      Field(x => x.PublisherId, nullable: true).Description("Book Publisher Id");
    }
  }
}
