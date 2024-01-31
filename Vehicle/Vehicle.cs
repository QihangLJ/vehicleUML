namespace Vehicles
{
    public class Vehicle
    {
        private string? brand;
        private string? model;
        private string? licensplate;
        private float kms;
        private int wheels;
        private int year;

        public Vehicle(
            string brand,
            string model,
            string licensplate,
            float kms,
            int wheels,
            int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Licensplate = licensplate;
            this.Kms = kms;
            this.Wheels = wheels;
            this.Year = year;
        }

        public string Brand
        {
            get => this.brand;
            set => this.brand = value;
        }
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public string Licensplate
        {
            get => this.licensplate;
            set => this.licensplate = value;
        }
        public float Kms
        {
            get => this.kms;
            set => this.kms = value;
        }
        public int Wheels
        {
            get => this.wheels;
            set => this.wheels = value;
        }
        public int Year
        {
            get => this.year;
            set => this.year = value;
        }

        public bool isOlder()
        {
            const int YearLimit = 2005;
            return this.year < YearLimit;
        }
    }
}
