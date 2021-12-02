using GraphQL.Example.Data;
using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Books
{
  public class BooksMutation : ObjectGraphType
  {
    public BooksMutation()
    {
      Field<BookType>(
        "createBook",
        arguments: new QueryArguments(
          new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "message" }
        ),
        resolve: context =>
        {
          var message = context.GetArgument<string>("message");
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();
          var book = new Book
          {

          };

          dataContext?.Books.Add(book);
          dataContext?.SaveChanges();

          return book;
        }
      );
    }
  }
}
