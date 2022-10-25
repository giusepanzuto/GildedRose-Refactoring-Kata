namespace csharp
{
    public abstract class Item : IItem
    {
        private readonly ItemStatus _status;
        public string Name { get; }
        public int SellIn
        {
            get => _status.SellIn;
            set => _status.SellIn = value;
        }
        public ItemQuality Quality => _status.Quality;

        protected Item(string name, ItemStatus itemStatus)
        {
            Name = name;
            _status = itemStatus;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public abstract void UpdateQuality();
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
