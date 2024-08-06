using System;
using System.Collections.Generic;

namespace ContractorApp
{
    // Contractor class definition
    public class Contractor
    {
        // Properties
        public string Name { get; set; }
        public int ContractorNumber { get; set; }
        public DateTime StartDate { get; set; }

        // Constructor
        public Contractor(string name, int contractorNumber, DateTime startDate)
        {
            Name = name;
            ContractorNumber = contractorNumber;
            StartDate = startDate;
        }

        // Method to display contractor information
        public void DisplayInfo()
        {
            Console.WriteLine($"Contractor Name: {Name}");
            Console.WriteLine($"Contractor Number: {ContractorNumber}");
            Console.WriteLine($"Start Date: {StartDate.ToString("MM-DD-YYYY")}");
        }
    }

    // Subcontractor class definition, inheriting from Contractor
    public class Subcontractor : Contractor
    {
        // Properties
        public int Shift { get; set; }  // 1 for day, 2 for night
        public double HourlyPayRate { get; set; }

        // Constructor
        public Subcontractor(string name, int contractorNumber, DateTime startDate, int shift, double hourlyPayRate)
            : base(name, contractorNumber, startDate)
        {
            Shift = shift;
            HourlyPayRate = hourlyPayRate;
        }

        // Method to calculate pay with shift differential
        public double CalculatePay(double hoursWorked)
        {
            double basePay = hoursWorked * HourlyPayRate;
            if (Shift == 2) // Night shift differential
            {
                basePay *= 1.03; // 3% increase for night shift
            }
            return basePay;
        }

        // Method to display subcontractor information
        public void DisplaySubcontractorInfo()
        {
            DisplayInfo(); // Call base method to display contractor info
            Console.WriteLine($"Shift: {(Shift == 1 ? "Day" : "Night")}");
            Console.WriteLine($"Hourly Pay Rate: {HourlyPayRate:C}");
        }
    }

    // Main program to demonstrate the usage of classes
    class Program
    {
        static void Main(string[] args)
        {
            List<Subcontractor> subcontractors = new List<Subcontractor>();

            // Example: Adding subcontractors
            subcontractors.Add(new Subcontractor("D", 101, new DateTime(1,1,2024), 1, 25.50));
            subcontractors.Add(new Subcontractor("Diana", 101, new DateTime(1,10,2024), 2, 25.50));
            subcontractors.Add(new Subcontractor("Gedeon", 101, new DateTime(1,20,2024), 1, 25.50));
            subcontractors.Add(new Subcontractor("Jhonny", 101, new DateTime(1,30,2024), 2, 25.50));
            subcontractors.Add(new Subcontractor("Mike", 101, new DateTime(2,1,2024), 1, 25.50));
            

            // Display information and calculate pay
            foreach (var subcontractor in subcontractors)
            {
                subcontractor.DisplaySubcontractorInfo();
                Console.WriteLine($"Weekly Pay for 40 hours: {subcontractor.CalculatePay(40):C}\n");
            }

            // Allow user to add more subcontractors
            Console.WriteLine("Would you like to add another subcontractor? (yes/no)");
            while (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Enter subcontractor name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter contractor number:");
                int contractorNumber = int.Parse(Console.ReadLine());

                

                Console.WriteLine($"Start Date: {StartDate.ToString("MM-DD-YYYY")}");
                Console.WriteLine("Enter start date (MM-DD-YYYY):");



                Console.WriteLine("Enter shift (1 for day, 2 for night):");
                int shift = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter hourly pay rate:");
                double hourlyPayRate = double.Parse(Console.ReadLine());

                Subcontractor newSubcontractor = new Subcontractor(name, contractorNumber, startDate, shift, hourlyPayRate);
                subcontractors.Add(newSubcontractor);

                Console.WriteLine("Subcontractor added successfully!");

                // Display added subcontractor info
                newSubcontractor.DisplaySubcontractorInfo();
                Console.WriteLine($"Weekly Pay for 40 hours: {newSubcontractor.CalculatePay(40):C}\n");

                Console.WriteLine("Would you like to add another subcontractor? (yes/no)");
            }
        }
    }
}
