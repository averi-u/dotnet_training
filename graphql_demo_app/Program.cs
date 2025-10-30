using Microsoft.EntityFrameworkCore;
using HotChocolate.AspNetCore;
using HotChocolate.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();
app.MapGraphQL(); // endpoint: /graphql
app.Run();

public class Query
{
    public string Hello() => "Hello from GraphQL in .NET!";
}