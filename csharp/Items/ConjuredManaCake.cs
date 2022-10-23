namespace csharp
{
    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(int sellIn, ItemQuality quality): base("Conjured Mana Cake", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            DecreaseQuality();

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
