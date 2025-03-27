namespace Cwiczenia3;

public class Container
{
    protected double _weight;
    private double _height;
    private double _curbWeight;
    private double _depth;
    private string _serialNumber;
    protected double _maxWeight;

    private int _number = 1;

    public Container(double weight, double height, double curbWeight, double depth, string serialNumber, double maxWeight, int number)
    {
        this._weight = weight;
        this._height = height;
        this._curbWeight = curbWeight;
        this._depth = depth;
        this._serialNumber = GenerateSerialNumber();
        this._maxWeight = maxWeight;
        this._number = number;
    }

    private string GenerateSerialNumber(string containerType)
    {
        string serialNumber = "KON-";
        serialNumber += containerType.ToUpper() + "-";
        serialNumber += _number;
        _number++;
        return serialNumber;
    }

    public void OffloadCargo()
    {
        _weight = 0;
    }

    public virtual void LoadCargo(double weight)
    {
        if (weight > _maxWeight)
            throw new OverfillException("Weight cannot be greater than max weight");
        
        this._weight = weight;
        
    }

    public string getSerialNumber()
    {
        return _serialNumber;
    }
}