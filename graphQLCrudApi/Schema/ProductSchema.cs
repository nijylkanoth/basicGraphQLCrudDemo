using GraphQL.Types;
using graphQLCrudApi.Query;

namespace graphQLCrudApi.CustomSchema;


public class ProductSchema : Schema
{
    public ProductSchema(IServiceProvider serviceProvider): base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<ProductQuery>();
        Mutation = serviceProvider.GetRequiredService<ProductMutation>();

    }
}