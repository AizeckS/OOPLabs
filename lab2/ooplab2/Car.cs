using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab2
{
    class Car
    {
        private int id;
        private string model;
        private int year;
        private int price;
        private string regNum;

        public Car(int id, string model, int year, int price, string regNum)
        {
            this.Id = id;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.RegNum = regNum;
        }

        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public int Price { get => price; set => price = value; }
        public string RegNum { get => regNum; set => regNum = value; }

        public override string ToString()
        {
            string result = "ID=" + Id.ToString() + " Model=" + Model + " Year=" + Year.ToString() + " Price=" + Price.ToString() + "$ RegNum=" + RegNum;
            return result;
        }
    }
}
