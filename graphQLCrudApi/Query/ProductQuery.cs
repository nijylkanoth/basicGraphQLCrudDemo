using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Models;

namespace graphQLCrudApi.Query;

public class ProductQuery(IProductRepository productRepository)
{
    public IEnumerable<ProductModel> GetProducts()
        => productRepository.GetProducts();

}
