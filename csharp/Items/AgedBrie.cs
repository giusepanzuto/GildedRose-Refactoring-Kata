namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(ItemStatus itemStatus): base("Aged Brie", itemStatus)
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
