namespace H4
{
    public abstract class Vehicle
    {
        protected double engineDisplacement; // liters
        protected string transmissionType; // manual, automatic or CVT
        protected double maximumSpeed; // km/h

        public Vehicle(double engineDisplacement, string transmissionType, double maximumSpeed)
        {
            this.engineDisplacement = engineDisplacement;
            this.transmissionType = transmissionType;
            this.maximumSpeed = maximumSpeed;
        }

        public abstract string GetFullInfo();
    }
}