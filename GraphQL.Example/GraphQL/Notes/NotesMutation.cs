using GraphQL.Example.Controllers;
using GraphQL.Example.Data;
using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQl.Notes
{
  public class NotesMutation : ObjectGraphType
  {
    public NotesMutation()
    {
      Field<NoteType>(
        "createNote",
        arguments: new QueryArguments(
          new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "message" }
        ),
        resolve: context =>
        {
          var message = context.GetArgument<string>("message");
          var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();
          var note = new Note { Message = message };

          dataContext?.Notes?.Add(note);
          dataContext?.SaveChanges();

          return note;
        }
      );
    }
  }
}
