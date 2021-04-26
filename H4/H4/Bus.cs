namespace H4
{
    public class Bus : Vehicle
    {
        protected int numberSeats;

        public Bus(double engineDisplacement, string transmissionType, double maximumSpeed, int numberSeats) :
            base(engineDisplacement, transmissionType, maximumSpeed)
        {
            this.numberSeats = numberSeats;
        }

        public override string GetFullInfo()
        {
            return "Vehicle: bus " + "Engine displacement: " + engineDisplacement.ToString() + " Transmission type: " + transmissionType +
                " Maximum speed: " + maximumSpeed.ToString() + " Number seats: " + numberSeats.ToString();
        }
    }
}