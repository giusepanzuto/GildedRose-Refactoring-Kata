using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class GildedRose
    {
        readonly IList<IItem> _items;
        public GildedRose(IList<IItem> Items)
        {
            _items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                item.UpdateQuality();
            }
        }


    }
}
