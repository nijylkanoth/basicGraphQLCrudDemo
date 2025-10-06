using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Query;
using graphQLCrudApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<ProductQuery>()
    .AddMutationType<ProductMutation>()
    ;

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapGraphQL("/graphql");

app.MapControllers();

app.Run();
