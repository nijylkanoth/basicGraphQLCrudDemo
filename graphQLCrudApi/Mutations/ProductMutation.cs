using GraphQL;
using GraphQL.Types;
using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Models;
using graphQLCrudApi.Types;

namespace graphQLCrudApi.Query;

public class ProductMutation : ObjectGraphType
{
    public ProductMutation(IProductRepository productRepository)
    {
        Field<ProductType>("createproduct", arguments: new QueryArguments(
                    new QueryArgument<ProductInputType> { Name = "product" }
                ),resolve: context =>
                {
                    var product = context.GetArgument<ProductModel>("product");
                    return productRepository.AddProduct(product);
                })
                ;

        Field<ProductType>("updateproduct"
                , arguments: new QueryArguments(
                        new QueryArgument<ProductInputType> { Name = "product" }
                    )
                , resolve: context =>
                {
                    return productRepository.UpdateProduct(context.GetArgument<ProductModel>("product"));
                }
            );

        Field<BooleanGraphType>("deleteproduct"
                , arguments: new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "productid" }
                    )
                , resolve: context=>
                {
                    return productRepository.DeleteProduct(context.GetArgument<int>("productid"));
                }
            );
    }
}
