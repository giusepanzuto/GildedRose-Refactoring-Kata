namespace csharp.Items.QualityUpdater
{
    public class QualityUpdaterIncrease : IQualityUpdater
    {
        public void UpdateStatus(ItemStatus status)
        {
            status.Quality.Increase();

            status.SellIn--;

            if (status.SellIn < 0)
            {
                status.Quality.Increase();
            }
        }
    }
}