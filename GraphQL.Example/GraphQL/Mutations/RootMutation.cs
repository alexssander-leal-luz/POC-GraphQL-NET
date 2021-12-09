using GraphQL.Example.GraphQL.Mutations.Groups;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Mutations
{
  public class RootMutation : ObjectGraphType
  {
    public RootMutation()
    {
      Name = "Mutations";
      Field<BooksMutation>("Books", resolve: context => new { });
      Field<PublishersMutation>("Publishers", resolve: context => new { });
    }
  }
}
