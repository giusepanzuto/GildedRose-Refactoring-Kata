namespace csharp
{
    public class QualityUpdater2 : IQualityUpdater
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