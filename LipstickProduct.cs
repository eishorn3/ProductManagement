using System;

public class LipstickProduct
{
    public string LipstickName { get; set; }
    public string LipstickBrand { get; set; }
    public string LipstickColour { get; set; }
    public decimal LipstickPrice { get; set; }

    public LipstickProduct(string lipstickName, string lipstickBrand, string lipstickColour, decimal lipstickPrice)
    {
        LipstickName = lipstickName;
        LipstickBrand = lipstickBrand;
        LipstickColour = lipstickColour;
        LipstickPrice = lipstickPrice;
    }

    public void WriteToConsole()
    {
        Console.WriteLine($"LipstickName: {LipstickName}\t | \tLipstickBrand: {LipstickBrand}\t | \tLipstickColour: {LipstickColour}\t | \tLipstickPrice: {LipstickPrice}\t");
    }

}