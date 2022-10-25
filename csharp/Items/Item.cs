using csharp.Items.QualityUpdater;

namespace csharp.Items
{
    public class Item : IItem
    {
        private readonly ItemStatus _status;
        private readonly IQualityUpdater _qualityUpdater;
        
        private string Name { get; }

        protected Item(string name, ItemStatus itemStatus, IQualityUpdater qualityUpdater)
        {
            Name = name;
            _status = itemStatus;
            _qualityUpdater = qualityUpdater;
        }

        public override string ToString()
        {
            return this.Name + ", " + _status.SellIn + ", " + _status.Quality;
        }

        public void UpdateQuality()
        {
            _qualityUpdater.UpdateStatus(_status);
        }
    }
}
