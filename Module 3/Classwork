/* Referencing the txt.file with the "bunny", "octopus", and "foo" class to demonstrate constructors, 
object initializers and fields */

using System;

class Program
{
    static void Main()
{
// instances
  Bunny bunny1  = new Bunny ("Alonso", eatsBananas: true, hatesCarrots: false);
  bunny1.DisplayInfo();

  Bunny bunny2 = new Bunny ("Theo", eatsBananas: false, hatesCarrots: true);
  bunny2.DisplayInfo();

  Bunny bunny3 = new Bunny ("Coco");
  bunny3.DisplayInfo();

  // Octopus class ; object initializer

  var octopusX = new Octopus("Davy Jones") { Age = 55 };
  octopusX.DisplayInfo();

  // Foo class
  Foo myfoo = new Foo();

  // method
  decimal value = 8.96785m;
  myfoo.SetA(value);

  //Auto property
  myfoo.SetAuto(5);

  int autoValue = myfoo.Auto;

  Console.WriteLine($"A: {myfoo.A}");
  Console.WriteLine($"Auto: {autoValue}");
}
}

using System;

public class Bunny 
{
  // Fields
  public readonly string Name;
  public bool EatsBananas;
  public bool HatesCarrots;

  // Constructor
  public Bunny (string name, bool eatsBananas = true, bool hatesCarrots = false)
 {
        Name = name;
        EatsBananas = eatsBananas;
        HatesCarrots = hatesCarrots;
  }

  public void DisplayInfo()
  {
    Console.WriteLine($"Name: {Name}, EatsBananas: {EatsBananas}, HatesCarrots: {HatesCarrots}");
  }
}

using System;

public class Octopus
{     
    // Fields
    public int Age = 55;
    public readonly string Name;
    public readonly int Limbs = 14;

    public Octopus(string name)
    {
        Name = name;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} the Octopus is {Age} years old and has approximately {Limbs} in their body!");
    }
}

using System;

//foo.cs
public class Foo 
{
    private decimal a;
    public Foo(decimal initialValue = 0)
{
    a = Math.Round(initialValue, 2);
}
public decimal A
{
    get{ return a; }
    private set { a = Math.Round (value, 2); }
  }

public int Auto { get; private set; } // Automatic Property

 public void SetAuto(int value)
    {
        Auto = value; 
    }

public void SetA(decimal value)
{
  a = Math.Round(value,2);
}
}
 
