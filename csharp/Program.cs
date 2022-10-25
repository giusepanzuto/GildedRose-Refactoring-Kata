using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<IItem> Items = new List<IItem>{
                new Plus5DexterityVest(new ItemStatus(20, 10)),
                new AgedBrie(new ItemStatus(0, 2)),
                new ElixirOfTheMongoose(new ItemStatus(7, 5)),
                new Sulfuras(new ItemStatus(80, 0)),
                new Sulfuras(new ItemStatus(80, -1)),
                new Backstage(new ItemStatus(20, 15)),
                new Backstage(new ItemStatus(49, 10)),
                new Backstage(new ItemStatus(49, 5)),
				// this conjured item does not work properly yet
				new ConjuredManaCake(new ItemStatus(6, 3))
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
