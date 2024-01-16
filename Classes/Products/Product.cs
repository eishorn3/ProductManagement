using System.Text.Json.Serialization;

namespace ProductManagement.Classes.Products;

[JsonDerivedType(typeof(Lipstick), typeDiscriminator: "L")]
[JsonDerivedType(typeof(Perfume), typeDiscriminator: "P")]
public abstract class Product
{
    public virtual string? ProductCategory { get; }
    public string? ProductBrand { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDefinition { get; set; }
    public decimal? ProductPrice { get; set; }

    public override string ToString()
    {
        return $"ProductCategory: {ProductCategory}\t | \tProductName: {ProductName}\t | \tProductBrand: {ProductBrand}\t | \tProductDefinition: {ProductDefinition}\t | \tProductPrice: {ProductPrice}\t";
    }
}

