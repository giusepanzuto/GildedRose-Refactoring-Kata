using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class GildedRose : IGildedRose
    {
        public void UpdateQuality(IList<IItem> items)
        {
            foreach (var item in items)
            {
                item.UpdateQuality();
            }
        }
    }
}
