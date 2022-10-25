using System;
using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class ConsoleItemsPresenter : IItemsPresenter
    {
        public void WriteDailyItemStatus(int day, IList<IItem> items)
        {
            Console.WriteLine($"-------- day {day} --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
        }
    }
}