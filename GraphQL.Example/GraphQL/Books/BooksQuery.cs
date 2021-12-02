using GraphQL.Example.Data;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Books
{
  public class BooksQuery : ObjectGraphType
  {
    public BooksQuery()
    {
      Field<ListGraphType<BookType>>("books", resolve: context =>
      {
        var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();

        return dataContext?.Books.ToList();
      });
    }
  }
}
