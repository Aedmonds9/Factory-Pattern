namespace FactoryPattern
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Would you like to create a new car or a new motorcycyle?");
            var userVehicle = Console.ReadLine();

           VehicleFactory factory = new VehicleFactory();
           factory.CreateVehicle(userVehicle);
            
            Console.WriteLine("Want to make another vehicle?");
            userVehicle = Console.ReadLine();


        }
    }
}
