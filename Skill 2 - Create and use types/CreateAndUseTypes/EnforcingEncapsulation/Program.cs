using System;

namespace EnforcingEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();

            // driver.Drive(); Does not compile, since its methods implements interface methods explicitly, requiring explicit casting

            var truckDriver = driver as ITruckDriver;
            truckDriver.Drive();

            var carDriver = driver as ICarDriver;
            carDriver.Drive();

            Console.ReadKey();
        }
    }

    public interface ITruckDriver
    {
        void Drive();
    }

    public interface ICarDriver
    {
        void Drive();
    }

    public class Driver : ITruckDriver, ICarDriver
    {
        void ITruckDriver.Drive()
        {
            Console.WriteLine("Driving the truck!");
        }

        void ICarDriver.Drive()
        {
            Console.WriteLine("Driving the car!");
        }
    }
}
