namespace csharp
{
    public class GildedRoseRunner
    {
        private readonly IItemsPresenter _itemsPresenter;
        private readonly IGildedRose _app;
        private readonly IItemSource _itemSource;

        public GildedRoseRunner(IItemsPresenter itemsPresenter, IGildedRose gildedRose, IItemSource itemSource)
        {
            _itemsPresenter = itemsPresenter;
            _app = gildedRose;
            _itemSource = itemSource;
        }

        public void Run()
        {
            var items = _itemSource.Get();

            for (var day = 0; day < 31; day++)
            {
                _itemsPresenter.WriteDailyItemStatus(day, items);

                _app.UpdateQuality(items);
            }
        }
    }
}