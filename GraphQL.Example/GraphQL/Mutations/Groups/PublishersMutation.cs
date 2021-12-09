using GraphQL.Example.Data;
using GraphQL.Example.Domain.DTOs.Publishers;
using GraphQL.Example.Domain.Entities;
using GraphQL.Example.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Mutations.Groups
{
  public class PublishersMutation : ObjectGraphType
  {
    public PublishersMutation()
    {
      Name = "PublishersMutations";

      Field<PublisherType>(
        "createPublisher",
        arguments: new QueryArguments(
          new QueryArgument<NonNullGraphType<PublisherCreateInputTypeDTO>> { Name = "publisher" }
        ),
        resolve: context =>
        {
          var dataPublisher = context.GetArgument<Publisher>("publisher");
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();
          var publisher = new Publisher
          {
            Name = dataPublisher?.Name,
          };

          dataContext?.Publishers?.Add(publisher);
          dataContext?.SaveChanges();

          return publisher;
        }
      );
    }
  }
}
