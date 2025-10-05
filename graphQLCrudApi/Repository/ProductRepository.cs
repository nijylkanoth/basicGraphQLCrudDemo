using graphQLCrudApi.Interfaces;
using graphQLCrudApi.Models;

namespace graphQLCrudApi.Repository;

public class ProductRepository : IProductRepository
{
    private List<ProductModel> _products = new();

    public ProductRepository()
    {
        LoadProducts();
    }

    public IEnumerable<ProductModel> GetProducts()
    {
        return _products;
    }

    public ProductModel AddProduct(ProductModel product)
    {
        product.ProductId = _products.Max(x => x.ProductId) + 1;
        product.CreatedOn = DateTimeOffset.Now;
        product.CreatedBy = "user";

        _products.Add(product);

        return product;
    }

    public ProductModel? UpdateProduct(ProductModel product)
    {
        var existingProduct = _products.Where(x => x.ProductId == product.ProductId).FirstOrDefault();
        if (existingProduct == null) return null;

        existingProduct.ProductName = product.ProductName;
        existingProduct.ModifiedOn = DateTimeOffset.Now;
        existingProduct.ModifiedBy = "user";

        return existingProduct;
    }

    public bool DeleteProduct(int ProductId)
    {
        var existingProduct = _products.Where(x => x.ProductId == ProductId).FirstOrDefault();
        if (existingProduct == null) return false;

        _products.Remove(existingProduct);

        return true;
    }

    private void LoadProducts()
    {
        _products.Clear();
        _products = new List<ProductModel>() { 
            new ProductModel()
            {
                ProductId = 1,
                ProductName = "Apple",
                CreatedOn = DateTimeOffset.Now,
                CreatedBy = "system"
            },
            new ProductModel()
            {
                ProductId = 2,
                ProductName = "Orange",
                CreatedOn = DateTimeOffset.Now,
                CreatedBy = "system"
            },
            new ProductModel()
            {
                ProductId = 3,
                ProductName = "Grapes",
                CreatedOn = DateTimeOffset.Now,
                CreatedBy = "system"
            },
        };
    }
}
