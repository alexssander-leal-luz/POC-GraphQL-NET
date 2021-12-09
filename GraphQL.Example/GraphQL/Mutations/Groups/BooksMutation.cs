using GraphQL.Example.Data;
using GraphQL.Example.Domain.DTOs.Books;
using GraphQL.Example.Domain.Entities;
using GraphQL.Example.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Mutations.Groups
{
  public class BooksMutation : ObjectGraphType
  {
    public BooksMutation()
    {
      Name = "BooksMutations";

      Field<BookType>(
        "createBook",
        arguments: new QueryArguments(
          new QueryArgument<NonNullGraphType<BookCreateInputTypeDTO>> { Name = "book" }
        ),

        resolve: context =>
        {
          var dataBook = context.GetArgument<Book>("book");
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();
          var book = new Book
          {
            Title = dataBook?.Title,
            Author = dataBook?.Author,
            ISBN = dataBook?.ISBN,
            Language = dataBook?.Language,
            Pages = dataBook!.Pages,
            PublisherId = dataBook.PublisherId
          };

          dataContext?.Books?.Add(book);
          dataContext?.SaveChanges();

          return book;
        }
      );
    }
  }
}
