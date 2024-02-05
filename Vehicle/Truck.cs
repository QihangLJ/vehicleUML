namespace Vehicles
{
    public class Truck : Vehicle
    {
        private string type;
        private float tones;
        public Truck(string brand,
            string model,
            string licensplate,
            float kms,
            int wheels,
            int year,
            string type,
            float tones) : base(brand,
            model,
            licensplate,
            kms,
            wheels,
            year)
        {
            this.Type = type;
            this.Tones = tones;
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public float Tones
        {
            get => this.tones;
            set => this.tones = value;
        }
        public bool isHeavy()
        {
            const int LimitTones = 15;
            return this.Tones>=LimitTones;
        }
    }
}
