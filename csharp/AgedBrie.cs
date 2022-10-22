namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie()
        {
            Name = "Aged Brie";
            SellIn = 2;
            Quality = 0;
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
