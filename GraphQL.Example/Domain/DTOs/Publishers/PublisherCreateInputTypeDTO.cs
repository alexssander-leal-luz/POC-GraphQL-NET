using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.Domain.DTOs.Publishers
{
  public class PublisherCreateInputTypeDTO : InputObjectGraphType<Publisher>
  {
    public PublisherCreateInputTypeDTO()
    {
      Name = "PublisherCreateInput";
      Description = "Publisher Create Input Type DTO";
      Field(x => x.Name, nullable: false).Description("Publisher Name");
    }
  }
}
