using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public interface IItemsPresenter
    {
        void WriteDailyItemStatus(int day, IList<IItem> items);
    }
}