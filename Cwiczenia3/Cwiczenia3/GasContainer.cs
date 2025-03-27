namespace Cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    public double pressure { get; }

    public GasContainer(double weight, double height, double curbWeight, double depth,
        double maxWeight, double pressure) : base('G', weight, height, curbWeight, depth,
        maxWeight)
    {
        this.pressure = pressure;
    }

    public override void OffloadCargo()
    {
        weight *= 0.05;
    }

    public void Notify(string message)
    {
        Console.WriteLine(message + this.getSerialNumber());
    }
}