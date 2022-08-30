using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }


        public override string ToString()
        {
            return $"Car Model={Model} has the price={Price}";
        }
    }

    public class TestCar
    {
        public static void Main()
        {
            Car b = new Car
            {
                Model = "X7",
                Price = 9600000,

            };


        }
    }
}
