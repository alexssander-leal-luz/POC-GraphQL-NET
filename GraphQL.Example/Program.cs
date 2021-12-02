using System.Text.Json.Serialization;
using Estudos.BaltaIO.Tarefas.Data;
using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using GraphQLNetExample.Notes;
using Microsoft.EntityFrameworkCore;
using Telluria.Utils.Crud;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var dbVersion = builder.Configuration.GetSection("DataBaseVersion");
var version = new Version(
  dbVersion.GetValue<int>("Major"),
  dbVersion.GetValue<int>("Minor"),
  dbVersion.GetValue<int>("Build")
);

// Add services to the container.
// Add notes schema
builder.Services.AddSingleton<ISchema, NotesSchema>(services => new NotesSchema(new SelfActivatingServiceProvider(services)));

// Add CORS policy
builder.Services.AddCors(options =>
  options.AddPolicy("AllowAllOriginsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

// Connection of DB
builder.Services.AddDbContext<DataContext>(options => options
  .UseMySql(connectionString, new MySqlServerVersion(version)));
builder.Services.AddScoped<DbContext, DataContext>();
builder.Services.AddCrud();

// Register graphQL
builder.Services.AddGraphQL(options =>
  options.EnableMetrics = true).AddSystemTextJson();

// Default setup
builder.Services.AddControllers().AddJsonOptions(options =>
  options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddSwaggerGen(c =>
  c.SwaggerDoc("v1", new() { Title = "GraphQL NET Example", Version = "v1" }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GraphQL NET Example v1"));

  // Add altair UI to development only
  app.UseGraphQLAltair();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Make sure all our schemas registered to route
app.UseGraphQL<ISchema>();

app.Run();
