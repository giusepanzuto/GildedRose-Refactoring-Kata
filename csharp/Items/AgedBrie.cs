namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(ItemStatus itemStatus): base("Aged Brie", itemStatus, new QualityUpdater1())
        {
        }
    }
}
