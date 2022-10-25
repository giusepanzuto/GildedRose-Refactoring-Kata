namespace csharp
{
    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(ItemStatus itemStatus): base("Conjured Mana Cake", itemStatus, new QualityUpdater2())
        {
        }
    }
}
