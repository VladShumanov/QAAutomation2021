namespace H4
{
    public class Car : Vehicle
    {
        protected bool hasRoof; // true or false

        public Car(double engineDisplacement, string transmissionType, double maximumSpeed, bool hasRoof) :
            base(engineDisplacement, transmissionType, maximumSpeed)
        {
            this.hasRoof = hasRoof;
        }

        public override string GetFullInfo()
        {
            return "Vehicle: car " + "Engine displacement: " + engineDisplacement.ToString() + " Transmission type: " + transmissionType +
                " Maximum speed: " + maximumSpeed.ToString() + " Has roof: " + hasRoof.ToString();
        }
    }
}