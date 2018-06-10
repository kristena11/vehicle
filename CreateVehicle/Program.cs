using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateVehicle
{
       
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] vehicles = new Vehicle[8];
            vehicles[0] = new Vehicle("Aston Martin", "Vantage", 129000, 11111111111111111, new DateTime(2016, 1, 27), false);
            vehicles[1] = new Vehicle("Ford", "fusion", 28678.99, 22222222222222222, new DateTime(2016, 2, 24), false);
            vehicles[2] = new Vehicle("Honda", "Civic EX", 18713.27, 33333333333333333, new DateTime(2016, 2, 24), false);
            vehicles[3] = new Vehicle("Volkswagen", "Tiguan", 22250.23, 44444444444444444, new DateTime(2016, 3, 11), false);
            vehicles[4] = new Vehicle("BMW", "X1", 33900.00, 55555555555555555, new DateTime(2016, 4, 03), false);
            vehicles[5] = new Vehicle("Subaru", "Legacy", 22195.95, 66666666666666666, new DateTime(2016, 5, 16), false);
            vehicles[6] = new Vehicle("Nissan", "Juke", 20250.50, 77777777777777777, new DateTime(2016, 6, 23), false);
            vehicles[7] = new Vehicle();
                   
            Console.WriteLine("Inventory 6/23/2016\n");
            foreach (Vehicle aVehicle in vehicles)
                Console.WriteLine(aVehicle);
            Console.WriteLine("TOTAL INVENTORY:" + Vehicle.vehicleCount);
            Console.WriteLine("__________________________________________");

            vehicles[2].UpdateStatus();
            vehicles[2].UpdateInventory();
            Console.WriteLine("\n\n\nHonda Civic is SOLD");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("\n\n\nUpdated Report on Inventory 6/23/2016\n");
            foreach (Vehicle aVehicle in vehicles)
                Console.WriteLine(aVehicle);
            Console.WriteLine("TOTAL INVENTORY:" + Vehicle.vehicleCount);
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Press any Key to continue....");
            Console.ReadKey();
        }
      

    }
}
