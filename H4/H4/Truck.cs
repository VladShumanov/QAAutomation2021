namespace H4
{
    public class Truck : Vehicle
    {
        protected double carryingCapacity; // tons

        public Truck(double engineDisplacement, string transmissionType, double maximumSpeed, double carryingCapacity) :
            base(engineDisplacement, transmissionType, maximumSpeed)
        {
            this.carryingCapacity = carryingCapacity;
        }

        public override string GetFullInfo()
        {
            return "Vehicle: truck " + "Engine displacement: " + engineDisplacement.ToString() + " Transmission type: " + transmissionType +
                " Maximum speed: " + maximumSpeed.ToString() + " Carrying capacity: " + carryingCapacity.ToString();
        }
    }
}