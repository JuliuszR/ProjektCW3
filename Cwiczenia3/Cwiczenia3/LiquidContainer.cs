namespace Cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _hazard;

    public LiquidContainer(double weight, double height, double curbWeight, double depth, string serialNumber, double maxWeight, int number, bool hazard) : base(weight, height, curbWeight, depth, serialNumber, maxWeight, number)
    {
        this._hazard = hazard;
    }

    public void Notify(Container container)
    {
        Console.WriteLine("Hazard detected on container" + container.getSerialNumber());
    }
    
     
    public override void LoadCargo(double weight)
    {
        if ((_hazard && weight > _maxWeight*0.5) || (!_hazard && weight < _maxWeight*0.9 ))
        {
            Notify(this);
        }
        this._weight = weight;
    }
    
}