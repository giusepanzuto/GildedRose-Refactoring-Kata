namespace csharp.Items.QualityUpdater
{
    public class QualityUpdaterBackstage : IQualityUpdater
    {
        public void UpdateStatus(ItemStatus status)
        {
            status.Quality.Increase();

            if (status.SellIn < 11)
            {
                status.Quality.Increase();
            }

            if (status.SellIn < 6)
            {
                status.Quality.Increase();
            }

            status.SellIn --;

            if (status.SellIn < 0)
            {
                status.Quality.Reset();
            }

        }
    }
}