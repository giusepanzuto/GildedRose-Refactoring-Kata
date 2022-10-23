namespace csharp
{
    public class Sulfuras : Item
    {
        public Sulfuras(int sellIn, ItemQuality quality):base("Sulfuras, Hand of Ragnaros", sellIn , quality)
        {
        }

        public override void UpdateQuality()
        {
            //nope
        }
    }
}
