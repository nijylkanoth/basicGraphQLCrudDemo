using GraphQL.Types;
using graphQLCrudApi.Models;

namespace graphQLCrudApi.Types;
public class ProductType: ObjectGraphType<ProductModel>
{
    public ProductType()
    {
        Field(x => x.ProductId);
        Field(x => x.ProductName);
        Field(x => x.CreatedOn);
        Field(x => x.CreatedBy);
        Field(x => x.ModifiedOn);
        Field(x => x.ModifiedBy);

    }
}
