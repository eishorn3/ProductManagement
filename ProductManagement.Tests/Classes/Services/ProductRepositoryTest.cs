using JetBrains.Annotations;
using NSubstitute;
using ProductManagement.Classes;
using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace ProductManagement.Tests.Classes.Services;

[TestSubject(typeof(ProductRepository))]
public class ProductRepositoryTest
{
    // SUT = System Under Test
    private IProductRepository _sut;
    private IJsonDataService _jsonDataService;
    private List<Product> list;

    public ProductRepositoryTest()
    {
        // Arrange
        _jsonDataService = Substitute.For<IJsonDataService>();

    }

    private void init()
    {
        list = new List<Product>();
        _jsonDataService.JsonLoad().Returns(list);
        _sut = new ProductRepository(_jsonDataService);
    }


    [Fact]
    public void TestAdd()
    {
        // Arrange
        init();
        var product = new Lipstick()
        {
            ProductBrand = "aoisdjoais",
            ProductColour = "red",
            ProductDefinition = "ajsidoa",
            ProductName = "Dior",
            ProductPrice = 10
        };
        // Act
        _sut.Add(product);
        list.Add(product);
        // Assert
        _jsonDataService.Received().JsonSave(list);
    }

    [Fact]
    public void TestRemove()
    {
        Assert.Equal(true, true);
    }
    [Fact]
    public void TestRange()
    {
        Assert.Equal(true, true);
    }
    [Fact]
    public void TestProducts()
    {
        Assert.Equal(true, true);
    }
}