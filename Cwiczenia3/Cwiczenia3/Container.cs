namespace Cwiczenia3;

public class Container
{
    private double weight;
    private double height;
    private double curbWeight;
    private double depth;
    private string serialNumber;
    private double maxWeight;

    private int number = 1;

    public Container(double weight, double height, double curbWeight, double depth, string serialNumber, double maxWeight, int number)
    {
        this.weight = weight;
        this.height = height;
        this.curbWeight = curbWeight;
        this.depth = depth;
        this.serialNumber = GenerateSerialNumber();
        this.maxWeight = maxWeight;
        this.number = number;
    }

    private string GenerateSerialNumber(string containerType)
    {
        string serialNumber = "KON-";
        serialNumber += containerType.ToUpper() + "-";
        serialNumber += number;
        number++;
        return serialNumber;
    }

    public void OffloadCargo()
    {
        weight = 0;
    }

    public void LoadCargo(double weight)
    {
        if (weight > maxWeight)
            throw new OverfillException("Weight cannot be greater than max weight");
        else
        {
            this.weight = weight;
        }
    }
}