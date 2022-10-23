namespace csharp
{
    public class Backstage : Item
    {
        public Backstage(int sellIn, ItemQuality quality) : 
            base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            Quality.Increase();

            if (SellIn < 11)
            {
                Quality.Increase();
            }

            if (SellIn < 6)
            {
                Quality.Increase();
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                ResetQuality();
            }
        }
    }
}
