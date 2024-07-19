using System; 

class Program
{
static void Main()
{
  Console.WriteLine("Enter a value:\n");
  string userInput1 = Console.ReadLine();
    
  Console.WriteLine("Enter a second value:\n");
  string userInput2 = Console.ReadLine();
  try
  {
  int value1 = Convert.ToInt32(userInput1);
  int value2 = Convert.ToInt32(userInput2);
    
  int quotient = DivideValues(value1,value2);
  Console.WriteLine($"The quotient of {value1} divided by {value2} is: {quotient}");
  }
  catch (DivideByZeroException) 
  {
    Console.WriteLine ("Error: Dividing by zero is not allowed.");
  }
  catch (FormatException)
  {
    Console.WriteLine("Error: Invalid input. Please provide valid integer values.");
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Something went wrong. Detailed Error: {ex.Message}");   
  }
  Console.WriteLine("Press any key to exit:");
  Console.ReadKey();
}
  static int DivideValues(int value1, int value2) 
  {
    return value1 / value2;
  }
}
    
                      

                      
    
