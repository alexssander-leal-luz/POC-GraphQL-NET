using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Types
{
  public class PublisherType : ObjectGraphType<Publisher>
  {
    public PublisherType()
    {
      Name = "Publishers";
      Description = "Publisher Type";
      Field(x => x.Id, nullable: false).Description("Publisher Id");
      Field(x => x.Deleted, nullable: false).Description("Publisher Deleted");
      Field(x => x.CreatedAt, nullable: false).Description("Publisher Created At");
      Field(x => x.UpdatedAt, nullable: true).Description("Publisher Updated At");
      Field(x => x.DeletedAt, nullable: true).Description("Publisher Deleted At");
      Field(x => x.Name, nullable: false).Description("Publisher Name");
      Field(x => x.Books, nullable: true, type: typeof(ListGraphType<BookType>)).Description("Publisher Books");
    }
  }
}
