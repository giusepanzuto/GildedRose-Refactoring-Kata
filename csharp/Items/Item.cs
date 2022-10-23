namespace csharp
{
    public abstract class Item
    {
        public string Name { get; }
        public int SellIn { get; set; }
        public ItemQuality Quality { get; }

        protected Item(string name, int sellIn, ItemQuality quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public abstract void UpdateQuality();

        protected void DecreaseQuality()
        {
            Quality.Decrease();
        }

        protected void ResetQuality()
        {
            Quality.Reset();
        }

        protected void IncreaseQuality()
        {
            Quality.Increase();
        }
    }
}
