namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality)
        {
            Name = "Aged Brie";
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateQuality()
        {
            IncreaseQuality();

            SellIn--;

            if (SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
