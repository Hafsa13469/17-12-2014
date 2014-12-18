using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedDataTypeMakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.name = "Mouse";
            item1.unitPrice = "400";

            string item1Name = item1.name;
            string item1Price = item1.unitPrice;


            Item item2 = new Item();
            item2.name = "Keyboard";
            item2.unitPrice = "500";

            


        }
    }
}
