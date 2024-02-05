namespace Vehicles
{
    public class Program
    {
        
        public static void Main()
        {
            Car megaSuperCar = new Car("LeBrand",
                        "First model",
                        "1234567Y",
                        123,
                        4,
                        2016,
                        "red",
                        4);
            Motorbike megaSuperBike = new Motorbike("LeBrand",
                        "First model",
                        "1234567Y",
                        123,
                        4,
                        2016,
                        10);
            Truck megaTruck = new Truck("LeBrand",
                        "First model",
                        "1234567Y",
                        123,
                        4,
                        2016,
                        "BOAT",
                        16f);
            Console.WriteLine($"{megaSuperCar.Brand} {megaSuperCar.Model} {megaSuperCar.isBig()}");
            Console.WriteLine($"{megaSuperBike.CubicCentimeters} {megaSuperBike.Model} {megaSuperBike.isSidecar()}");
            Console.WriteLine($"{megaTruck.Type} {megaTruck.Tones} {megaTruck.isHeavy()}");
        }
    }
}
