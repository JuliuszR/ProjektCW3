namespace Cwiczenia3;

public class FreezerContainer : Container
{
    private static readonly Dictionary<string, double> ProductTemperatures = new()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice Cream", -18 },
        { "Frozen Pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    public string typeOfProduct { get; }
    public double temp { get; }

    public FreezerContainer(double weight, double height, double curbWeight, double depth, double maxWeight, string typeOfProduct, double temp) : base('C', weight, height, curbWeight, depth, maxWeight)
    {
        if (!ProductTemperatures.ContainsKey(typeOfProduct))
        {
            throw new ArgumentException($"Unknown type of product: {typeOfProduct}");
        }

        if (temp < ProductTemperatures[typeOfProduct])
        {
            throw new ArgumentException($"Temperature cannot be less than {ProductTemperatures[typeOfProduct]}");
        }
        this.typeOfProduct = typeOfProduct;
        this.temp = temp;
    }
    
    
    
    
}