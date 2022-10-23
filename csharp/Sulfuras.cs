namespace csharp
{
    public class Sulfuras : Item
    {
        public Sulfuras(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Sulfuras, Hand of Ragnaros";
        }

        public override void UpdateQuality()
        {
            //nope
        }
    }
}
