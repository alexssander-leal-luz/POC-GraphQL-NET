using GraphQL.Example.GraphQL.Mutations;
using GraphQL.Example.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
  public class GraphQLMainSchema : Schema
  {
    public GraphQLMainSchema(IServiceProvider provider)
    {
      Query = provider.GetRequiredService<RootQuery>();
      Mutation = provider.GetRequiredService<RootMutation>();
    }
  }
}
