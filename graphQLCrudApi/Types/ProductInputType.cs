using GraphQL.Types;

namespace graphQLCrudApi.Types;
public class ProductInputType: InputObjectGraphType
{
    public ProductInputType()
    {
        Field<IntGraphType>("productid");
        Field<StringGraphType>("productname");
    }
}
