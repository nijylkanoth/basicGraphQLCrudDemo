using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Models;

namespace graphQLCrudApi.Query;

public class ProductMutation(IProductRepository productRepository)
{
    public ProductModel AddProduct(ProductInputModel product)
        => productRepository.AddProduct(new() { ProductName = product.ProductName });
                
    public ProductModel? UpdateProduct(ProductInputModel product)
        => productRepository.UpdateProduct(new() { ProductName = product.ProductName, ProductId = product.ProductId });
    public bool DeleteProduct(int ProductId)
        => productRepository.DeleteProduct(ProductId);
   
}
