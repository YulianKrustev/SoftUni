namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            FamilyCar fc = new FamilyCar(50, 10);
            fc.Drive(10);

            SportCar sc = new SportCar(200, 10);
            sc.Drive(10);

            CrossMotorcycle cm = new CrossMotorcycle(60, 10);
            cm.Drive(10);

            RaceMotorcycle rm = new RaceMotorcycle(80, 10);
            rm.Drive(10);

            System.Console.WriteLine($"{fc.Fuel} {fc.FuelConsumption}");
            System.Console.WriteLine($"{sc.Fuel} {sc.FuelConsumption}");
            System.Console.WriteLine($"{cm.Fuel} {cm.FuelConsumption}");
            System.Console.WriteLine($"{rm.Fuel} {rm.FuelConsumption}");
        }
    }
}
