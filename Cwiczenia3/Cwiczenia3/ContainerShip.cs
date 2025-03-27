namespace Cwiczenia3;

public class ContainerShip
{
    public List<Container> containers = new List<Container>();
    public double maxVelocity;
    public int maxContainers;
    public double maxWeight;

    public ContainerShip(double maxVelocity, int maxContainers, double maxWeight)
    {
        this.maxVelocity = maxVelocity;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (containers.Count >= maxContainers)
        {
            Console.WriteLine("Max containers reached");
        }
        containers.Add(container);
    }

    public void LoadContainers(List<Container> containers)
    {
        if (containers.Count >= maxContainers)
        {
            Console.WriteLine("Max containers reached");
        }

        for (int i = 0; i < containers.Count; i++)
        {
            this.containers.Add(containers[i]);
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
    }

    public void MoveContainer(Container container, ContainerShip ship)
    {
        this.RemoveContainer(container);
        ship.LoadContainer(container);
    }

    public override string ToString()
    {
        string info = "Ship maxWeight: " + maxWeight/1000 + "t, maxContainers: " + maxContainers + 
               "containers on ship: ";
        for (int i = 0; i < containers.Count; i++)
        {
            info += containers[i].ToString() + ", ";
        }
        return info;
    }
}