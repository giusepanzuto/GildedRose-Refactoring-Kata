using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public interface IGildedRose
    {
        void UpdateQuality(IList<IItem> items);
    }
}