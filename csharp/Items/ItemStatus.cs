namespace csharp
{
    public class ItemStatus
    {
        public ItemStatus(ItemQuality quality, int sellIn)
        {
            Quality = quality;
            SellIn = sellIn;
        }

        public int SellIn { get; set; }
        public ItemQuality Quality { get; }
    }
}