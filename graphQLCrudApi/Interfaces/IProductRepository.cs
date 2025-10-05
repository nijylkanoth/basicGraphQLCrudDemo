using graphQLCrudApi.Models;

namespace graphQLCrudApi.Interfaces;

public interface IProductRepository
{
    IEnumerable<ProductModel> GetProducts();
    ProductModel AddProduct(ProductModel product);
    ProductModel? UpdateProduct(ProductModel product);
    bool DeleteProduct(int ProductId);
}
