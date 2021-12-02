using Estudos.BaltaIO.Tarefas.Data;
using GraphQL.Example.Domain.Entities;
using GraphQL.Types;
using GraphQLNetExample.Notes;

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
          var notesContext = context.RequestServices.GetRequiredService<DataContext>();
          var note = new Note { Message = message };

          notesContext.Notes.Add(note);
          notesContext.SaveChanges();

          return note;
        }
      );
    }
  }
}
