using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Types
{
  public class BookType : ObjectGraphType<Book>
  {
    public BookType()
    {
      Name = "Books";
      Description = "Book Type";
      Field(x => x.Id, nullable: false).Description("Book Id");
      Field(x => x.Deleted, nullable: false).Description("Book Deleted");
      Field(x => x.CreatedAt, nullable: false).Description("Book Created At");
      Field(x => x.UpdatedAt, nullable: true).Description("Book Updated At");
      Field(x => x.DeletedAt, nullable: true).Description("Book Deleted At");
      Field(x => x.Title, nullable: false).Description("Book Title");
      Field(x => x.Author, nullable: false).Description("Book Author");
      Field(x => x.ISBN, nullable: false).Description("Book ISBN");
      Field(x => x.Language, nullable: false).Description("Book Language");
      Field(x => x.Pages, nullable: false).Description("Book Pages");
      Field(x => x.PublisherId, nullable: true).Description("Book Publisher Id");
      Field(x => x.Publisher, nullable: true, type: typeof(PublisherType)).Description("Book Publisher");
    }
  }
}
