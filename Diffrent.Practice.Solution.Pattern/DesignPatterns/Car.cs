namespace Diffrent.Practice.Solution.Pattern.DesignPatterns
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car Drive");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike Drive");
        }
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Car"))
            {
                return new Car();
            }
            else if (vehicleType.Equals("Bike"))
            {
                return new Bike();
            }
            throw new NotImplementedException();
        }
    }

    public class Extract
    {
        /*static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.GetVehicle("Bike");
            vehicle.Drive();
        }*/
    }
}
