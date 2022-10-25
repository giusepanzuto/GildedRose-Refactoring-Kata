using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class ItemSource : IItemSource
    {
        public IList<IItem> Get()
        {
            return new List<IItem>
            {
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
        }
    }
}