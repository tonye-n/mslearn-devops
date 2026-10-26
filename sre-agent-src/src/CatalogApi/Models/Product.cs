namespace CatalogApi.Models;

public class Product
{
    private int _stock;

    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock
    {
        get => _stock;
        set => _stock = Math.Max(0, value);
    }

    [Newtonsoft.Json.JsonIgnore]
    public bool IsInStock => Stock > 0;
}
