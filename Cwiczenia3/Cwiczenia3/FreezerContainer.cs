namespace Cwiczenia3;

public class FreezerContainer : Container
{
    public string typeOfProduct { get; }
    public double temp { get; }

    public FreezerContainer(char type, double weight, double height, double curbWeight, double depth, double maxWeight, string typeOfProduct, double temp) : base('C', weight, height, curbWeight, depth, maxWeight)
    {
        this.typeOfProduct = typeOfProduct;
        this.temp = temp;
    }
}