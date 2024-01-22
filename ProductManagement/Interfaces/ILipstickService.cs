using ProductManagement.Classes.Products;

namespace ProductManagement;

public interface ILipstickService
{
    public Lipstick CreateLipsticktInput();
    public void EditLipsticktInput(Lipstick lipstick);

}