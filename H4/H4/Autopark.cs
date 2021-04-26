using System;
using System.Collections;

namespace H4
{
    public class Autopark
    {
        private ArrayList autopark = new ArrayList();

        public void AddVehicleToAutopark(Vehicle vehicle)
        {
            autopark.Add(vehicle);
        }

        public void GetAutopark()
        {
            foreach (Vehicle vehicle in autopark)
            {
                Console.WriteLine(vehicle.GetFullInfo() + "\n");
            }
        }
    }
}