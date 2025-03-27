using Cwiczenia3;

var c1 =new LiquidContainer(100, 20, 50, 20, 1000, false);
var c2 = new GasContainer(200, 30, 50, 20, 1000, 120);
var c3 = new GasContainer(200, 10, 50, 20, 1000, 120);
var c4 = new FreezerContainer(100, 20, 50, 20, 1000, "Meat", 10);

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);

var s1 = new ContainerShip(140, 5, 1000);
var s2 = new ContainerShip(140, 5, 1000);
s1.LoadContainer(c1);
s2.LoadContainer(c2);
s2.LoadContainer(c3);
s2.LoadContainer(c4);
Console.WriteLine(s1);
Console.WriteLine(s2);

s1.RemoveContainer(c1);
Console.WriteLine(s1);

List<Container> containers = new List<Container>(){ c1, c2, c3, c4 };
s1.LoadContainers(containers);
Console.WriteLine(s1);
s1.MoveContainer(c1, s2);
Console.WriteLine(s1);
Console.WriteLine(s2);