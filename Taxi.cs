using System;

namespace Taxi // project name.
{
    public class Taxi
    {
        //properties
        public string? DriverName { get; set; }
        public int NumPassenger { get; set; }
        public bool OnDuty { get; set; }


        //method 
        public void TaxiInfo()
        {
            Console.WriteLine("           Taxi Info               ");
            Console.WriteLine("Driver Name         : {0}", DriverName);
            Console.WriteLine("On Duty             : {0}", OnDutyYN());
            Console.WriteLine("Number of Passenger : {0}\n", NumPassenger);
           

        }
        public void PickUpPassengger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang \n", DriverName);
        }

        //untuk mengubah nilai boolean ke string
        private string OnDutyYN()
        {
            return OnDuty ? "Yes": "No";
        }

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