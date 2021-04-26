namespace H4
{
    public class Motorcycle : Vehicle
    {
        protected int numberWheels;

        public Motorcycle(double engineDisplacement, string transmissionType, double maximumSpeed, int numberWheels) :
            base(engineDisplacement, transmissionType, maximumSpeed)
        {
            this.numberWheels = numberWheels;
        }

        public override string GetFullInfo()
        {
            return "Vehicle: motorcycle " + "Engine displacement: " + engineDisplacement.ToString() + " Transmission type: " + transmissionType +
                " Maximum speed: " + maximumSpeed.ToString() + " Number wheels: " + numberWheels.ToString();
        }
    }
}