using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    
        internal class Commerce : Student
        {
            public int economics { get; set; }
            public int accounts { get; set; }

            public int banking { get; set; }

            public override double GetAvgerage()
            {
                return (economics + accounts + banking) / 3;
            }
        }
}


