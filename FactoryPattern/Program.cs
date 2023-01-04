namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to create a new car or a new motorcycyle?");
            var userVehicle = Console.ReadLine();

           VehicleFactory factory = new VehicleFactory();
            VehicleFactory.CreateVehicle(userVehicle);
            Console.WriteLine($"Here is your {userVehicle}!");
            
            Console.WriteLine("Want to make another vehicle?");
            userVehicle = Console.ReadLine();


        }
    }
}
