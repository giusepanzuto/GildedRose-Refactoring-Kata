namespace csharp
{
    public class Backstage : Item
    {
        public Backstage(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                IncreaseQuality();

                if (SellIn < 11)
                {
                    IncreaseQuality();
                }

                if (SellIn < 6)
                {
                    IncreaseQuality();
                }
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                ResetQuality();
            }
        }
    }
}
