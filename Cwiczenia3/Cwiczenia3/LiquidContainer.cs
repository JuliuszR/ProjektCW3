namespace Cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazard;

    public LiquidContainer(double weight, double height, double curbWeight, double depth, double maxWeight,
        bool IsHazard) : base('L', weight, height, curbWeight, depth, maxWeight)
    {
        this.IsHazard = IsHazard;
    }

    public void Notify(string message)
    {
        Console.WriteLine(message + " " + this.getSerialNumber());
    }


    public override void LoadCargo(double weight)
    {
        double maxAllowed = IsHazard ? maxWeight * 0.5 : maxWeight * 0.9;

        if (this.weight + weight > maxAllowed)
        {
            Console.WriteLine(this.weight);
            Notify("Hazard detected on container");
            throw new OverfillException("Weight cannot be greater than max weight");
        }

        base.LoadCargo(weight);
    }
}