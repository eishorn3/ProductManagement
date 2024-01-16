using ProductManagement.Classes.Products;

[Serializable]
public class Perfume : Product
{

    public string? ProductScent { get; set; }
    public override string? ProductCategory { get; } = nameof(Perfume);



    public override string ToString()
    {
        return base.ToString() + $"\tProductScent: {ProductScent}\n";
    }

}