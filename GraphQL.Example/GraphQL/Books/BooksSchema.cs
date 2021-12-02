using GraphQL.Types;

namespace GraphQL.Example.GraphQL.Books
{
  public class BooksSchema : Schema
  {
    public BooksSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
      Query = serviceProvider.GetRequiredService<BooksQuery>();
      Mutation = serviceProvider.GetRequiredService<BooksMutation>();
    }
  }
}
