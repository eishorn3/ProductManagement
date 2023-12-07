namespace ProductManagement.Interfaces;

public interface IProduct
{
    string? ProductCategory { get; }
    string? ProductBrand { get; set; }
    string? ProductName { get; set; }
    string? ProductDefinition { get; set; }
    decimal? ProductPrice { get; set; }
}