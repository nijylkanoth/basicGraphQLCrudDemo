namespace graphQLCrudApi.Models;

public class ProductModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    internal DateTimeOffset ModifiedOn { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;

}

public class ProductInputModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }

}
