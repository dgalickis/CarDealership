using System;

namespace CarDealership;

internal class Program
{
    static void Main(string[] args)
    {

        Car ferrari = new Car
        {
            Brand = "Ferrari",
            Vin = 39585
        };
        Console.WriteLine($"Here we have instantiated a car object and described two of its properties {ferrari.Brand} and {ferrari.Vin} ");
    }
}
