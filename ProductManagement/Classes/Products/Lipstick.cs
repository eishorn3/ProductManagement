namespace ProductManagement.Classes.Products;

[Serializable]
public class Lipstick : Product
{
    public string? ProductColour { get; set; }
    public override string? ProductCategory { get; } = nameof(Lipstick);

    public override string ToString()
    {
        return base.ToString() + $"\tProductColour: {ProductColour}\n";
    }


}
