using System;

public class Program 
{
  public static void Main()
  {

    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("Enter contractor name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter contractor number: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter contractor start date (MM/DD/YYYY): ");
     string date = Console.ReadLine();

      Console.WriteLine("Enter contractor shift (1 for day, 2 for night): ");
      int shift = Convert.ToInt32(Console.ReadLine());
      while(shift != 1 && shift != 2)
      {
        Console.WriteLine("Invalid shift. Please enter 1 or 2 only.");
        shift = Convert.ToInt32(Console.ReadLine());
      }
      
      Console.WriteLine("Enter contractor pay rate: ");
      double rate = Convert.ToDouble(Console.ReadLine());

      Subcontractors contractor = new Subcontractors(name, number, date, shift, rate);
      contractor.DisplayInfo();

      Console.WriteLine("Would you like to continue? (Y/N)");
      string answer = Console.ReadLine();
      if(answer == "N")
      {
        Console.WriteLine("Thank you for using the program."); //Will allow user to create as many instance as they like until they input N, which would quit the program
        break;
      }
      
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
}

  

