using Cwiczenia3;

var c1 =new LiquidContainer(100, 20, 50, 20, 1000, false);

var c2 = new GasContainer(200, 30, 50, 20, 1000, 120);
Console.WriteLine(c2.weight);
c2.OffloadCargo();
Console.WriteLine(c2.weight);