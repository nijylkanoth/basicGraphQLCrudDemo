using GraphiQl;
using GraphQL;
using GraphQL.Types;
using graphQLCrudApi.CustomSchema;
using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Query;
using graphQLCrudApi.Repository;
using graphQLCrudApi.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

builder.Services.AddTransient<ProductType>();
builder.Services.AddTransient<ProductInputType>();

builder.Services.AddTransient<ProductQuery>();
builder.Services.AddTransient<ProductMutation>();

builder.Services.AddTransient<ISchema, ProductSchema>();
builder.Services.AddGraphQL(b=> b.AddAutoSchema<ISchema>().AddSystemTextJson());

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//app.UseAuthorization();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.MapControllers();

app.Run();
