using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);

    }
    class BMW : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 13000000;
            else if (name == "X7")
                return 9600000;
            else
                return 1000000;

        }
    }
    class Hyundai : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "Verna")
                return 1800000;
            else if (name == "Venue")
                return 1500000;
            else
                return 6000000;
        }
    }

}


