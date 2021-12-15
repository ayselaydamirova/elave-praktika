using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CurrentOilLitr = 30;
            
          
          

            Console.WriteLine(OilStation.fillOil("Benzin92",59,car.MaxCapacity,2));

        }

           
       
    }
}
