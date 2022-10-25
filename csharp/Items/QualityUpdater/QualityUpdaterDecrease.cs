namespace csharp.Items.QualityUpdater
{
    public class QualityUpdaterDecrease : IQualityUpdater
    {
        public void UpdateStatus(ItemStatus status)
        {
            status.Quality.Decrease();

            status.SellIn--;

            if (status.SellIn < 0)
            {
                status.Quality.Decrease();
            }
        }
    }
}