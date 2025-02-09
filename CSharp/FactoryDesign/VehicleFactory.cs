using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.FactoryDesign
{
    public abstract class AutoMobilesFactory
    {
        public abstract IVehicle CreateVehicle();
    }

    public class CarFactory : AutoMobilesFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class BikeFactory : AutoMobilesFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }

    public class ExtractFactory
    {
        /*static void Main(string[] args)
        {
            AutoMobilesFactory autoMobiles = new CarFactory();
            IVehicle vehicle = autoMobiles.CreateVehicle();
            vehicle.Drive();
        }*/
    }
}
