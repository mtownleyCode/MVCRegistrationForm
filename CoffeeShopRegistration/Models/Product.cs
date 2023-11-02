namespace CoffeeShopRegistration.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? Category { get; set; }

    public string? Descr { get; set; }

    public decimal? Price { get; set; }
}
