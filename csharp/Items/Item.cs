namespace csharp
{
    public class Item : IItem
    {
        protected readonly ItemStatus _status;
        private readonly IQualityUpdater _qualityUpdater;

        public string Name { get; }
        public int SellIn
        {
            get => _status.SellIn;
            set => _status.SellIn = value;
        }
        public ItemQuality Quality => _status.Quality;

        protected Item(string name, ItemStatus itemStatus, IQualityUpdater qualityUpdater)
        {
            Name = name;
            _status = itemStatus;
            _qualityUpdater = qualityUpdater;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void UpdateQuality()
        {
            _qualityUpdater.UpdateStatus(_status);
        }
    }

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
