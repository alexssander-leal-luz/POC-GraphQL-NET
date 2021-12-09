using GraphQL.Example.GraphQL.Queries.Groups;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Queries
{
  public class RootQuery : ObjectGraphType
  {
    public RootQuery()
    {
      Name = "Queries";
      Field<BooksQuery>("Books", resolve: context => new { });
      Field<PublishersQuery>("Publishers", resolve: context => new { });
    }
  }
}
