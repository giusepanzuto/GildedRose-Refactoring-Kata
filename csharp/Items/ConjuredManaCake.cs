namespace csharp
{
    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(ItemStatus itemStatus): base("Conjured Mana Cake", itemStatus)
        {
        }

        public override void UpdateQuality()
        {
            Quality.Decrease();

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                Quality.Decrease();
            }
        }
    }
}
