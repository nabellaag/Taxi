using System;

namespace Taxi // project name.
{
    class program
    {
        
        static void Main(string[] args)
        { 
            // membuat objek Taxi
            Taxi driver1 = new Taxi();
            Taxi driver2 = new Taxi();

            //penggesetan nilai properties
            driver1.DriverName = "Joon";
            driver1.OnDuty = true;
            driver1.NumPassenger = 10;

            driver2.DriverName = "Dhani";
            driver2.OnDuty = true;
            driver2.NumPassenger = 11;


            //pemanggilan method
            driver1.TaxiInfo();
            driver1.PickUpPassengger();
            driver1.DropOffPassenger();

            driver2.TaxiInfo();
            driver2.PickUpPassengger();
            driver2.DropOffPassenger();

            Console.ReadKey();
        }
    }
}