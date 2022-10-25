using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public interface IItemSource
    {
        IList<IItem> Get();
    }
}