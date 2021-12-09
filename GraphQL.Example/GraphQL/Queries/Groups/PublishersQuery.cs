using GraphQL.Example.Data;
using GraphQL.Example.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Queries.Groups
{
  public class PublishersQuery : ObjectGraphType
  {
    public PublishersQuery()
    {
      Name = "PublishersQueries";

      Field<ListGraphType<PublisherType>>(
        "publishers",
        resolve: context =>
        {
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();

          return dataContext?.Publishers?.ToList();
        }
      );
    }
  }
}
