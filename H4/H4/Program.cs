using System;

namespace H4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1.9, "CVT", 220, true);
            Bus bus = new Bus(4.8, "automatic", 130, 12);
            Truck truck = new Truck(4.2, "manual", 160, 4.1);
            Motorcycle motorcycle = new Motorcycle(1.1, "automatic", 190, 2);

            Autopark autopark = new Autopark();
            autopark.AddVehicleToAutopark(car);
            autopark.AddVehicleToAutopark(bus);
            autopark.AddVehicleToAutopark(truck);
            autopark.AddVehicleToAutopark(motorcycle);

            autopark.GetAutopark();
            Console.ReadKey();
        }
    }
}