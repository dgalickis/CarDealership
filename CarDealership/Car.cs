using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    internal class Car
    {
        //example without constructor

        public string Brand  // property
        { get; set; }

        public int Vin  // property to describe vin no.
        { get; set; }

       // public int MyProperty { get; private set; } use prop or propg tab tab to load property or encapsulated property so it cant be set from other classes
       //controlling all the business logic.



        public void RegisterWithTollbooth()
        {

        }

        public void DeRegisterWithTollbooth()
        {

        }

        public void SetupPayment(float amount)
        {

        }


    }
}



//example of car with a constructor. use ctor as a shortcut to add a code snippet.


//public string model;
//public string color;
//public int year;

//// Create a class constructor with multiple parameters
//public Car(string modelName, string modelColor, int modelYear)
//{
//    model = modelName;
//    color = modelColor;
//    year = modelYear;
//}

//static void Main(string[] args)
//{
//    Car Ford = new Car("Mustang", "Red", 1969);
//    Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
//}
//}
