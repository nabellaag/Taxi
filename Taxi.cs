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

    }
}