namespace graphQLCrudApi.Models;

public class ProductModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public required DateTimeOffset CreatedOn { get; set; }
    public required string CreatedBy { get; set; }
    internal DateTimeOffset ModifiedOn { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;

}
