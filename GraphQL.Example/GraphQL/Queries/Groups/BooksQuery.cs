using GraphQL.Example.Data;
using GraphQL.Example.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Queries.Groups
{
  public class BooksQuery : ObjectGraphType
  {
    public BooksQuery()
    {
      Name = "BooksQueries";

      Field<ListGraphType<BookType>>(
        "books",
        resolve: context =>
        {
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();

          return dataContext?.Books?.ToList();
        }
      );
    }
  }
}
