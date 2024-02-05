namespace Vehicles
{
    public class Car : Vehicle
    {
        private string color;
        private int doors;
        public Car(string brand,
            string model,
            string licensplate,
            float kms,
            int wheels,
            int year,
            string color,
            int doors) : base(brand,
            model,
            licensplate,
            kms,
            wheels,
            year)
        {
            this.Color = color;
            this.Doors = doors;
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Doors
        {
            get { return this.doors; }
            set { this.doors = value; }
        }
        public bool isBig()
        {
            const int LimitYear = 15;
            return this.Year>LimitYear;
        }
        
    }
}
