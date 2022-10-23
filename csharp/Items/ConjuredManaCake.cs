namespace csharp
{
    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Conjured Mana Cake";
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
