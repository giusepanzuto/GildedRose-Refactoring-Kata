using System;
using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class GildedRoseRunner
    {
        private readonly IList<IItem> _items;

        public GildedRoseRunner(IList<IItem> items)
        {
            _items = items;
        }

        public void RunFor(int days)
        {
            var app = new GildedRose(_items);

            for (var day = 0; day < days; day++)
            {
                WriteDailyItemStatus(day, _items);

                app.UpdateQuality();
            }
        }

        private static void WriteDailyItemStatus(int day, IList<IItem> Items)
        {
            Console.WriteLine($"-------- day {day} --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
        }
    }
}