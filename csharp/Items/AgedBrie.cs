namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality): base("Aged Brie", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            Quality.Increase();

            SellIn--;

            if (SellIn < 0)
            {
                Quality.Increase();
            }
        }
    }
}
