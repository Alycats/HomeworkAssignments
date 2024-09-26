using System.Numerics;
using System.Runtime.CompilerServices;

namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        mileToKilo();
        calculator();
        Car();
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
        Console.WriteLine($"{miles} miles when converted is {totalKilo} Kilometers");

    }

    static void calculator()
    {
        double inputOne;
        double inputTwo;
        double add;
        double sub;
        double mult;
        double div;

        Console.WriteLine("Time to do some calculations, input two values when prompted");
        Console.WriteLine("Input the first value: ");
        inputOne = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input the second value: ");
        inputTwo = Convert.ToDouble(Console.ReadLine());
        add = inputOne + inputTwo;
        sub = inputOne - inputTwo;
        mult = inputOne * inputTwo;
        div = inputOne / inputTwo;
        Console.WriteLine($"So the totals of {inputOne} and {inputTwo} are : {add} added, {sub} subtracted, {mult} multiplied, and {div} divided.");


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

        Console.WriteLine ("Welcome to the resell car dealership, please enter the data below when prompted.");
        Console.WriteLine ("Please enter the make of your car:");
        make = Console.ReadLine();
        Console.WriteLine ("Please enter the model of your car:");
        model = Console.ReadLine();
        Console.WriteLine ("Please enter the year of your car:");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Please enter the color of your car:");
        color = Console.ReadLine();
        Console.WriteLine ("Please enter the mileage of your car:");
        mileage = Convert.ToDouble(Console.ReadLine());

        age = 2024-year;
        resaleCost = 20000 * (1 - 0.10 * age);

        Console.WriteLine ($"So for a {color} {year} {make} {model} with {mileage} miles the resale value would be {resaleCost}. ");
    }

}
