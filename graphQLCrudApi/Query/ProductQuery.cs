using GraphQL.Types;
using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Types;

namespace graphQLCrudApi.Query;

public class ProductQuery : ObjectGraphType
{
    public ProductQuery(IProductRepository productRepository)
    {
        Field<ListGraphType<ProductType>>("products").Resolve(context => productRepository.GetProducts());

    }
}
