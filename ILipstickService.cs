using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement;

public interface ILipstickService : IProduct
{
    public Lipstick CreateLipsticktInput();

}