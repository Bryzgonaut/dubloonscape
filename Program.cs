using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds
{
    class Program
    {
        static void Main(string[] args)
        {
            Item testItem = new Item();
            testItem.Name = "Test Item 1";
            testItem.BaseValue = 100;
            testItem.Rarity = 0;
            testItem.Condition = Item.condition.broken;

            Console.WriteLine(testItem.Name + ": $" + testItem.TrueValue);

        }
    }
}
