using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = {
            new Car(0,"Priora",2006,2000,"BO1212BO"),
            new Car(1,"Nuva",2009,1800,"AA5445BA"),
            new Car(2,"Logan",2011,3000,"CE7543EC"),
            new Car(3,"Logan",2009,2500,"AB7342BA"),
            new Car(4,"Cybertruck",2021,40000,"AA0007AA")
            };

            Program program = new Program();
            program.GetCarByModel(cars);
            program.GetCarByYear(cars);
            program.GetCarByYearAndPrice(cars);
            Console.ReadKey();
        }


        //a) список автомобілів заданої моделі;

        public void GetCarByModel(Car[] cars)
        {
            Console.WriteLine("Введіть модель яку хочете знайти:");
            string model = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (car.Model == model)
                    Console.WriteLine(car.ToString());
            }
        }
        //b) список автомобілів заданої моделі, які експлуатуються більше n років;
        public void GetCarByYear(Car[] cars)
        {
            Console.WriteLine("Введіть допустиме значення кількості років експлуатації:");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (Car car in cars)
            {
                int CarExp = 2019 - car.Year;
                if (CarExp > n)
                    Console.WriteLine(car.ToString());
            }
        }
        //c) список автомобілів заданого року випуску, ціна яких більше вказаної.
        public void GetCarByYearAndPrice(Car[] cars)
        {
            Console.WriteLine("Введіть рік випуску автомобіля:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть мінімальну ціну автомобіля:");
            int price = Convert.ToInt32(Console.ReadLine());
            foreach (Car car in cars)
            {
                if (year == car.Year && price < car.Price)
                    Console.WriteLine(car.ToString());
            }
        }
    }

}
