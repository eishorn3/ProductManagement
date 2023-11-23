using System;


public interface IProduct 
{
    string ProductCategory { get; set; }
    string ProductBrand { get; set; }
    string ProductName { get; set; }
    string ProductDefinition { get; set; }
    decimal ProductPrice { get; set; }

    void WriteToConsole();
    void QuestionsAdd();
}


