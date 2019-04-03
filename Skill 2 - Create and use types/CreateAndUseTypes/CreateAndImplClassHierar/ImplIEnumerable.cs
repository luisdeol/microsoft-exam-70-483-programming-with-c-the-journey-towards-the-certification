using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndImplClassHierar
{
    class ImplIEnumerable
    {
        //static void Main(string[] args)
        //{
        //    var race = new Race("Crash Team Racing");

        //    var car1 = new RaceCar(1, "Doctor Neo Cortex");
        //    var car2 = new RaceCar(2, "Crash Bandicoot");
        //    var car3 = new RaceCar(2, "Doctor N. Gin");

        //    race.AddCar(car1);
        //    race.AddCar(car2);
        //    race.AddCar(car3);

        //    foreach (var car in race)
        //    {
        //        Console.WriteLine($"Car number: {car.Number}, Driver: {car.Driver}");
        //    }

        //    Console.ReadKey();
        //}
    }

    //public class Race : IEnumerable<RaceCar>
    //{
    //    private List<RaceCar> _cars;

    //    public Race(string title)
    //    {
    //        Title = title;
    //        _cars = new List<RaceCar>();
    //    }

    //    public string Title { get; set; }

    //    public void AddCar(RaceCar car)
    //    {
    //        _cars.Add(car);
    //    }

    //    public IEnumerator<RaceCar> GetEnumerator()
    //    {
    //        foreach(var car in _cars)
    //        {
    //            yield return car;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}

    //public class RaceCar
    //{
    //    public RaceCar(int number, string driver)
    //    {
    //        Number = number;
    //        Driver = driver;
    //    }

    //    public int Number { get; set; }
    //    public string Driver { get; set; }
    //}
}
