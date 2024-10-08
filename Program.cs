using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        // mileToKilo();
        // calculator(); Homework1
        // Car();
        age();
        conversion();
        salary();
    }

    static void mileToKilo()
    {
        double miles;
        double totalKilo;

        Console.WriteLine("Let us Convert Miles to Kilometers!");
        Console.WriteLine("Input Miles");
        miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles");
        totalKilo = miles * 1.60934;
        double rounded = Math.Round(totalKilo, 5);
        Console.WriteLine($"{miles} miles when converted is {rounded} Kilometers");

    }

    static void calculator()
    {
        double inputOne;
        double inputTwo;
        double add;
        double sub;
        double mult;
        double div;
        double modulus;

        Console.WriteLine("Time to do some calculations, input two values when prompted");
        Console.WriteLine("Input the first value: ");
        inputOne = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input the second value: ");
        inputTwo = Convert.ToDouble(Console.ReadLine());
        add = inputOne + inputTwo;
        sub = inputOne - inputTwo;
        mult = inputOne * inputTwo;
        div = inputOne / inputTwo;
        modulus = inputOne % inputTwo;
        double subRounded = Math.Round(sub, 3);
        double divRounded = Math.Round(div, 3);
        Console.WriteLine($"So the totals of {inputOne} and {inputTwo} are : {add} added, {subRounded} subtracted, {mult} multiplied, {divRounded} divided, and {modulus} remains.");


    }

    static void Car()
    {
        string make;
        string model;
        int year;
        string color;
        double mileage;
        int age;
        double resaleCost;

        Console.WriteLine("Welcome to the resell car dealership, please enter the data below when prompted.");
        Console.WriteLine("Please enter the make of your car:");
        make = Console.ReadLine();
        Console.WriteLine("Please enter the model of your car:");
        model = Console.ReadLine();
        Console.WriteLine("Please enter the year of your car:");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the color of your car:");
        color = Console.ReadLine();
        Console.WriteLine("Please enter the mileage of your car:");
        mileage = Convert.ToDouble(Console.ReadLine());

        age = 2024 - year;
        resaleCost = 20000 * (1 - 0.10 * age);
        double resaleRounded = Math.Round(resaleCost, 4);

        Console.WriteLine($"So for a {color} {year} {make} {model} with {mileage} miles the resale value would be {resaleRounded}. ");
    }

    static void age()
    {
        string first;
        string last;
        int age;
        string message;

        Console.WriteLine("Please Enter Your First Name:");
        first = Console.ReadLine();
        Console.WriteLine("Please Enter Your Last Name:");
        last = Console.ReadLine(); 

        
        while (true)
        {
            Console.WriteLine("Please Enter Your Age:");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out age))
            {
                if (age <0)
                {
                    Console.WriteLine("Invalid age entered.");
                    Console.WriteLine("Please Enter Your Age:");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric age:");
            }
        }

        if (age <= 12)
        {
            message = $"Hello, {first}! You’re just a kid!";
        }
        else if (age >= 13 && age <= 19)
        {
            message = $"Hey, {first}! You’re a teenager now!";
        }
        else if (age >= 20 && age <= 64)
        {
            message = $"Hi, {first}. Welcome to adulthood!";
        }
        else 
        {
            message = $"Hello, {first}. Enjoy your golden years!";
        }

         Console.WriteLine(message);
    }

    static void conversion()
    {
        while (true)
        {
            Console.WriteLine("Choose a type of conversion:");
            Console.WriteLine("1. Length: Convert meters to feet");
            Console.WriteLine("2. Weight: Convert kilograms to pounds");
            Console.WriteLine("3. Volume: Convert litres to gallons");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            double value;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter value in meters:");
                    if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                    {
                        double feet = value * 3.28084;
                        Console.WriteLine($"{value} meters is equal to {feet} feet.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive value.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter value in kilograms:");
                    if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                    {
                        double pounds = value * 2.20462;
                        Console.WriteLine($"{value} kilograms is equal to {pounds} pounds.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive value.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter value in litres:");
                    if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                    {
                        double gallons = value * 0.264172;
                        Console.WriteLine($"{value} litres is equal to {gallons} gallons.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive value.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void salary()
    {
        while (true)
        {
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            double basicSalary;
            while (true)
            {
                Console.WriteLine("Enter Basic Salary:");
                if (double.TryParse(Console.ReadLine(), out basicSalary) && basicSalary >= 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid positive value.");
            }

            double bonusPercentage;
            while (true)
            {
                Console.WriteLine("Enter Bonus Percentage:");
                if (double.TryParse(Console.ReadLine(), out bonusPercentage) && bonusPercentage >= 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid positive value.");
            }

            double totalSalary = basicSalary + (basicSalary * bonusPercentage / 100);
            double taxDeduction = totalSalary * 0.20;
            double netSalary = totalSalary - taxDeduction;

            Console.WriteLine("\nEmployee Summary:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"Bonus Percentage: {bonusPercentage}");
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Tax Deduction: {taxDeduction}");
            Console.WriteLine($"Net Salary: {netSalary}");

            Console.WriteLine("\nWould you like to enter details for another employee? (yes/no)");
            string continueInput = Console.ReadLine();
            if (continueInput?.ToLower() != "yes") break;
        }
    }
}
