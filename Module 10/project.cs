using System;

public class Program 
{
  public static void Main()
  {
    //instances  
    Subcontractors subcontractor1 = new Subcontractors("Jason", 98111,"12/13/2002", 1, 20.00);
    subcontractor1.DisplayInfo();
    
    Subcontractors subcontractor2 = new Subcontractors("Alan", 5100, "09/23/1972", 2, 20.00);
    subcontractor2.DisplayInfo();
    
    Subcontractors subcontractor3 = new Subcontractors("Henry", 98712, "01/13/2002", 1, 40.00);
    subcontractor3.DisplayInfo();
    
    Subcontractors subcontractor4 = new Subcontractors("Maria", 6500, "05/18/1996", 2, 50.00);
    subcontractor4.DisplayInfo();
    }

}
public class Contractors
{
  public string cName;
  public int cNumber;
  public string startDate;


  // gets and sets below
  
  public string Name
  {
    get {return cName; } // read access to contractor name
    set {cName = value; } // write access to contractor name
  }
  
  public int Number
  {
    get {return cNumber; } // read access to contractor number
    set {cNumber = value; } // write access to contractor number
  }

  public string date
  {
    get {return startDate; } // read access to contractor start date
    set {startDate = value; } // write access to contractor start date
  }

  public Contractors(string name, int number, string start) // constructor of the contractors class to give name, number and start date
  {
    cName = name;
    cNumber = number;
    startDate = start;
  }

}

public class Subcontractors : Contractors //Fields from contractors inherited to sub class
{
  public int shift;
  public double hourlyPayRate;

  public int Shift
  {
    get {return shift; } // read access to shift
    set {shift = value; } // write access to shift
  }

  public double payRate
  {
    get {return hourlyPayRate; } // read access to hourly pay rate
    set {hourlyPayRate = value; } // write access to hourly pay rate
  }

  public Subcontractors(string name, int number, string start, int wshift, double pay) : base(name, number, start)
  {
    shift = wshift;
    hourlyPayRate = pay;
  }
    public float ComputePay() 
  {
    float pay = (float)hourlyPayRate;
    if (shift == 2)
    {
      pay = pay * 1.03f;
    }
    return pay;
  }
  
  public void DisplayInfo() // method to display contractor information
    {
      float differentialPay = ComputePay();
      Console.WriteLine($"Name: {Name}, Number: {Number}, {date}, Shift: {shift}, Pay: ${differentialPay:F2}");
    }
}
  


