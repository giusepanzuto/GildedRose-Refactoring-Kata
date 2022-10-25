namespace csharp
{
    public class Backstage : Item
    {
        public Backstage(ItemStatus itemStatus) : 
            base("Backstage passes to a TAFKAL80ETC concert", itemStatus, new QualityUpdaterBackstage())
        {
        }
    }
}
