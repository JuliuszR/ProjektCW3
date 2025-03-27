namespace Cwiczenia3;

public class Container
{
    public double weight { get; set; }
    public double height { get; }
    public double curbWeight { get; }
    public double depth { get; }
    public string serialNumber { get; }
    public double maxWeight { get; }

    private static int _number = 1;

    public Container(char type, double weight, double height, double curbWeight, double depth,
        double maxWeight)
    {
        this.weight = weight;
        this.height = height;
        this.curbWeight = curbWeight;
        this.depth = depth;
        this.serialNumber = GenerateSerialNumber(type);
        this.maxWeight = maxWeight;
        _number++;
    }

    private string GenerateSerialNumber(char type)
    {
        string serialNumber = "KON-" + type + "-";
        serialNumber += _number;
        return serialNumber;
    }

    public virtual void OffloadCargo()
    {
        weight = 0;
    }

    public virtual void LoadCargo(double weight)
    {
        if (this.weight + weight > maxWeight)
            throw new OverfillException("Weight cannot be greater than max weight");

        this.weight += weight;
    }

    public string getSerialNumber()
    {
        return serialNumber;
    }

    public override string ToString()
    {
       return (this.serialNumber + " - cargo: " + weight + "/" + maxWeight + " kg");
    }
}