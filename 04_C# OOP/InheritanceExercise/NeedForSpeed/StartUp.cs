namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(12, 33);
            SportCar sportCar = new SportCar(12, 33);

            car.Drive(10);
            sportCar.Drive(10);

            System.Console.WriteLine(car.Fuel);
            System.Console.WriteLine(sportCar.Fuel);
            ;
        }
    }
}
